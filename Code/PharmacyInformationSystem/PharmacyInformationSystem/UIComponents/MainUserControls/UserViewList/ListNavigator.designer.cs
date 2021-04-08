
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
            this.ListAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.ListSearchBox.Location = new System.Drawing.Point(704, 7);
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
            this.splitContainer1.Panel1.Controls.Add(this.ListSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.Label1);
            this.splitContainer1.Panel1.Controls.Add(this.ListAddBtn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.splitContainer1.Panel2.Controls.Add(this.ListLbl);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1259, 93);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.Label1.Location = new System.Drawing.Point(469, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Αναζήτηση Χρήστη:";
            // 
            // ListAddBtn
            // 
            this.ListAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.ListAddBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListAddBtn.FlatAppearance.BorderSize = 0;
            this.ListAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAddBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.ListAddBtn.Location = new System.Drawing.Point(988, 0);
            this.ListAddBtn.Name = "ListAddBtn";
            this.ListAddBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ListAddBtn.Size = new System.Drawing.Size(271, 45);
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
            this.Size = new System.Drawing.Size(1259, 93);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListLbl;
        private System.Windows.Forms.TextBox ListSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox SearchBocIcon;
        private System.Windows.Forms.Button ListAddBtn;
        private System.Windows.Forms.Label Label1;
    }
}
