
namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    partial class Graphs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.YearlyGainBtn = new System.Windows.Forms.Button();
            this.YearlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MonthlyGainBtn = new System.Windows.Forms.Button();
            this.MonthlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.YearlyGainBtn);
            this.panel2.Controls.Add(this.YearlyChart);
            this.panel2.Location = new System.Drawing.Point(23, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 317);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_plus_1_year_24;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // YearlyGainBtn
            // 
            this.YearlyGainBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearlyGainBtn.FlatAppearance.BorderSize = 0;
            this.YearlyGainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearlyGainBtn.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.YearlyGainBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.YearlyGainBtn.Location = new System.Drawing.Point(0, 0);
            this.YearlyGainBtn.Name = "YearlyGainBtn";
            this.YearlyGainBtn.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.YearlyGainBtn.Size = new System.Drawing.Size(982, 28);
            this.YearlyGainBtn.TabIndex = 2;
            this.YearlyGainBtn.Text = "Ετήσιο Κέρδος Εταιρίας";
            this.YearlyGainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YearlyGainBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.YearlyGainBtn.UseVisualStyleBackColor = true;
            // 
            // YearlyChart
            // 
            this.YearlyChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            chartArea1.Name = "ChartArea1";
            this.YearlyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.YearlyChart.Legends.Add(legend1);
            this.YearlyChart.Location = new System.Drawing.Point(0, 28);
            this.YearlyChart.Name = "YearlyChart";
            this.YearlyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(67)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(16)))));
            series1.Legend = "Legend1";
            series1.Name = "Ετήσιο Κέρδος";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.XValueMember = "Έτη";
            series1.YValueMembers = "Πωλήσεις";
            this.YearlyChart.Series.Add(series1);
            this.YearlyChart.Size = new System.Drawing.Size(979, 289);
            this.YearlyChart.TabIndex = 1;
            this.YearlyChart.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MonthlyGainBtn);
            this.panel1.Controls.Add(this.MonthlyChart);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 317);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_plus_1_month_24;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MonthlyGainBtn
            // 
            this.MonthlyGainBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonthlyGainBtn.FlatAppearance.BorderSize = 0;
            this.MonthlyGainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthlyGainBtn.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MonthlyGainBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.MonthlyGainBtn.Location = new System.Drawing.Point(0, 0);
            this.MonthlyGainBtn.Name = "MonthlyGainBtn";
            this.MonthlyGainBtn.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.MonthlyGainBtn.Size = new System.Drawing.Size(994, 28);
            this.MonthlyGainBtn.TabIndex = 2;
            this.MonthlyGainBtn.Text = "Μηνιάιο Κέρδος Εταιρίας";
            this.MonthlyGainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MonthlyGainBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MonthlyGainBtn.UseVisualStyleBackColor = true;
            this.MonthlyGainBtn.Click += new System.EventHandler(this.MonthlyGainBtn_Click);
            // 
            // MonthlyChart
            // 
            this.MonthlyChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            chartArea2.Name = "ChartArea1";
            this.MonthlyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MonthlyChart.Legends.Add(legend2);
            this.MonthlyChart.Location = new System.Drawing.Point(0, 28);
            this.MonthlyChart.Name = "MonthlyChart";
            this.MonthlyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(170)))), ((int)(((byte)(232)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(146)))), ((int)(((byte)(225)))));
            series2.Legend = "Legend1";
            series2.Name = "Μηνιαίο Κέρδος";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.XValueMember = "Μήνες";
            series2.YValueMembers = "Πωλήσεις";
            this.MonthlyChart.Series.Add(series2);
            this.MonthlyChart.Size = new System.Drawing.Size(991, 289);
            this.MonthlyChart.TabIndex = 1;
            this.MonthlyChart.Text = "chart2";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Graphs";
            this.Size = new System.Drawing.Size(1259, 786);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyChart)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart YearlyChart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button YearlyGainBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MonthlyGainBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlyChart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
