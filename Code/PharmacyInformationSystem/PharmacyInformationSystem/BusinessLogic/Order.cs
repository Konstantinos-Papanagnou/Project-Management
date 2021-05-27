using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem
{
    /// <summary>
    /// Class for the Order
    /// </summary>
    class Order
    {
        public int OrderID { get; set; }
        public Seller Seller { get; set; }
        public Pharmacist Pharmacist { get; set; }
        public double TotalCost { get; set; }
        public string OrderDate { get; set; }
        public List<OrderLine> OrderList { get; set; }
        /// <summary>
        /// Constructs a new Order
        /// </summary>
        /// <param name="OrderID">The assigned Order ID</param>
        /// <param name="Seller">The assigned Seller</param>
        /// <param name="Pharmacist">The assigned Pharmacist</param>
        /// <param name="TotalCost">The total cost of the order</param>
        /// <param name="OrderDate">The date the order took place</param>
        /// <param name="OrderList">The list of items described in the order</param>
        public Order(int OrderID, Seller Seller, Pharmacist Pharmacist, double TotalCost, string OrderDate, List<OrderLine> OrderList)
        {
            this.OrderID = OrderID;
            this.Seller = Seller;
            this.Pharmacist = Pharmacist;
            this.TotalCost = TotalCost;
            this.OrderDate = OrderDate;
            this.OrderList = OrderList;
        }
    }
}
