
namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    partial class MarketingList
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
            this.marketingNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView.MarketingNavigator();
            this.drugGainTable1 = new PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView.DrugGainTable();
            this.SuspendLayout();
            // 
            // marketingNavigator1
            // 
            this.marketingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.marketingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.marketingNavigator1.Name = "marketingNavigator1";
            this.marketingNavigator1.Size = new System.Drawing.Size(1259, 45);
            this.marketingNavigator1.TabIndex = 0;
            // 
            // drugGainTable1
            // 
            this.drugGainTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.drugGainTable1.Location = new System.Drawing.Point(0, 43);
            this.drugGainTable1.Name = "drugGainTable1";
            this.drugGainTable1.Size = new System.Drawing.Size(944, 593);
            this.drugGainTable1.TabIndex = 1;
            // 
            // MarketingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.drugGainTable1);
            this.Controls.Add(this.marketingNavigator1);
            this.Name = "MarketingList";
            this.Size = new System.Drawing.Size(944, 639);
            this.ResumeLayout(false);

        }

        #endregion

        private MarketingNavigator marketingNavigator1;
        private DrugGainTable drugGainTable1;
    }
}
