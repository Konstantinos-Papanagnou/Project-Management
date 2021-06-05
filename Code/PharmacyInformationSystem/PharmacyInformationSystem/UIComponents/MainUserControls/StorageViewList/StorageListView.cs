using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    public partial class StorageListView : UserControl, IUpdatable<Medicine>
    {
        private readonly StoreKeeper User;
        private bool FirstTime = true;
        private readonly List<Medicine> Medicines;
        private int sortColumn;
        public StorageListView(StoreKeeper User)
        {
            this.User = User;
            InitializeComponent();
            Medicines = User.GetMedicines();
        }

        public void RefreshList()
        {
            List.Items.Clear();
            foreach (var med in Medicines)
            {
                AddToList(med);
            }
            
        }

        public void RefreshList(Medicine med, Operation op)
        {
            if (op == Operation.Add)
            {
                try
                {
                    med = User.AddMedicine(med);
                    AddToList(med);
                    Medicines.Add(med);
                }catch(BusinessLogic.SellerFunctionality.SQLConstraintException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(op == Operation.Update)
            {
                try { 
                //Update
                User.UpdateMedicine(med);
                List.Items.RemoveAt(SearchforRemove(med.MedID, false));
                AddToList(med);
                Medicines.RemoveAt(SearchforRemove(med.MedID));
                Medicines.Add(med);
                }
                catch (BusinessLogic.SellerFunctionality.SQLConstraintException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddToList(Medicine med)
        {
            var lvi = new ListViewItem(med.MedName){
                Tag = med.MedID
            };
            lvi.SubItems.Add(med.MedCategory);
            lvi.SubItems.Add(med.MedManfactureComp);
            lvi.SubItems.Add(med.MedDueDate);
            lvi.SubItems.Add(med.MedStockCount.ToString());
            lvi.SubItems.Add(med.MedMinStock.ToString());
            lvi.SubItems.Add(med.MedAcquisitionValue.ToString());
            lvi.SubItems.Add(med.MedSellingValue.ToString());
            lvi.SubItems.Add(MapValues(med.MedQuality));
            lvi.SubItems.Add(MapValues(med.MedType));
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


        private int SearchforRemove(int id, bool OurList = true)
        {
            for (int i = 0; i < Medicines.Count; i++)
                if (OurList) {
                    if (Medicines[i].MedID == id)
                        return i;
                }
                else
                {
                    if (int.Parse(List.Items[i].Tag.ToString()) == id)
                        return i;
                }
            return -1;
        }


        private void RemoveMenu_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count <= 0) return;
            MedicineViewDelete medicineDelete = new MedicineViewDelete();
            if(medicineDelete.ShowDialog() == DialogResult.OK)
            {
                User.RemoveMedicine(int.Parse(List.SelectedItems[0].Tag.ToString()));
                int index = SearchforRemove(int.Parse(List.SelectedItems[0].Tag.ToString()));
                Medicines.RemoveAt(index);
                List.Items.Remove(List.SelectedItems[0]);
            }
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count <= 0) return;
            ListViewItem lvi = List.SelectedItems[0];
            Medicine temp = new Medicine(int.Parse(lvi.Tag.ToString()), lvi.Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text, lvi.SubItems[3].Text, int.Parse(lvi.SubItems[4].Text), int.Parse(lvi.SubItems[5].Text),  double.Parse(lvi.SubItems[6].Text), double.Parse(lvi.SubItems[7].Text), lvi.SubItems[8].Text[0], lvi.SubItems[9].Text[0]);
            new MedicineViewAdd(this, Operation.Update, temp).ShowDialog();
        }


        private void StorageListView_Paint(object sender, PaintEventArgs e)
        {
            if (!FirstTime) return;

            FirstTime = false;
            string notification = "";
            foreach (var med in Medicines)
            {
                AddToList(med);
                if (med.MedMinStock >= med.MedStockCount)
                    notification += $"{med.MedName} πέρασε το κατώτερο δηλωμένο όριο {med.MedMinStock}\n";
            }
            if (string.IsNullOrEmpty(notification)) return;
            MessageBox.Show(notification, "Ενημέρωση ανανέωσης", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region It ain't much but it's honest work
        private void List_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                List.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (List.Sorting == SortOrder.Ascending)
                    List.Sorting = SortOrder.Descending;
                else
                    List.Sorting = SortOrder.Ascending;
            }
            List.SetSortIcon(sortColumn, List.Sorting);
            // Call the sort method to manually sort.
            List.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.List.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                              List.Sorting);
        }

        public class ListViewItemComparer : IComparer
        {

            private int col;
            private SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending.
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;
                return returnVal;
            }


        }
        #endregion

        private void ανανέωσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
    #region The Stack Overflow Region (Don't you dare touch me!)

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ListViewExtensions
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct HDITEM
        {
            public Mask mask;
            public int cxy;
            [MarshalAs(UnmanagedType.LPTStr)] public string pszText;
            public IntPtr hbm;
            public int cchTextMax;
            public Format fmt;
            public IntPtr lParam;
            // _WIN32_IE >= 0x0300 
            public int iImage;
            public int iOrder;
            // _WIN32_IE >= 0x0500
            public uint type;
            public IntPtr pvFilter;
            // _WIN32_WINNT >= 0x0600
            public uint state;

            [Flags]
            public enum Mask
            {
                Format = 0x4,       // HDI_FORMAT
            };

            [Flags]
            public enum Format
            {
                SortDown = 0x200,   // HDF_SORTDOWN
                SortUp = 0x400,     // HDF_SORTUP
            };
        };

        public const int LVM_FIRST = 0x1000;
        public const int LVM_GETHEADER = LVM_FIRST + 31;

        public const int HDM_FIRST = 0x1200;
        public const int HDM_GETITEM = HDM_FIRST + 11;
        public const int HDM_SETITEM = HDM_FIRST + 12;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, ref HDITEM lParam);

        public static void SetSortIcon(this ListView listViewControl, int columnIndex, SortOrder order)
        {
            IntPtr columnHeader = SendMessage(listViewControl.Handle, LVM_GETHEADER, IntPtr.Zero, IntPtr.Zero);
            for (int columnNumber = 0; columnNumber <= listViewControl.Columns.Count - 1; columnNumber++)
            {
                var columnPtr = new IntPtr(columnNumber);
                var item = new HDITEM
                {
                    mask = HDITEM.Mask.Format
                };

                if (SendMessage(columnHeader, HDM_GETITEM, columnPtr, ref item) == IntPtr.Zero)
                {
                    //It works - Don't Touch
                    throw new Win32Exception();
                }

                if (order != SortOrder.None && columnNumber == columnIndex)
                {
                    switch (order)
                    {
                        case SortOrder.Ascending:
                            item.fmt &= ~HDITEM.Format.SortDown;
                            item.fmt |= HDITEM.Format.SortUp;
                            break;
                        case SortOrder.Descending:
                            item.fmt &= ~HDITEM.Format.SortUp;
                            item.fmt |= HDITEM.Format.SortDown;
                            break;
                    }
                }
                else
                {
                    item.fmt &= ~HDITEM.Format.SortDown & ~HDITEM.Format.SortUp;
                }

                if (SendMessage(columnHeader, HDM_SETITEM, columnPtr, ref item) == IntPtr.Zero)
                {
                    throw new Win32Exception();
                }
            }
        }
    }
    #endregion
}
