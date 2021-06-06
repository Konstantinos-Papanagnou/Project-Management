using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic = PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    public partial class OrderList : UserControl, IUpdatable<Logic.Order>
    {
        private readonly Logic.Seller Seller;
        readonly List<Logic.Order> Orders;
        private int sortColumn;
        public OrderList(Logic.Seller Seller)
        {
            this.Seller = Seller;
            InitializeComponent();
            orderNavigator1.AddNew.Click += (object sender, EventArgs e) => {
                OrderForm form = new OrderForm(this, Seller);
                form.ShowDialog();
            };
            Orders = Seller.GetOrders();
            foreach(var order in Orders)
            {
                AddToList(order);
            }
            
        }

        public void RefreshList()
        {
            // Do Nothing
        }

        public void RefreshList(Logic.Order order, Operation op)
        {
            Orders.Add(order);
            AddToList(order);
        }

        private void AddToList(Logic.Order order)
        {
            var lvi = new ListViewItem(order.OrderID.ToString())
            {
                Tag = order.OrderID
            };
            lvi.SubItems.Add(order.Pharmacist.FirstName);
            lvi.SubItems.Add(order.Pharmacist.LastName);
            lvi.SubItems.Add(order.Pharmacist.AFM);
            lvi.SubItems.Add(order.OrderDate);
            lvi.SubItems.Add(order.TotalCost.ToString());
            List.Items.Add(lvi);
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

        private void RemoveMenu_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count <= 0) return;
            DeleteOrder orderDelete = new DeleteOrder();
            if (orderDelete.ShowDialog() == DialogResult.OK)
            {
                Seller.RemoveOrder(Orders[List.SelectedItems[0].Index]);
                Orders.RemoveAt(List.SelectedItems[0].Index);
                List.Items.Remove(List.SelectedItems[0]);
            }
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count <= 0) return;
            Logic.Order order = Orders[List.SelectedItems[0].Index];
            Orders.RemoveAt(List.SelectedItems[0].Index);
            List.Items.Remove(List.SelectedItems[0]);
            new OrderForm(this, Seller, order).ShowDialog();

        }

        private void List_DoubleClick(object sender, EventArgs e)
        {
            new ViewOrderForm(Orders[List.SelectedItems[0].Index]).ShowDialog();
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
