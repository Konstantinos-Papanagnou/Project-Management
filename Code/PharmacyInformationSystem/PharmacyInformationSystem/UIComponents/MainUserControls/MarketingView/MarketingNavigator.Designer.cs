
namespace PharmacyInformationSystem.UIComponents.MainUserControls.MarketingView
{
    partial class MarketingNavigator
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
            this.MarketingLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MarketingLbl
            // 
            this.MarketingLbl.AutoSize = true;
            this.MarketingLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarketingLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MarketingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.MarketingLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarketingLbl.Location = new System.Drawing.Point(50, 9);
            this.MarketingLbl.Name = "MarketingLbl";
            this.MarketingLbl.Size = new System.Drawing.Size(176, 26);
            this.MarketingLbl.TabIndex = 3;
            this.MarketingLbl.Text = "Κέρδος Φαρμάκου";
            this.MarketingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PharmacyInformationSystem.Properties.Resources.icons8_sales_performance_24;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MarketingNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MarketingLbl);
            this.Name = "MarketingNavigator";
            this.Size = new System.Drawing.Size(1259, 45);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MarketingLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
