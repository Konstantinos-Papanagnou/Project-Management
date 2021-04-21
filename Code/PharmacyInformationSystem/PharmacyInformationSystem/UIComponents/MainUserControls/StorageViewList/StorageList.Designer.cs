﻿
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.storageNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList.StorageNavigator();
            this.storageTableView1 = new PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList.StorageTableView();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.storageNavigator1);
            this.flowLayoutPanel1.Controls.Add(this.storageTableView1);
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
            this.storageNavigator1.Size = new System.Drawing.Size(951, 45);
            this.storageNavigator1.TabIndex = 0;
            // 
            // storageTableView1
            // 
            this.storageTableView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.storageTableView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageTableView1.ForeColor = System.Drawing.Color.FloralWhite;
            this.storageTableView1.Location = new System.Drawing.Point(4, 55);
            this.storageTableView1.Margin = new System.Windows.Forms.Padding(4);
            this.storageTableView1.Name = "storageTableView1";
            this.storageTableView1.Size = new System.Drawing.Size(936, 611);
            this.storageTableView1.TabIndex = 1;
            // 
            // StorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StorageList";
            this.Size = new System.Drawing.Size(944, 639);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private StorageNavigator storageNavigator1;
        private StorageTableView storageTableView1;
    }
}
