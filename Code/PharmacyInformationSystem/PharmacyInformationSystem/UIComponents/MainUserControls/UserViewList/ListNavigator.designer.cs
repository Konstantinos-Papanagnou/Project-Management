
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
            this.ListSearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListAddBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListSearchBox
            // 
            this.ListSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ListSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSearchBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ListSearchBox.Location = new System.Drawing.Point(0, 0);
            this.ListSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListSearchBox.Name = "ListSearchBox";
            this.ListSearchBox.Size = new System.Drawing.Size(221, 27);
            this.ListSearchBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ListSearchBox);
            this.panel1.Location = new System.Drawing.Point(405, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 28);
            this.panel1.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.Label1.Location = new System.Drawing.Point(268, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 19);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Αναζήτηση Χρήστη:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Χρήστες";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.pictureBox1.BackgroundImage = global::PharmacyInformationSystem.Properties.Resources.icons8_search_18;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(193, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ListAddBtn
            // 
            this.ListAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(249)))), ((int)(((byte)(149)))));
            this.ListAddBtn.FlatAppearance.BorderSize = 0;
            this.ListAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAddBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.ListAddBtn.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_plus_24;
            this.ListAddBtn.Location = new System.Drawing.Point(645, 0);
            this.ListAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ListAddBtn.Name = "ListAddBtn";
            this.ListAddBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ListAddBtn.Size = new System.Drawing.Size(209, 44);
            this.ListAddBtn.TabIndex = 1;
            this.ListAddBtn.Text = "Προσθήκη νέου χρήστη";
            this.ListAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ListAddBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_search_client_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ListNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListAddBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListNavigator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(900, 76);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ListSearchBox;
        //private System.Windows.Forms.PictureBox SearchBocIcon;
        private System.Windows.Forms.Button ListAddBtn;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
