
namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    partial class MedicineViewData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineViewData));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.MinQuantityLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ManifaturerLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.MedicineNameLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CostLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.QualityLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.DueDateLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(17)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(456, 462);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 38);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Διαγραφή";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // MinQuantityLbl
            // 
            this.MinQuantityLbl.AutoSize = true;
            this.MinQuantityLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinQuantityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinQuantityLbl.Location = new System.Drawing.Point(19, 223);
            this.MinQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinQuantityLbl.Name = "MinQuantityLbl";
            this.MinQuantityLbl.Size = new System.Drawing.Size(128, 23);
            this.MinQuantityLbl.TabIndex = 12;
            this.MinQuantityLbl.Text = "Ελάχιστο όριο: ";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuantityLbl.Location = new System.Drawing.Point(19, 189);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(208, 23);
            this.QuantityLbl.TabIndex = 11;
            this.QuantityLbl.Text = "Απόθεμα στην αποθήκη: ";
            // 
            // ManifaturerLbl
            // 
            this.ManifaturerLbl.AutoSize = true;
            this.ManifaturerLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManifaturerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManifaturerLbl.Location = new System.Drawing.Point(19, 102);
            this.ManifaturerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManifaturerLbl.Name = "ManifaturerLbl";
            this.ManifaturerLbl.Size = new System.Drawing.Size(73, 23);
            this.ManifaturerLbl.TabIndex = 10;
            this.ManifaturerLbl.Text = "Εταιρία:";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryLbl.Location = new System.Drawing.Point(19, 66);
            this.CategoryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(102, 23);
            this.CategoryLbl.TabIndex = 9;
            this.CategoryLbl.Text = "Κατηγορία: ";
            // 
            // MedicineNameLbl
            // 
            this.MedicineNameLbl.AutoSize = true;
            this.MedicineNameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedicineNameLbl.Location = new System.Drawing.Point(19, 32);
            this.MedicineNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MedicineNameLbl.Name = "MedicineNameLbl";
            this.MedicineNameLbl.Size = new System.Drawing.Size(162, 23);
            this.MedicineNameLbl.TabIndex = 8;
            this.MedicineNameLbl.Text = "Όνομα φαρμάκου: ";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(239)))), ((int)(((byte)(84)))));
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(174)))), ((int)(((byte)(61)))));
            this.EditBtn.FlatAppearance.BorderSize = 2;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(299, 462);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(147, 38);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Επεξεργασία";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostLbl.Location = new System.Drawing.Point(19, 270);
            this.CostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(136, 23);
            this.CostLbl.TabIndex = 17;
            this.CostLbl.Text = "Κόστος αγοράς: ";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceLbl.Location = new System.Drawing.Point(19, 302);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(138, 23);
            this.PriceLbl.TabIndex = 18;
            this.PriceLbl.Text = "Τιμή προιόντος: ";
            // 
            // QualityLbl
            // 
            this.QualityLbl.AutoSize = true;
            this.QualityLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QualityLbl.Location = new System.Drawing.Point(19, 354);
            this.QualityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QualityLbl.Name = "QualityLbl";
            this.QualityLbl.Size = new System.Drawing.Size(91, 23);
            this.QualityLbl.TabIndex = 19;
            this.QualityLbl.Text = "Ποιότητα: ";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeLbl.Location = new System.Drawing.Point(19, 388);
            this.TypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(61, 23);
            this.TypeLbl.TabIndex = 20;
            this.TypeLbl.Text = "Είδος: ";
            // 
            // DueDateLbl
            // 
            this.DueDateLbl.AutoSize = true;
            this.DueDateLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DueDateLbl.Location = new System.Drawing.Point(19, 134);
            this.DueDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DueDateLbl.Name = "DueDateLbl";
            this.DueDateLbl.Size = new System.Drawing.Size(165, 23);
            this.DueDateLbl.TabIndex = 21;
            this.DueDateLbl.Text = "Ημερομηνία λήξης: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(16, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 3);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(16, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 3);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(16, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 3);
            this.panel3.TabIndex = 24;
            // 
            // MedicineViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DueDateLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.QualityLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MinQuantityLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ManifaturerLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.MedicineNameLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineViewData";
            this.Text = "Medicine Details";
            this.Load += new System.EventHandler(this.MedicineViewData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label MinQuantityLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label ManifaturerLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label MedicineNameLbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label QualityLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label DueDateLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}