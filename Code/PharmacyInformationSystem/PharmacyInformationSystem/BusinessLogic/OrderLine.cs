using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem
{
    class OrderLine
    {
        public int OrdID { get; set; }
        public int MediID { get; set; }
      /*  public string MediName { get; set; } */
        public int ProductQuantity { get; set; }
        public double TotalProductCost { get; set; }

        public OrderLine(int ordID, int mediID, int productQuantity, double totalProductCost)
        {
            OrdID = ordID;
            MediID = mediID;
            ProductQuantity = productQuantity;
            TotalProductCost = totalProductCost;
        }
    }
}
