
namespace PharmacyInformationSystem.UIComponents
{
    partial class ListNavigator
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
            this.ListLbl = new System.Windows.Forms.Label();
            this.ListSearchBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBoxIcon = new System.Windows.Forms.PictureBox();
            this.ListAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ListLbl
            // 
            this.ListLbl.AutoSize = true;
            this.ListLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLbl.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.ListLbl.Location = new System.Drawing.Point(0, 0);
            this.ListLbl.Name = "ListLbl";
            this.ListLbl.Size = new System.Drawing.Size(99, 29);
            this.ListLbl.TabIndex = 2;
            this.ListLbl.Text = "Χρήστες:";
            this.ListLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ListSearchBox
            // 
            this.ListSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ListSearchBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ListSearchBox.Location = new System.Drawing.Point(0, 7);
            this.ListSearchBox.Name = "ListSearchBox";
            this.ListSearchBox.Size = new System.Drawing.Size(260, 32);
            this.ListSearchBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel1.Controls.Add(this.Label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.ListAddBtn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.ListLbl);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(911, 93);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.Label1.Location = new System.Drawing.Point(165, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Αναζήτηση Χρήστη:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListSearchBox);
            this.panel1.Controls.Add(this.SearchBoxIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.panel1.Size = new System.Drawing.Size(281, 44);
            this.panel1.TabIndex = 3;
            // 
            // SearchBoxIcon
            // 
            this.SearchBoxIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBoxIcon.Location = new System.Drawing.Point(223, 0);
            this.SearchBoxIcon.Name = "SearchBoxIcon";
            this.SearchBoxIcon.Size = new System.Drawing.Size(37, 44);
            this.SearchBoxIcon.TabIndex = 2;
            this.SearchBoxIcon.TabStop = false;
            // 
            // ListAddBtn
            // 
            this.ListAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.ListAddBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListAddBtn.FlatAppearance.BorderSize = 0;
            this.ListAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAddBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.ListAddBtn.Location = new System.Drawing.Point(640, 0);
            this.ListAddBtn.Name = "ListAddBtn";
            this.ListAddBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ListAddBtn.Size = new System.Drawing.Size(271, 44);
            this.ListAddBtn.TabIndex = 1;
            this.ListAddBtn.Text = "Προσθήκη νέου χρήστη";
            this.ListAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ListAddBtn.UseVisualStyleBackColor = false;
            // 
            // ListNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListNavigator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(911, 93);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListLbl;
        private System.Windows.Forms.TextBox ListSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox SearchBocIcon;
        private System.Windows.Forms.Button ListAddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SearchBoxIcon;
        private System.Windows.Forms.Label Label1;
    }
}
