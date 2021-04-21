using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    public class Medicine
    {
        public int MedID { get; set; }
        public string MedName { get; set; }
        public string MedCategory { get; set; }
        public string MedManfactureComp { get; set; }
        public int MedStockCount { get; set; }
        public int MedMinStock { get; set; }
        public string MedDueDate { get; set; }
        public double MedAcquisitionValue { get; set; }
        public double MedSellingValue { get; set; }
        public string MedQuality { get; set; }

        public Medicine()
        {

        }

        public Medicine(int medID, string medName, string medCategory, string medManfactureComp, int medStockCount, int medMinStock, string medDueDate, double medAcquisitionValue, double medSellingValue, string medQuality)
        {
            this.MedID = medID;
            this.MedName = medName;
            this.MedCategory = medCategory;
            this.MedManfactureComp = medManfactureComp;
            this.MedStockCount = medStockCount;
            this.MedMinStock = medMinStock;
            this.MedDueDate = medDueDate;
            this.MedAcquisitionValue = medAcquisitionValue;
            this.MedSellingValue = medSellingValue;
            this.MedQuality = medQuality;
        }
    }
}
