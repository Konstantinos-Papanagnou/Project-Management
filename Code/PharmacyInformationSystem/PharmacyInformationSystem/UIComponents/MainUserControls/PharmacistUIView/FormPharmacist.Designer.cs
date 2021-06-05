
namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    partial class FormPharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPharmacist));
            this.AFMError = new System.Windows.Forms.Panel();
            this.LastNameError = new System.Windows.Forms.Panel();
            this.FirstNameError = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AFMBox = new System.Windows.Forms.TextBox();
            this.AFMLbl = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetError = new System.Windows.Forms.Panel();
            this.PhoneError = new System.Windows.Forms.Panel();
            this.TownError = new System.Windows.Forms.Panel();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.TownBox = new System.Windows.Forms.TextBox();
            this.TownLbl = new System.Windows.Forms.Label();
            this.NumberError = new System.Windows.Forms.Panel();
            this.PostalCodeError = new System.Windows.Forms.Panel();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.PostalCodeBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AFMError
            // 
            this.AFMError.BackColor = System.Drawing.Color.Red;
            this.AFMError.Location = new System.Drawing.Point(95, 202);
            this.AFMError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AFMError.Name = "AFMError";
            this.AFMError.Size = new System.Drawing.Size(285, 4);
            this.AFMError.TabIndex = 52;
            this.AFMError.Visible = false;
            // 
            // LastNameError
            // 
            this.LastNameError.BackColor = System.Drawing.Color.Red;
            this.LastNameError.Location = new System.Drawing.Point(432, 126);
            this.LastNameError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameError.Name = "LastNameError";
            this.LastNameError.Size = new System.Drawing.Size(285, 4);
            this.LastNameError.TabIndex = 53;
            this.LastNameError.Visible = false;
            // 
            // FirstNameError
            // 
            this.FirstNameError.BackColor = System.Drawing.Color.Red;
            this.FirstNameError.Location = new System.Drawing.Point(92, 124);
            this.FirstNameError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameError.Name = "FirstNameError";
            this.FirstNameError.Size = new System.Drawing.Size(285, 4);
            this.FirstNameError.TabIndex = 51;
            this.FirstNameError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "Στοιχεία φαρμακοποιού";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 14F);
            this.AddBtn.Location = new System.Drawing.Point(773, 476);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(184, 52);
            this.AddBtn.TabIndex = 44;
            this.AddBtn.Text = "Αποθήκευση";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AFMBox
            // 
            this.AFMBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AFMBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AFMBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.AFMBox.Location = new System.Drawing.Point(92, 174);
            this.AFMBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AFMBox.Name = "AFMBox";
            this.AFMBox.Size = new System.Drawing.Size(285, 30);
            this.AFMBox.TabIndex = 3;
            this.AFMBox.Tag = "AFM";
            // 
            // AFMLbl
            // 
            this.AFMLbl.AutoSize = true;
            this.AFMLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.AFMLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.AFMLbl.Location = new System.Drawing.Point(92, 148);
            this.AFMLbl.Name = "AFMLbl";
            this.AFMLbl.Size = new System.Drawing.Size(69, 24);
            this.AFMLbl.TabIndex = 47;
            this.AFMLbl.Text = "Α.Φ.Μ.";
            // 
            // LastNameBox
            // 
            this.LastNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LastNameBox.Location = new System.Drawing.Point(433, 96);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(285, 30);
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.Tag = "lastname";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.LastNameLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.LastNameLbl.Location = new System.Drawing.Point(433, 69);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(75, 24);
            this.LastNameLbl.TabIndex = 46;
            this.LastNameLbl.Text = "Επίθετο";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.FirstNameBox.Location = new System.Drawing.Point(93, 96);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(285, 30);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.Tag = "firstname";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.NameLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.NameLbl.Location = new System.Drawing.Point(93, 69);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(65, 24);
            this.NameLbl.TabIndex = 45;
            this.NameLbl.Text = "Όνομα";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(89, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 54;
            this.label2.Text = "Διεύθυνση";
            // 
            // StreetError
            // 
            this.StreetError.BackColor = System.Drawing.Color.Red;
            this.StreetError.Location = new System.Drawing.Point(100, 415);
            this.StreetError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetError.Name = "StreetError";
            this.StreetError.Size = new System.Drawing.Size(285, 4);
            this.StreetError.TabIndex = 65;
            this.StreetError.Visible = false;
            // 
            // PhoneError
            // 
            this.PhoneError.BackColor = System.Drawing.Color.Red;
            this.PhoneError.Location = new System.Drawing.Point(431, 203);
            this.PhoneError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneError.Name = "PhoneError";
            this.PhoneError.Size = new System.Drawing.Size(285, 4);
            this.PhoneError.TabIndex = 66;
            this.PhoneError.Visible = false;
            // 
            // TownError
            // 
            this.TownError.BackColor = System.Drawing.Color.Red;
            this.TownError.Location = new System.Drawing.Point(97, 337);
            this.TownError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TownError.Name = "TownError";
            this.TownError.Size = new System.Drawing.Size(285, 4);
            this.TownError.TabIndex = 64;
            this.TownError.Visible = false;
            // 
            // StreetBox
            // 
            this.StreetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.StreetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StreetBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.StreetBox.Location = new System.Drawing.Point(97, 386);
            this.StreetBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(285, 30);
            this.StreetBox.TabIndex = 7;
            this.StreetBox.Tag = "street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(97, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 63;
            this.label4.Text = "Οδός";
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.PhoneBox.Location = new System.Drawing.Point(432, 174);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(285, 30);
            this.PhoneBox.TabIndex = 4;
            this.PhoneBox.Tag = "phone";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.PhoneLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.PhoneLbl.Location = new System.Drawing.Point(432, 146);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(96, 24);
            this.PhoneLbl.TabIndex = 62;
            this.PhoneLbl.Tag = "";
            this.PhoneLbl.Text = "Τηλέφωνο";
            // 
            // TownBox
            // 
            this.TownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TownBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TownBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.TownBox.Location = new System.Drawing.Point(99, 309);
            this.TownBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TownBox.Name = "TownBox";
            this.TownBox.Size = new System.Drawing.Size(285, 30);
            this.TownBox.TabIndex = 5;
            this.TownBox.Tag = "patown";
            // 
            // TownLbl
            // 
            this.TownLbl.AutoSize = true;
            this.TownLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.TownLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.TownLbl.Location = new System.Drawing.Point(99, 282);
            this.TownLbl.Name = "TownLbl";
            this.TownLbl.Size = new System.Drawing.Size(53, 24);
            this.TownLbl.TabIndex = 61;
            this.TownLbl.Text = "Πόλη";
            // 
            // NumberError
            // 
            this.NumberError.BackColor = System.Drawing.Color.Red;
            this.NumberError.Location = new System.Drawing.Point(433, 415);
            this.NumberError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberError.Name = "NumberError";
            this.NumberError.Size = new System.Drawing.Size(285, 4);
            this.NumberError.TabIndex = 72;
            this.NumberError.Visible = false;
            // 
            // PostalCodeError
            // 
            this.PostalCodeError.BackColor = System.Drawing.Color.Red;
            this.PostalCodeError.Location = new System.Drawing.Point(431, 337);
            this.PostalCodeError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostalCodeError.Name = "PostalCodeError";
            this.PostalCodeError.Size = new System.Drawing.Size(285, 4);
            this.PostalCodeError.TabIndex = 71;
            this.PostalCodeError.Visible = false;
            // 
            // NumberBox
            // 
            this.NumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.NumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.NumberBox.Location = new System.Drawing.Point(431, 386);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(285, 30);
            this.NumberBox.TabIndex = 8;
            this.NumberBox.Tag = "number";
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.NumberLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.NumberLbl.Location = new System.Drawing.Point(431, 361);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(78, 24);
            this.NumberLbl.TabIndex = 70;
            this.NumberLbl.Text = "Αριθμός";
            // 
            // PostalCodeBox
            // 
            this.PostalCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PostalCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostalCodeBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.PostalCodeBox.Location = new System.Drawing.Point(432, 309);
            this.PostalCodeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostalCodeBox.Name = "PostalCodeBox";
            this.PostalCodeBox.Size = new System.Drawing.Size(285, 30);
            this.PostalCodeBox.TabIndex = 6;
            this.PostalCodeBox.Tag = "postalcode";
            // 
            // PostalCodeLbl
            // 
            this.PostalCodeLbl.AutoSize = true;
            this.PostalCodeLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.PostalCodeLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.PostalCodeLbl.Location = new System.Drawing.Point(432, 282);
            this.PostalCodeLbl.Name = "PostalCodeLbl";
            this.PostalCodeLbl.Size = new System.Drawing.Size(38, 24);
            this.PostalCodeLbl.TabIndex = 69;
            this.PostalCodeLbl.Text = "Τ.Κ.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_address_26;
            this.pictureBox1.Location = new System.Drawing.Point(53, 238);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_person_26;
            this.pictureBox4.Location = new System.Drawing.Point(53, 21);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 34);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // FormPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(985, 555);
            this.Controls.Add(this.NumberError);
            this.Controls.Add(this.PostalCodeError);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.PostalCodeBox);
            this.Controls.Add(this.PostalCodeLbl);
            this.Controls.Add(this.StreetError);
            this.Controls.Add(this.PhoneError);
            this.Controls.Add(this.TownError);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.TownBox);
            this.Controls.Add(this.TownLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AFMError);
            this.Controls.Add(this.LastNameError);
            this.Controls.Add(this.FirstNameError);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AFMBox);
            this.Controls.Add(this.AFMLbl);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPharmacist";
            this.Text = "FormPharmacist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AFMError;
        private System.Windows.Forms.Panel LastNameError;
        private System.Windows.Forms.Panel FirstNameError;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox AFMBox;
        private System.Windows.Forms.Label AFMLbl;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StreetError;
        private System.Windows.Forms.Panel PhoneError;
        private System.Windows.Forms.Panel TownError;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.TextBox TownBox;
        private System.Windows.Forms.Label TownLbl;
        private System.Windows.Forms.Panel NumberError;
        private System.Windows.Forms.Panel PostalCodeError;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.TextBox PostalCodeBox;
        private System.Windows.Forms.Label PostalCodeLbl;
    }
}