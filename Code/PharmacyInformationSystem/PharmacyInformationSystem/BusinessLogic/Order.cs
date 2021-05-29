using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    class Order
    {
        public int OrderID { get; set; }
        public int SellerIDOrder { get; set; }
        public string SellerFirstName { get; set; }
        public string SellerLaststName { get; set; }
        public int PharmacistIDOrder { get; set; }
        public string PharmaFirstName { get; set; }
        public string PharmaLaststName { get; set; }
        public string PharmaAddressNumber { get; set; }
        public string PharmaAddressStreet { get; set; }
        public string PharmaAddressTown { get; set; }
        public string PharmaAddressPostalCode { get; set; }
        public string PharmaPhoneNumber { get; set; }
        public double TotalCost { get; set; }
        public string OrderDate { get; set; }
        public List<string> OrderList { get; set; }

        public Order(int orderID, int sellerIDOrder, string sellerFirstName, string sellerLaststName, int pharmacistIDOrder, string pharmaFirstName, string pharmaLaststName, string pharmaAddressNumber, string pharmaAddressStreet, string pharmaAddressTown, string pharmaAddressPostalCode, string pharmaPhoneNumber, double totalCost, string orderDate, List<string> orderList)
        {
            OrderID = orderID;
            SellerIDOrder = sellerIDOrder;
            SellerFirstName = sellerFirstName;
            SellerLaststName = sellerLaststName;
            PharmacistIDOrder = pharmacistIDOrder;
            PharmaFirstName = pharmaFirstName;
            PharmaLaststName = pharmaLaststName;
            PharmaAddressNumber = pharmaAddressNumber;
            PharmaAddressStreet = pharmaAddressStreet;
            PharmaAddressTown = pharmaAddressTown;
            PharmaAddressPostalCode = pharmaAddressPostalCode;
            PharmaPhoneNumber = pharmaPhoneNumber;
            TotalCost = totalCost;
            OrderDate = orderDate;
            OrderList = orderList;
        }
    }
}
