using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    public partial class Graphs : UserControl
    {
        public Graphs()
        {
            InitializeComponent();
            fillChart();
        }

        private void fillChart()
        {
            //...
            MonthlyChart.Series["Μηνιαίο Κέρδος"].XValueMember = "Μήνες";
            MonthlyChart.Series["Μηνιαίο Κέρδος"].YValueMembers = "Πωλήσεις";

            MonthlyChart.Series["Ετήσιο Κέρδος"].XValueMember = "Έτη";
            MonthlyChart.Series["Ετήσιο Κέρδος"].YValueMembers = "Πωλήσεις";

        }

        private void MonthlyGainBtn_Click(object sender, EventArgs e)
        {

        }   
    }
}
