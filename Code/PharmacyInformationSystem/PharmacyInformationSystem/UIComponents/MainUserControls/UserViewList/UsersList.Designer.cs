
namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    partial class UsersList
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
            this.listNavigator1 = new PharmacyInformationSystem.UIComponents.ListNavigator();
            this.List = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listNavigator1
            // 
            this.listNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.listNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listNavigator1.Location = new System.Drawing.Point(0, 0);
            this.listNavigator1.Name = "listNavigator1";
            this.listNavigator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listNavigator1.Size = new System.Drawing.Size(909, 93);
            this.listNavigator1.TabIndex = 0;
            // 
            // List
            // 
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.Location = new System.Drawing.Point(0, 93);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(909, 517);
            this.List.TabIndex = 1;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.List);
            this.Controls.Add(this.listNavigator1);
            this.Name = "UsersList";
            this.Size = new System.Drawing.Size(909, 610);
            this.ResumeLayout(false);

        }

        #endregion

        private ListNavigator listNavigator1;
        private System.Windows.Forms.Panel List;
    }
}
