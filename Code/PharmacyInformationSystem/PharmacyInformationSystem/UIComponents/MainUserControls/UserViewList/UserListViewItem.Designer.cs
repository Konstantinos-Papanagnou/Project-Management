
namespace PharmacyInformationSystem.UIComponents.MainUserControls.UserViewList
{
    partial class UserListViewItem
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
            this.SumInfoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExpandablePanel = new System.Windows.Forms.Panel();
            this.PhoneNumbersLbl = new System.Windows.Forms.Label();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.IdCardLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpandablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SumInfoLbl
            // 
            this.SumInfoLbl.AutoSize = true;
            this.SumInfoLbl.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SumInfoLbl.Location = new System.Drawing.Point(16, 19);
            this.SumInfoLbl.Name = "SumInfoLbl";
            this.SumInfoLbl.Size = new System.Drawing.Size(75, 34);
            this.SumInfoLbl.TabIndex = 0;
            this.SumInfoLbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(5, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 2);
            this.panel2.TabIndex = 2;
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.BackgroundImage = global::PharmacyInformationSystem.Properties.Resources.add;
            this.ExpandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExpandBtn.FlatAppearance.BorderSize = 0;
            this.ExpandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandBtn.Location = new System.Drawing.Point(754, 15);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(49, 44);
            this.ExpandBtn.TabIndex = 3;
            this.ExpandBtn.UseVisualStyleBackColor = true;
            this.ExpandBtn.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.FlatAppearance.BorderSize = 0;
            this.ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ModifyBtn.Location = new System.Drawing.Point(809, 17);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(167, 36);
            this.ModifyBtn.TabIndex = 4;
            this.ModifyBtn.Text = "Επεξεργασία";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(992, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 50);
            this.panel3.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteBtn.Location = new System.Drawing.Point(1012, 17);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(178, 36);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Διαγραφή";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExpandablePanel
            // 
            this.ExpandablePanel.Controls.Add(this.PhoneNumbersLbl);
            this.ExpandablePanel.Controls.Add(this.RoleLbl);
            this.ExpandablePanel.Controls.Add(this.UsernameLbl);
            this.ExpandablePanel.Controls.Add(this.IdCardLbl);
            this.ExpandablePanel.Controls.Add(this.LastNameLbl);
            this.ExpandablePanel.Controls.Add(this.NameLbl);
            this.ExpandablePanel.Controls.Add(this.label6);
            this.ExpandablePanel.Controls.Add(this.label5);
            this.ExpandablePanel.Controls.Add(this.label4);
            this.ExpandablePanel.Controls.Add(this.label3);
            this.ExpandablePanel.Controls.Add(this.label2);
            this.ExpandablePanel.Controls.Add(this.label1);
            this.ExpandablePanel.Location = new System.Drawing.Point(69, 69);
            this.ExpandablePanel.Name = "ExpandablePanel";
            this.ExpandablePanel.Size = new System.Drawing.Size(837, 247);
            this.ExpandablePanel.TabIndex = 7;
            // 
            // PhoneNumbersLbl
            // 
            this.PhoneNumbersLbl.AutoSize = true;
            this.PhoneNumbersLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhoneNumbersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.PhoneNumbersLbl.Location = new System.Drawing.Point(261, 206);
            this.PhoneNumbersLbl.Name = "PhoneNumbersLbl";
            this.PhoneNumbersLbl.Size = new System.Drawing.Size(0, 28);
            this.PhoneNumbersLbl.TabIndex = 19;
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RoleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.RoleLbl.Location = new System.Drawing.Point(259, 166);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(110, 28);
            this.RoleLbl.TabIndex = 18;
            this.RoleLbl.Text = "Τεστ Ρόλος";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.UsernameLbl.Location = new System.Drawing.Point(259, 129);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(186, 28);
            this.UsernameLbl.TabIndex = 17;
            this.UsernameLbl.Text = "Τεστ Όνομα Χρήστη";
            // 
            // IdCardLbl
            // 
            this.IdCardLbl.AutoSize = true;
            this.IdCardLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IdCardLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.IdCardLbl.Location = new System.Drawing.Point(259, 91);
            this.IdCardLbl.Name = "IdCardLbl";
            this.IdCardLbl.Size = new System.Drawing.Size(118, 28);
            this.IdCardLbl.TabIndex = 16;
            this.IdCardLbl.Text = "ΑΜ 520562";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.LastNameLbl.Location = new System.Drawing.Point(259, 51);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(128, 28);
            this.LastNameLbl.TabIndex = 15;
            this.LastNameLbl.Text = "Τεστ Επίθετο";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.NameLbl.Location = new System.Drawing.Point(259, 13);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(115, 28);
            this.NameLbl.TabIndex = 14;
            this.NameLbl.Text = "Τεστ Όνομα";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(15, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Τηλέφωνα Επικοινωνίας:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ρόλος:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Όνομα Χρήστη:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Αριθμός Ταυτότητας:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Επίθετο:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Όνομα:";
            // 
            // UserListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.ExpandablePanel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.ExpandBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SumInfoLbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "UserListViewItem";
            this.Size = new System.Drawing.Size(1214, 69);
            this.ExpandablePanel.ResumeLayout(false);
            this.ExpandablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SumInfoLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExpandBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel ExpandablePanel;
        private System.Windows.Forms.Label PhoneNumbersLbl;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label IdCardLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
