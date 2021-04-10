
namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    partial class ViewUserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserData));
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.IDCardLbl = new System.Windows.Forms.Label();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PhoneNumbers = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLbl.Location = new System.Drawing.Point(21, 156);
            this.FirstNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(73, 23);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "Όνομα: ";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastNameLbl.Location = new System.Drawing.Point(298, 156);
            this.LastNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(80, 23);
            this.LastNameLbl.TabIndex = 1;
            this.LastNameLbl.Text = "Επίθετο: ";
            // 
            // IDCardLbl
            // 
            this.IDCardLbl.AutoSize = true;
            this.IDCardLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCardLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDCardLbl.Location = new System.Drawing.Point(43, 214);
            this.IDCardLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDCardLbl.Name = "IDCardLbl";
            this.IDCardLbl.Size = new System.Drawing.Size(179, 23);
            this.IDCardLbl.TabIndex = 2;
            this.IDCardLbl.Text = "Αριθμός Ταυτότητας: ";
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleLbl.Location = new System.Drawing.Point(328, 255);
            this.RoleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(66, 23);
            this.RoleLbl.TabIndex = 3;
            this.RoleLbl.Text = "Ρόλος: ";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLbl.Location = new System.Drawing.Point(162, 298);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(100, 23);
            this.UsernameLbl.TabIndex = 4;
            this.UsernameLbl.Text = "Username: ";
            // 
            // PhoneNumbers
            // 
            this.PhoneNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.PhoneNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumbers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PhoneNumbers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhoneNumbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneNumbers.HideSelection = false;
            this.PhoneNumbers.Location = new System.Drawing.Point(11, 335);
            this.PhoneNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumbers.Name = "PhoneNumbers";
            this.PhoneNumbers.ReadOnly = true;
            this.PhoneNumbers.Size = new System.Drawing.Size(319, 121);
            this.PhoneNumbers.TabIndex = 6;
            this.PhoneNumbers.Text = "Τηλέφωνα:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(466, 418);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(117, 38);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "OK";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PharmacyInformationSystem.Properties.Resources.users1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(218, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ViewUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(592, 460);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PhoneNumbers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.IDCardLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewUserData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Information";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label IDCardLbl;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox PhoneNumbers;
        private System.Windows.Forms.Button ExitBtn;
    }
}