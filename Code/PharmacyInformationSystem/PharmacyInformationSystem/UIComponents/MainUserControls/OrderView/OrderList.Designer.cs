
namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    partial class OrderList
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
            this.List = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PharmacistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PharmacistLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PharmacistAFM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.OrderView.OrderNavigator();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.PharmacistName,
            this.PharmacistLName,
            this.PharmacistAFM,
            this.OrderDate,
            this.TotalCost});
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.List.FullRowSelect = true;
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(0, 62);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(1259, 719);
            this.List.TabIndex = 1;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Αριθμός Παραγγελίας";
            this.OrderID.Width = 170;
            // 
            // PharmacistName
            // 
            this.PharmacistName.Text = "Όνομα Φαρμακοποιού";
            this.PharmacistName.Width = 160;
            // 
            // PharmacistLName
            // 
            this.PharmacistLName.Text = "Επίθετο Φαρμακοποιού";
            this.PharmacistLName.Width = 170;
            // 
            // PharmacistAFM
            // 
            this.PharmacistAFM.Text = "ΑΦΜ Φαρμακοποιού";
            this.PharmacistAFM.Width = 159;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Ημερομηνία Παραγγελίας";
            this.OrderDate.Width = 196;
            // 
            // TotalCost
            // 
            this.TotalCost.Text = "Τελικό Ποσό";
            this.TotalCost.Width = 112;
            // 
            // orderNavigator1
            // 
            this.orderNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.orderNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderNavigator1.Location = new System.Drawing.Point(0, 0);
            this.orderNavigator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderNavigator1.Name = "orderNavigator1";
            this.orderNavigator1.Size = new System.Drawing.Size(1259, 62);
            this.orderNavigator1.TabIndex = 0;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.List);
            this.Controls.Add(this.orderNavigator1);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(1259, 781);
            this.ResumeLayout(false);

        }

        #endregion

        private OrderNavigator orderNavigator1;
        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader PharmacistName;
        private System.Windows.Forms.ColumnHeader PharmacistLName;
        private System.Windows.Forms.ColumnHeader PharmacistAFM;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader TotalCost;
    }
}
