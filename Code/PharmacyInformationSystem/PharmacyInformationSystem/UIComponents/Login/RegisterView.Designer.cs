
namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            this.NameBox = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.FirstNameError = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameError = new System.Windows.Forms.Panel();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdCardError = new System.Windows.Forms.Panel();
            this.IdCardBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Panel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneNumberError = new System.Windows.Forms.Panel();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ViewPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.VerifyPasswordError = new System.Windows.Forms.Panel();
            this.VerifyPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.NameBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.NameBox.Location = new System.Drawing.Point(81, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(65, 24);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Όνομα";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.FirstNameBox.Location = new System.Drawing.Point(81, 49);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(285, 30);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.Tag = "firstname";
            this.FirstNameBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // RoleBox
            // 
            this.RoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.RoleBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Items.AddRange(new object[] {
            "Αποθηκάριος",
            "Πωλητής",
            "Ομάδα Marketing"});
            this.RoleBox.Location = new System.Drawing.Point(81, 474);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(285, 24);
            this.RoleBox.TabIndex = 7;
            // 
            // FirstNameError
            // 
            this.FirstNameError.BackColor = System.Drawing.Color.Red;
            this.FirstNameError.Location = new System.Drawing.Point(81, 73);
            this.FirstNameError.Name = "FirstNameError";
            this.FirstNameError.Size = new System.Drawing.Size(286, 4);
            this.FirstNameError.TabIndex = 3;
            this.FirstNameError.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(83, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 4);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 4);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 4);
            this.panel5.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox5.Location = new System.Drawing.Point(0, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 30);
            this.textBox5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(0, -23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Όνομα";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox4.Location = new System.Drawing.Point(0, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 30);
            this.textBox4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(0, -23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Όνομα";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox3.Location = new System.Drawing.Point(83, 408);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 30);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(83, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Όνομα";
            // 
            // LastNameError
            // 
            this.LastNameError.BackColor = System.Drawing.Color.Red;
            this.LastNameError.Location = new System.Drawing.Point(81, 145);
            this.LastNameError.Name = "LastNameError";
            this.LastNameError.Size = new System.Drawing.Size(286, 4);
            this.LastNameError.TabIndex = 6;
            this.LastNameError.Visible = false;
            // 
            // LastNameBox
            // 
            this.LastNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LastNameBox.Location = new System.Drawing.Point(81, 122);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(285, 30);
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.Tag = "lastname";
            this.LastNameBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(81, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Επώνυμο";
            // 
            // IdCardError
            // 
            this.IdCardError.BackColor = System.Drawing.Color.Red;
            this.IdCardError.Location = new System.Drawing.Point(81, 220);
            this.IdCardError.Name = "IdCardError";
            this.IdCardError.Size = new System.Drawing.Size(286, 4);
            this.IdCardError.TabIndex = 12;
            this.IdCardError.Visible = false;
            // 
            // IdCardBox
            // 
            this.IdCardBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.IdCardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdCardBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.IdCardBox.Location = new System.Drawing.Point(81, 196);
            this.IdCardBox.Name = "IdCardBox";
            this.IdCardBox.Size = new System.Drawing.Size(285, 30);
            this.IdCardBox.TabIndex = 3;
            this.IdCardBox.Tag = "idcard";
            this.IdCardBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(81, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Αριθμός Ταυτότητας";
            // 
            // PasswordError
            // 
            this.PasswordError.BackColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(81, 301);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(286, 4);
            this.PasswordError.TabIndex = 18;
            this.PasswordError.Visible = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.PasswordBox.Location = new System.Drawing.Point(81, 277);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(285, 30);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Tag = "password";
            this.PasswordBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(81, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Κωδικός Πρόσβασης";
            // 
            // PhoneNumberError
            // 
            this.PhoneNumberError.BackColor = System.Drawing.Color.Red;
            this.PhoneNumberError.Location = new System.Drawing.Point(81, 579);
            this.PhoneNumberError.Name = "PhoneNumberError";
            this.PhoneNumberError.Size = new System.Drawing.Size(286, 4);
            this.PhoneNumberError.TabIndex = 24;
            this.PhoneNumberError.Visible = false;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.PhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.PhoneNumberBox.Location = new System.Drawing.Point(81, 555);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(285, 30);
            this.PhoneNumberBox.TabIndex = 8;
            this.PhoneNumberBox.Tag = "phonenumbers";
            this.PhoneNumberBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(81, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Τηλέφωνο";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F);
            this.label10.ForeColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(81, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ρόλος";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Calibri", 12F);
            this.Save.Location = new System.Drawing.Point(229, 614);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(138, 46);
            this.Save.TabIndex = 9;
            this.Save.Text = "Αποθήκευση";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPasswordsCheckBox
            // 
            this.ViewPasswordsCheckBox.AutoSize = true;
            this.ViewPasswordsCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewPasswordsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPasswordsCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic);
            this.ViewPasswordsCheckBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ViewPasswordsCheckBox.Location = new System.Drawing.Point(81, 400);
            this.ViewPasswordsCheckBox.Name = "ViewPasswordsCheckBox";
            this.ViewPasswordsCheckBox.Size = new System.Drawing.Size(269, 25);
            this.ViewPasswordsCheckBox.TabIndex = 6;
            this.ViewPasswordsCheckBox.Text = "Προβολή κρυμμένων χαρακτήρων";
            this.ViewPasswordsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerifyPasswordError
            // 
            this.VerifyPasswordError.BackColor = System.Drawing.Color.Red;
            this.VerifyPasswordError.Location = new System.Drawing.Point(81, 388);
            this.VerifyPasswordError.Name = "VerifyPasswordError";
            this.VerifyPasswordError.Size = new System.Drawing.Size(286, 4);
            this.VerifyPasswordError.TabIndex = 30;
            this.VerifyPasswordError.Visible = false;
            // 
            // VerifyPasswordBox
            // 
            this.VerifyPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.VerifyPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerifyPasswordBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.VerifyPasswordBox.Location = new System.Drawing.Point(81, 364);
            this.VerifyPasswordBox.Name = "VerifyPasswordBox";
            this.VerifyPasswordBox.PasswordChar = '*';
            this.VerifyPasswordBox.Size = new System.Drawing.Size(285, 30);
            this.VerifyPasswordBox.TabIndex = 5;
            this.VerifyPasswordBox.Tag = "verifypassword";
            this.VerifyPasswordBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(79, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Επιβεβαίωση Κωδικού Πρόσβασης";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(439, 677);
            this.Controls.Add(this.VerifyPasswordError);
            this.Controls.Add(this.VerifyPasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewPasswordsCheckBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhoneNumberError);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdCardError);
            this.Controls.Add(this.IdCardBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastNameError);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameError);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Panel FirstNameError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LastNameError;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel IdCardError;
        private System.Windows.Forms.TextBox IdCardBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PasswordError;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PhoneNumberError;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox ViewPasswordsCheckBox;
        private System.Windows.Forms.Panel VerifyPasswordError;
        private System.Windows.Forms.TextBox VerifyPasswordBox;
        private System.Windows.Forms.Label label5;

    }
}