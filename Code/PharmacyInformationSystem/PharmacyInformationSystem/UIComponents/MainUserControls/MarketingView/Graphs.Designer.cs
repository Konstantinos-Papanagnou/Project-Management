
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.YearlyGainBtn = new System.Windows.Forms.Button();
            this.YearlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MonthlyGainBtn = new System.Windows.Forms.Button();
            this.MonthlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gainNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView.GainNavigator();
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
            this.panel2.Location = new System.Drawing.Point(48, 438);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 372);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_plus_1_year_24;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
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
            this.YearlyGainBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearlyGainBtn.Name = "YearlyGainBtn";
            this.YearlyGainBtn.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            this.YearlyGainBtn.Size = new System.Drawing.Size(1157, 34);
            this.YearlyGainBtn.TabIndex = 2;
            this.YearlyGainBtn.Text = "Ετήσιο Κέρδος Εταιρίας";
            this.YearlyGainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YearlyGainBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.YearlyGainBtn.UseVisualStyleBackColor = true;
            // 
            // YearlyChart
            // 
            this.YearlyChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            chartArea3.Name = "ChartArea1";
            this.YearlyChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.YearlyChart.Legends.Add(legend3);
            this.YearlyChart.Location = new System.Drawing.Point(0, 34);
            this.YearlyChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearlyChart.Name = "YearlyChart";
            this.YearlyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(67)))));
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(16)))));
            series3.Legend = "Legend1";
            series3.Name = "Ετήσιο Κέρδος";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.XValueMember = "Έτη";
            series3.YValueMembers = "Πωλήσεις";
            this.YearlyChart.Series.Add(series3);
            this.YearlyChart.Size = new System.Drawing.Size(1100, 315);
            this.YearlyChart.TabIndex = 1;
            this.YearlyChart.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MonthlyGainBtn);
            this.panel1.Controls.Add(this.MonthlyChart);
            this.panel1.Location = new System.Drawing.Point(48, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 370);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_plus_1_month_24;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
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
            this.MonthlyGainBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthlyGainBtn.Name = "MonthlyGainBtn";
            this.MonthlyGainBtn.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            this.MonthlyGainBtn.Size = new System.Drawing.Size(1157, 34);
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
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            chartArea4.Name = "ChartArea1";
            this.MonthlyChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.MonthlyChart.Legends.Add(legend4);
            this.MonthlyChart.Location = new System.Drawing.Point(4, 34);
            this.MonthlyChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthlyChart.Name = "MonthlyChart";
            this.MonthlyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(170)))), ((int)(((byte)(232)))));
            series4.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(146)))), ((int)(((byte)(225)))));
            series4.Legend = "Legend1";
            series4.Name = "Μηνιαίο Κέρδος";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.XValueMember = "Μήνες";
            series4.YValueMembers = "Πωλήσεις";
            this.MonthlyChart.Series.Add(series4);
            this.MonthlyChart.Size = new System.Drawing.Size(1096, 334);
            this.MonthlyChart.TabIndex = 1;
            this.MonthlyChart.Text = "chart2";
            // 
            // gainNavigator1
            // 
            this.gainNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.gainNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gainNavigator1.Location = new System.Drawing.Point(0, 0);
            this.gainNavigator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gainNavigator1.Name = "gainNavigator1";
            this.gainNavigator1.Size = new System.Drawing.Size(1259, 55);
            this.gainNavigator1.TabIndex = 5;
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.gainNavigator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Graphs";
            this.Size = new System.Drawing.Size(1259, 781);
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
        private GainNavigator gainNavigator1;
    }
}
