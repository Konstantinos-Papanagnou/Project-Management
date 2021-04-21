
namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    partial class StrorageList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.storageNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList.StorageNavigator();
            this.storageListView1 = new PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList.StorageListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.storageNavigator1);
            this.flowLayoutPanel1.Controls.Add(this.storageListView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 639);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // storageNavigator1
            // 
            this.storageNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.storageNavigator1.Location = new System.Drawing.Point(3, 3);
            this.storageNavigator1.Name = "storageNavigator1";
            this.storageNavigator1.Size = new System.Drawing.Size(944, 45);
            this.storageNavigator1.TabIndex = 0;
            // 
            // storageListView1
            // 
            this.storageListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.storageListView1.Location = new System.Drawing.Point(3, 54);
            this.storageListView1.Name = "storageListView1";
            this.storageListView1.Size = new System.Drawing.Size(944, 639);
            this.storageListView1.TabIndex = 1;
            // 
            // StrorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StrorageList";
            this.Size = new System.Drawing.Size(944, 639);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private StorageNavigator storageNavigator1;
        private StorageListView storageListView1;
    }
}
