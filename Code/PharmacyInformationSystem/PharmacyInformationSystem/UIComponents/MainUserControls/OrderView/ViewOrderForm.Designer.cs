
namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    partial class ViewOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.PharmacistAFM = new System.Windows.Forms.Label();
            this.OrderDateLbl = new System.Windows.Forms.Label();
            this.SellerLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.List = new System.Windows.Forms.ListView();
            this.DrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinalQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveInvoice = new System.Windows.Forms.Button();
            this.LogoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 14F);
            this.ExitBtn.Location = new System.Drawing.Point(632, 566);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(184, 52);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Έξοδος";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrderIdLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.OrderIdLbl.Location = new System.Drawing.Point(70, 11);
            this.OrderIdLbl.Name = "OrderIdLbl";
            this.OrderIdLbl.Size = new System.Drawing.Size(219, 24);
            this.OrderIdLbl.TabIndex = 79;
            this.OrderIdLbl.Text = "ΑΡΙΘΜΟΣ ΠΑΡΑΓΓΕΛΙΑΣ: ";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.LogoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPanel.CausesValidation = false;
            this.LogoPanel.Controls.Add(this.PharmacistAFM);
            this.LogoPanel.Controls.Add(this.OrderDateLbl);
            this.LogoPanel.Controls.Add(this.OrderIdLbl);
            this.LogoPanel.Location = new System.Drawing.Point(13, 83);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(803, 80);
            this.LogoPanel.TabIndex = 108;
            // 
            // PharmacistAFM
            // 
            this.PharmacistAFM.AutoSize = true;
            this.PharmacistAFM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PharmacistAFM.ForeColor = System.Drawing.Color.FloralWhite;
            this.PharmacistAFM.Location = new System.Drawing.Point(270, 45);
            this.PharmacistAFM.Name = "PharmacistAFM";
            this.PharmacistAFM.Size = new System.Drawing.Size(222, 24);
            this.PharmacistAFM.TabIndex = 81;
            this.PharmacistAFM.Text = "ΑΦΜ ΦΑΡΜΑΚΟΠΟΙΟΥ:  ";
            // 
            // OrderDateLbl
            // 
            this.OrderDateLbl.AutoSize = true;
            this.OrderDateLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrderDateLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.OrderDateLbl.Location = new System.Drawing.Point(458, 11);
            this.OrderDateLbl.Name = "OrderDateLbl";
            this.OrderDateLbl.Size = new System.Drawing.Size(146, 24);
            this.OrderDateLbl.TabIndex = 80;
            this.OrderDateLbl.Text = "ΗΜΕΡΟΜΗΝΙΑ: ";
            // 
            // SellerLbl
            // 
            this.SellerLbl.AutoSize = true;
            this.SellerLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerLbl.Location = new System.Drawing.Point(358, 10);
            this.SellerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellerLbl.Name = "SellerLbl";
            this.SellerLbl.Size = new System.Drawing.Size(159, 37);
            this.SellerLbl.TabIndex = 1;
            this.SellerLbl.Text = "ΕΠΩΝΥΜΙΑ";
            this.SellerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.CausesValidation = false;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.SellerLbl);
            this.panel3.Location = new System.Drawing.Point(13, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 60);
            this.panel3.TabIndex = 109;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_caduceus_48;
            this.pictureBox3.Location = new System.Drawing.Point(274, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // List
            // 
            this.List.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrugName,
            this.Category,
            this.DueDate,
            this.FinalQuantity,
            this.Price,
            this.Type});
            this.List.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.List.FullRowSelect = true;
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(13, 171);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(803, 386);
            this.List.TabIndex = 111;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // DrugName
            // 
            this.DrugName.Text = "Όνομα";
            this.DrugName.Width = 99;
            // 
            // Category
            // 
            this.Category.Text = "Κατηγορία";
            this.Category.Width = 105;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Ημ. Λήξης";
            this.DueDate.Width = 116;
            // 
            // FinalQuantity
            // 
            this.FinalQuantity.Text = "Ποσότητα";
            this.FinalQuantity.Width = 113;
            // 
            // Price
            // 
            this.Price.Text = "Τιμή";
            this.Price.Width = 66;
            // 
            // Type
            // 
            this.Type.Text = "Είδος";
            // 
            // SaveInvoice
            // 
            this.SaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.SaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveInvoice.FlatAppearance.BorderSize = 0;
            this.SaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveInvoice.Font = new System.Drawing.Font("Calibri", 14F);
            this.SaveInvoice.Location = new System.Drawing.Point(13, 566);
            this.SaveInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveInvoice.Name = "SaveInvoice";
            this.SaveInvoice.Size = new System.Drawing.Size(271, 52);
            this.SaveInvoice.TabIndex = 112;
            this.SaveInvoice.Text = "Εκτύπωση Τιμολογίου";
            this.SaveInvoice.UseVisualStyleBackColor = false;
            this.SaveInvoice.Click += new System.EventHandler(this.SaveInvoice_Click);
            // 
            // ViewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(827, 625);
            this.Controls.Add(this.SaveInvoice);
            this.Controls.Add(this.List);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Παραγγελία";
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label SellerLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label OrderDateLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PharmacistAFM;
        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader DrugName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader FinalQuantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button SaveInvoice;
    }
}