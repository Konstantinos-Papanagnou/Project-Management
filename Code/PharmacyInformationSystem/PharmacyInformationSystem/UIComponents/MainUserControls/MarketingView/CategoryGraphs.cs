using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    public partial class CategoryGraphs : UserControl
    {
        public CategoryGraphs(MarketingTeam MT)
        {
            InitializeComponent();

            DrawPieChart(MedToday, MT.CategoryProfitToday(), "Πιο Κερδοφόρες Κατηγορίες Σήμερα");
            DrawPieChart(MedMonth, MT.CategoryProfitThisMonth(), "Πιο Κερδοφόρες Κατηγορίες αυτό τον Μήνα");
            DrawPieChart(MedYear, MT.CategoryProfitThisYear(), "Πιο Κερδοφόρες Κατηγορίες αυτό τον Χρόνο");
        }

        private void DrawPieChart(Chart chart, Dictionary<string, double> values, string Title)
        {
            //reset your chart series and legends
            chart.Series.Clear();
            chart.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart.Legends.Add(Title);
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].Title = Title;
            chart.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = Title;
            chart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart.Series[seriesname].ChartType = SeriesChartType.Doughnut;

            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach(var key in values.Keys)
            {
                chart.Series[seriesname].Points.AddXY(key, values[key]);
            }
        }
    }
}
