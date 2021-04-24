
namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    partial class StorageNavigator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StorageLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            //this.pictureBox1.BackgroundImage = global::PharmacyInformationSystem.Properties.Resources.icons8_pill_bottle_24_1_;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StorageLbl
            // 
            this.StorageLbl.AutoSize = true;
            this.StorageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StorageLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StorageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.StorageLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StorageLbl.Location = new System.Drawing.Point(50, 9);
            this.StorageLbl.Name = "StorageLbl";
            this.StorageLbl.Size = new System.Drawing.Size(210, 26);
            this.StorageLbl.TabIndex = 2;
            this.StorageLbl.Text = "Κατάλογος Φαρμάκων";
            this.StorageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StorageNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StorageLbl);
            this.Name = "StorageNavigator";
            this.Size = new System.Drawing.Size(944, 45);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StorageLbl;
    }
}
