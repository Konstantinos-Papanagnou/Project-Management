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
    public partial class ViewOrderForm : Form
    {
        public Logic.Order Order { get; private set; }
        public ViewOrderForm(Logic.Order Order)
        {
            this.Order = Order;
            InitializeComponent();
            OrderIdLbl.Text += Order.OrderID;
            OrderDateLbl.Text += Order.OrderDate;
            PharmacistAFM.Text += Order.Pharmacist.AFM.ToString();
            foreach (var item in Order.OrderList)
                AddToList(item, true);
        }

        private void AddToList(OrderLine order, bool setup = false)
        {
            var lvi = new ListViewItem(order.Medicine.MedName);
            lvi.SubItems.Add(order.Medicine.MedCategory);
            lvi.SubItems.Add(order.Medicine.MedDueDate);
            lvi.SubItems.Add(order.ProductQuantity.ToString());
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            Logic.PDFManager manager = new Logic.PDFManager(Order);
            manager.PrintInvoice();
        }
    }
}
