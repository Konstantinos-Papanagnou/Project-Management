
namespace PharmacyInformationSystem.UIComponents
{
    partial class Navigator
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
            this.ConnectedUser = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ConnectedUser
            // 
            this.ConnectedUser.AutoSize = true;
            this.ConnectedUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectedUser.Location = new System.Drawing.Point(17, 32);
            this.ConnectedUser.Name = "ConnectedUser";
            this.ConnectedUser.Size = new System.Drawing.Size(68, 17);
            this.ConnectedUser.TabIndex = 0;
            this.ConnectedUser.Text = "Χρήστης:";
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Location = new System.Drawing.Point(106, 26);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(91, 29);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.MouseEnter += new System.EventHandler(this.Logout_MouseEnter);
            this.Logout.MouseLeave += new System.EventHandler(this.Logout_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 86);
            this.panel1.TabIndex = 2;
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ConnectedUser);
            this.Name = "Navigator";
            this.Size = new System.Drawing.Size(800, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectedUser;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panel1;
    }
}
