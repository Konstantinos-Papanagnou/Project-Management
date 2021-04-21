﻿using System;
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
        public string MedType { get; set; }

        public Medicine()
        {

        }

        public Medicine(int medID, string medName, string medCategory, string medManfactureComp, int medStockCount, int medMinStock, string medDueDate, double medAcquisitionValue, double medSellingValue, string medQuality, string medType)
        {
            MedID = medID;
            MedName = medName ?? throw new ArgumentNullException(nameof(medName));
            MedCategory = medCategory ?? throw new ArgumentNullException(nameof(medCategory));
            MedManfactureComp = medManfactureComp ?? throw new ArgumentNullException(nameof(medManfactureComp));
            MedStockCount = medStockCount;
            MedMinStock = medMinStock;
            MedDueDate = medDueDate ?? throw new ArgumentNullException(nameof(medDueDate));
            MedAcquisitionValue = medAcquisitionValue;
            MedSellingValue = medSellingValue;
            MedQuality = medQuality ?? throw new ArgumentNullException(nameof(medQuality));
            MedType = medType ?? throw new ArgumentNullException(nameof(medType));
        }
    }
}
