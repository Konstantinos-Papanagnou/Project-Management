
namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    partial class CategoryGraphs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MedToday = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MedMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MedYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.marketingNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView.MarketingNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.MedToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedYear)).BeginInit();
            this.SuspendLayout();
            // 
            // MedToday
            // 
            chartArea1.Name = "ChartArea1";
            this.MedToday.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MedToday.Legends.Add(legend1);
            this.MedToday.Location = new System.Drawing.Point(2, 175);
            this.MedToday.Name = "MedToday";
            this.MedToday.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MedToday.Series.Add(series1);
            this.MedToday.Size = new System.Drawing.Size(417, 440);
            this.MedToday.TabIndex = 1;
            this.MedToday.Text = "Κέρδος Φαρμάκων";
            // 
            // MedMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.MedMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MedMonth.Legends.Add(legend2);
            this.MedMonth.Location = new System.Drawing.Point(419, 175);
            this.MedMonth.Name = "MedMonth";
            this.MedMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.MedMonth.Series.Add(series2);
            this.MedMonth.Size = new System.Drawing.Size(417, 440);
            this.MedMonth.TabIndex = 2;
            this.MedMonth.Text = "Κέρδος Φαρμάκων";
            // 
            // MedYear
            // 
            chartArea3.Name = "ChartArea1";
            this.MedYear.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.MedYear.Legends.Add(legend3);
            this.MedYear.Location = new System.Drawing.Point(836, 175);
            this.MedYear.Name = "MedYear";
            this.MedYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.MedYear.Series.Add(series3);
            this.MedYear.Size = new System.Drawing.Size(417, 440);
            this.MedYear.TabIndex = 3;
            this.MedYear.Text = "Κέρδος Φαρμάκων";
            // 
            // marketingNavigator1
            // 
            this.marketingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.marketingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.marketingNavigator1.Margin = new System.Windows.Forms.Padding(5);
            this.marketingNavigator1.Name = "marketingNavigator1";
            this.marketingNavigator1.Size = new System.Drawing.Size(1679, 55);
            this.marketingNavigator1.TabIndex = 0;
            // 
            // MarketingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.MedYear);
            this.Controls.Add(this.MedMonth);
            this.Controls.Add(this.MedToday);
            this.Controls.Add(this.marketingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MarketingList";
            this.Size = new System.Drawing.Size(1259, 786);
            ((System.ComponentModel.ISupportInitialize)(this.MedToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MarketingNavigator marketingNavigator1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedToday;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedYear;
    }
}
