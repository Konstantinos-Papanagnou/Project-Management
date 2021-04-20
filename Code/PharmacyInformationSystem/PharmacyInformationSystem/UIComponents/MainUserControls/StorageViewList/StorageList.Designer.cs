
namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    partial class StorageList
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
            this.List = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.Location = new System.Drawing.Point(0, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(944, 639);
            this.List.TabIndex = 0;
            // 
            // StorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.List);
            this.Name = "StorageList";
            this.Size = new System.Drawing.Size(944, 639);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel List;
    }
}
