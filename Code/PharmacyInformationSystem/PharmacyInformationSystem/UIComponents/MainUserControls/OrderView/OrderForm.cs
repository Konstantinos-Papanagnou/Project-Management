using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic = PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    public partial class OrderForm : Form
    {
        bool EditingMode = false;
        readonly Logic.Seller Seller;
        readonly List<Logic.Medicine> Drugs;
        readonly List<Logic.Pharmacist> Pharmacists;
        private readonly IUpdatable<Logic.Order> form;
        public Logic.Order Order { get; private set; }
        public OrderForm(IUpdatable<Logic.Order> form, Logic.Seller Seller)
        {
            this.form = form;
            Order = new Logic.Order();
            this.Seller = Seller;
            InitializeComponent();
            Pharmacists = Seller.GetPharmacists();
            foreach(var p in Pharmacists)
                PharmacistCombo.Items.Add(p.AFM);
            Drugs = Seller.GetMedicines();
            foreach (var drug in Drugs)
                DrugCombo.Items.Add(drug.MedName);
            Order.OrderID = Seller.GetNewOrderID();
            OrderIdLbl.Text += Order.OrderID;
            OrderDateLbl.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            Order.OrderDate = DateTime.Now.ToString("dd/MM/yyyy");
            Order.OrderList = new List<OrderLine>();
            Order.Seller = Seller;
        }

        public OrderForm(IUpdatable<Logic.Order> form, Logic.Seller Seller, Logic.Order Order)
        {
            InitializeComponent();

            Seller.RemoveOrder(Order);
            this.form = form;
            this.Order = Order;
            this.Seller = Seller;
            Pharmacists = Seller.GetPharmacists();
            foreach (var p in Pharmacists)
                PharmacistCombo.Items.Add(p.AFM);
            Drugs = Seller.GetMedicines();
            foreach (var drug in Drugs)
                DrugCombo.Items.Add(drug.MedName);
            OrderIdLbl.Text += Order.OrderID;
            OrderDateLbl.Text += Order.OrderDate;
            foreach (var item in Order.OrderList)
                AddToList(item, true);
        }

        private void DrugCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DrugCombo.SelectedIndex == -1) return;
            CategoryBox.Text = Drugs[DrugCombo.SelectedIndex].MedCategory;
            ManuBox.Text = Drugs[DrugCombo.SelectedIndex].MedManfactureComp;
            PriceBox.Text = Drugs[DrugCombo.SelectedIndex].MedSellingValue.ToString();
            DateBox.Text = Drugs[DrugCombo.SelectedIndex].MedDueDate;
            QuantityBox.Maximum = Drugs[DrugCombo.SelectedIndex].MedStockCount;
            FinalPriceLbl.Text = "Τελική Τιμή: " + (Drugs[DrugCombo.SelectedIndex].MedSellingValue * (double)QuantityBox.Value) + " €";
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            if (DrugCombo.SelectedIndex == -1) return;
            FinalPriceLbl.Text = "Τελική Τιμή: " + (Drugs[DrugCombo.SelectedIndex].MedSellingValue * (double)QuantityBox.Value) + " €";
        }

        private void PharmacistCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PharmacistCombo.SelectedIndex == -1) return;
            Order.Pharmacist = Pharmacists[PharmacistCombo.SelectedIndex];
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DrugCombo.SelectedIndex == -1) return;
            if (EditingMode)
            {
                AddBtn.Text = "+";
                EditingMode = false;
                RemoveBtn.Visible = false;
            }
            Order.OrderList.Add(new OrderLine(Order.OrderID, Drugs[DrugCombo.SelectedIndex], (int)QuantityBox.Value, (double)QuantityBox.Value * Drugs[DrugCombo.SelectedIndex].MedSellingValue));
            AddToList(Order.OrderList.Last());
            ClearFields();
        }

        private void AddToList(OrderLine order, bool setup = false)
        {
            var lvi = new ListViewItem(order.Medicine.MedName);
            lvi.SubItems.Add(order.Medicine.MedCategory);
            lvi.SubItems.Add(order.Medicine.MedDueDate);
            if (!setup)
                lvi.SubItems.Add(QuantityBox.Value.ToString());
            else lvi.SubItems.Add(order.ProductQuantity.ToString());
            lvi.SubItems.Add(order.Medicine.MedSellingValue.ToString());
            lvi.SubItems.Add(MapValues(order.Medicine.MedType));
            List.Items.Add(lvi);
        }

        private string MapValues(char value)
        {
            switch (value)
            {
                case 'Φ':
                    return "Φάρμακο";
                case 'Π':
                    return "Παραφαρμακευτικό";
                case 'Κ':
                    return "Κανονικό";
                default:
                    return "Γενόσημο";
            }
        }

        private void List_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (EditingMode) return;
            EditingMode = true;
            RemoveBtn.Visible = true;
            AddBtn.Text = ">";
            DrugCombo.SelectedItem = Order.OrderList[e.ItemIndex].Medicine.MedName;
            QuantityBox.Value = decimal.Parse(e.Item.SubItems[3].Text);
            Order.OrderList.RemoveAt(e.ItemIndex);
            List.Items.RemoveAt(e.ItemIndex);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (EditingMode)
            {

                AddBtn.Text = "+";
                EditingMode = false;
                RemoveBtn.Visible = false;
                ClearFields();
            }
        }

        public void ClearFields()
        {
            CategoryBox.Text = string.Empty;
            ManuBox.Text = string.Empty;
            PriceBox.Text = string.Empty;
            DateBox.Text = string.Empty;
            QuantityBox.Value = 0;
            DrugCombo.SelectedIndex = -1;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Order.OrderList.Count == 0) return;
            if(Order.Pharmacist == null)
            {
                MessageBox.Show("Πρέπει να επιλέξεις Φαρμακοποιό για να ολοκληρωθεί η παραγγελία!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double cost = 0;
            foreach(var o in Order.OrderList)
            {
                o.Medicine.MedStockCount -= o.ProductQuantity;
                Seller.UpdateStock(o.Medicine);
                cost += o.TotalProductCost;
            }
            Order.TotalCost = cost;
            
            if (Seller.InsertOrder(Order))
            {
                MessageBox.Show("Επιτυχής καταχώρηση παραγγελίας!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                form.RefreshList(Order, Operation.Add);
                this.Close();
            }
            
        }
    }
}
