
namespace PharmacyInformationSystem.UIComponents.MainUserControls.Pharmacist
{
    partial class TablePharmacist
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
            this.PharmacistList = new System.Windows.Forms.ListView();
            this.FirstNameColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AFMColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TownColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StreetColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalCodeColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellerIdColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // PharmacistList
            // 
            this.PharmacistList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PharmacistList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PharmacistList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColmn,
            this.LastNameColmn,
            this.AFMColmn,
            this.PhoneColmn,
            this.TownColmn,
            this.StreetColmn,
            this.NumberColmn,
            this.PostalCodeColmn,
            this.SellerIdColmn});
            this.PharmacistList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PharmacistList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacistList.ForeColor = System.Drawing.Color.FloralWhite;
            this.PharmacistList.HideSelection = false;
            this.PharmacistList.Location = new System.Drawing.Point(0, 0);
            this.PharmacistList.Name = "PharmacistList";
            this.PharmacistList.Size = new System.Drawing.Size(944, 639);
            this.PharmacistList.TabIndex = 0;
            this.PharmacistList.UseCompatibleStateImageBehavior = false;
            // 
            // FirstNameColmn
            // 
            this.FirstNameColmn.Text = "Όνομα";
            // 
            // LastNameColmn
            // 
            this.LastNameColmn.Text = "Επίθετο";
            // 
            // AFMColmn
            // 
            this.AFMColmn.Text = "Α.Φ.Μ.";
            // 
            // PhoneColmn
            // 
            this.PhoneColmn.Text = "Τηλέφωνο";
            // 
            // TownColmn
            // 
            this.TownColmn.Text = "Πόλη";
            // 
            // StreetColmn
            // 
            this.StreetColmn.Text = "Οδός";
            // 
            // NumberColmn
            // 
            this.NumberColmn.Text = "Αριθμός";
            // 
            // PostalCodeColmn
            // 
            this.PostalCodeColmn.Text = "Τ.Κ.";
            // 
            // SellerIdColmn
            // 
            this.SellerIdColmn.Text = "Κωδικός Πωλητή";
            // 
            // TablePharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.PharmacistList);
            this.Name = "TablePharmacist";
            this.Size = new System.Drawing.Size(944, 639);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PharmacistList;
        private System.Windows.Forms.ColumnHeader FirstNameColmn;
        private System.Windows.Forms.ColumnHeader LastNameColmn;
        private System.Windows.Forms.ColumnHeader AFMColmn;
        private System.Windows.Forms.ColumnHeader PhoneColmn;
        private System.Windows.Forms.ColumnHeader TownColmn;
        private System.Windows.Forms.ColumnHeader StreetColmn;
        private System.Windows.Forms.ColumnHeader NumberColmn;
        private System.Windows.Forms.ColumnHeader PostalCodeColmn;
        private System.Windows.Forms.ColumnHeader SellerIdColmn;
    }
}
