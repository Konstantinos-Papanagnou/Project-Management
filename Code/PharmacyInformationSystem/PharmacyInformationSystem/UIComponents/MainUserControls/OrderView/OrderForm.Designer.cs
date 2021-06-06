
namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.PharmacistCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderDateLbl = new System.Windows.Forms.Label();
            this.SellerLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FinalPriceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ManuBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.DrugCombo = new System.Windows.Forms.ComboBox();
            this.QuantityBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListView();
            this.DrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinalQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Calibri", 14F);
            this.SaveBtn.Location = new System.Drawing.Point(1157, 562);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(184, 52);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Αποθήκευση";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrderIdLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.OrderIdLbl.Location = new System.Drawing.Point(13, 9);
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
            this.LogoPanel.Controls.Add(this.PharmacistCombo);
            this.LogoPanel.Controls.Add(this.label2);
            this.LogoPanel.Controls.Add(this.OrderDateLbl);
            this.LogoPanel.Controls.Add(this.OrderIdLbl);
            this.LogoPanel.Location = new System.Drawing.Point(28, 82);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(546, 108);
            this.LogoPanel.TabIndex = 108;
            // 
            // PharmacistCombo
            // 
            this.PharmacistCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PharmacistCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PharmacistCombo.FormattingEnabled = true;
            this.PharmacistCombo.Location = new System.Drawing.Point(252, 73);
            this.PharmacistCombo.Name = "PharmacistCombo";
            this.PharmacistCombo.Size = new System.Drawing.Size(218, 24);
            this.PharmacistCombo.TabIndex = 1;
            this.PharmacistCombo.SelectedIndexChanged += new System.EventHandler(this.PharmacistCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "ΑΦΜ ΦΑΡΜΑΚΟΠΟΙΟΥ: ";
            // 
            // OrderDateLbl
            // 
            this.OrderDateLbl.AutoSize = true;
            this.OrderDateLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrderDateLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.OrderDateLbl.Location = new System.Drawing.Point(13, 39);
            this.OrderDateLbl.Name = "OrderDateLbl";
            this.OrderDateLbl.Size = new System.Drawing.Size(146, 24);
            this.OrderDateLbl.TabIndex = 80;
            this.OrderDateLbl.Text = "ΗΜΕΡΟΜΗΝΙΑ: ";
            // 
            // SellerLbl
            // 
            this.SellerLbl.AutoSize = true;
            this.SellerLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerLbl.Location = new System.Drawing.Point(80, 16);
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
            this.panel3.Location = new System.Drawing.Point(28, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 60);
            this.panel3.TabIndex = 109;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_caduceus_48;
            this.pictureBox3.Location = new System.Drawing.Point(5, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.CausesValidation = false;
            this.panel4.Controls.Add(this.RemoveBtn);
            this.panel4.Controls.Add(this.AddBtn);
            this.panel4.Controls.Add(this.FinalPriceLbl);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.DateBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.PriceBox);
            this.panel4.Controls.Add(this.ManuBox);
            this.panel4.Controls.Add(this.CategoryBox);
            this.panel4.Controls.Add(this.DrugCombo);
            this.panel4.Controls.Add(this.QuantityBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(28, 208);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 341);
            this.panel4.TabIndex = 110;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RemoveBtn.Location = new System.Drawing.Point(366, 262);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(65, 51);
            this.RemoveBtn.TabIndex = 121;
            this.RemoveBtn.Text = "-";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Visible = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddBtn.Location = new System.Drawing.Point(453, 262);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(65, 51);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FinalPriceLbl
            // 
            this.FinalPriceLbl.AutoSize = true;
            this.FinalPriceLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FinalPriceLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.FinalPriceLbl.Location = new System.Drawing.Point(16, 279);
            this.FinalPriceLbl.Name = "FinalPriceLbl";
            this.FinalPriceLbl.Size = new System.Drawing.Size(120, 24);
            this.FinalPriceLbl.TabIndex = 120;
            this.FinalPriceLbl.Text = "Τελική Τιμή: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(16, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 119;
            this.label6.Text = "Ημ. Λήξης: ";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(134, 206);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(218, 22);
            this.DateBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 117;
            this.label5.Text = "Τιμή: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 116;
            this.label4.Text = "Εταιρία: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 115;
            this.label3.Text = "Κατηγορία: ";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(134, 167);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(218, 22);
            this.PriceBox.TabIndex = 5;
            // 
            // ManuBox
            // 
            this.ManuBox.Location = new System.Drawing.Point(134, 127);
            this.ManuBox.Name = "ManuBox";
            this.ManuBox.ReadOnly = true;
            this.ManuBox.Size = new System.Drawing.Size(218, 22);
            this.ManuBox.TabIndex = 4;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Location = new System.Drawing.Point(134, 86);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.ReadOnly = true;
            this.CategoryBox.Size = new System.Drawing.Size(218, 22);
            this.CategoryBox.TabIndex = 3;
            // 
            // DrugCombo
            // 
            this.DrugCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrugCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrugCombo.FormattingEnabled = true;
            this.DrugCombo.Location = new System.Drawing.Point(134, 44);
            this.DrugCombo.Name = "DrugCombo";
            this.DrugCombo.Size = new System.Drawing.Size(218, 24);
            this.DrugCombo.TabIndex = 2;
            this.DrugCombo.SelectedIndexChanged += new System.EventHandler(this.DrugCombo_SelectedIndexChanged);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(134, 242);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantityBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(98, 22);
            this.QuantityBox.TabIndex = 7;
            this.QuantityBox.ValueChanged += new System.EventHandler(this.QuantityBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(16, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Ποσότητα: ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label25.ForeColor = System.Drawing.Color.FloralWhite;
            this.label25.Location = new System.Drawing.Point(16, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 24);
            this.label25.TabIndex = 82;
            this.label25.Text = "Προιόν: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label26.ForeColor = System.Drawing.Color.FloralWhite;
            this.label26.Location = new System.Drawing.Point(16, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 24);
            this.label26.TabIndex = 81;
            this.label26.Text = "ΠΑΡΑΓΓΕΛΙΑ";
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
            this.List.Location = new System.Drawing.Point(587, 17);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(754, 532);
            this.List.TabIndex = 111;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            this.List.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.List_ItemSelectionChanged);
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1354, 625);
            this.Controls.Add(this.List);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Παραγγελία";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label SellerLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label OrderDateLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QuantityBox;
        private System.Windows.Forms.ComboBox PharmacistCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader DrugName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader FinalQuantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ComboBox DrugCombo;
        private System.Windows.Forms.Label FinalPriceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ManuBox;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}