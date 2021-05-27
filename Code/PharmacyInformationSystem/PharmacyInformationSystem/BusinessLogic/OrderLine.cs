using PharmacyInformationSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem
{
    public class OrderLine
    {
        public int OrdID { get; set; }
        public Medicine Medicine { get; set; }
        public int ProductQuantity { get; set; }
        public double TotalProductCost { get; set; }

        public OrderLine(int OrdID, Medicine Medicine, int ProductQuantity, double TotalProductCost)
        {
            this.OrdID = OrdID;
            this.Medicine = Medicine;
            this.ProductQuantity = ProductQuantity;
            this.TotalProductCost = TotalProductCost;
        }
    }
}
