
namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    partial class StorageTableView
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
            this.components = new System.ComponentModel.Container();
            this.StorageListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExperetionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarketCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.επεξεργασίαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εξαγωγήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StorageListView
            // 
            this.StorageListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.StorageListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Category,
            this.Company,
            this.Quantity,
            this.MinQuantity,
            this.ExperetionDate,
            this.MarketCost,
            this.ProductPrice,
            this.Quality});
            this.StorageListView.ContextMenuStrip = this.contextMenuStrip1;
            this.StorageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageListView.ForeColor = System.Drawing.Color.FloralWhite;
            this.StorageListView.FullRowSelect = true;
            this.StorageListView.HideSelection = false;
            this.StorageListView.Location = new System.Drawing.Point(0, 0);
            this.StorageListView.Margin = new System.Windows.Forms.Padding(4);
            this.StorageListView.Name = "StorageListView";
            this.StorageListView.Size = new System.Drawing.Size(1000, 600);
            this.StorageListView.TabIndex = 0;
            this.StorageListView.UseCompatibleStateImageBehavior = false;
            this.StorageListView.View = System.Windows.Forms.View.Details;
            this.StorageListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Όνομα";
            this.Name.Width = 150;
            // 
            // Category
            // 
            this.Category.Text = "Κατηγορία";
            this.Category.Width = 150;
            // 
            // Company
            // 
            this.Company.Text = "Εταιρία";
            this.Company.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Ποσότητα";
            this.Quantity.Width = 90;
            // 
            // MinQuantity
            // 
            this.MinQuantity.Text = "Ελάχιστο Όριο Αποθέματος";
            this.MinQuantity.Width = 112;
            // 
            // ExperetionDate
            // 
            this.ExperetionDate.Text = "Ημερομηνία Λήξης";
            this.ExperetionDate.Width = 97;
            // 
            // MarketCost
            // 
            this.MarketCost.Text = "Κόστος Αγοράς (€)";
            this.MarketCost.Width = 80;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Τιμής Πώλησης (€)";
            this.ProductPrice.Width = 83;
            // 
            // Quality
            // 
            this.Quality.Text = "Ποιότητα";
            this.Quality.Width = 76;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.επεξεργασίαToolStripMenuItem,
            this.εξαγωγήToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 52);
            // 
            // επεξεργασίαToolStripMenuItem
            // 
            this.επεξεργασίαToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.επεξεργασίαToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.επεξεργασίαToolStripMenuItem.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_edit_row_24_1_;
            this.επεξεργασίαToolStripMenuItem.Name = "επεξεργασίαToolStripMenuItem";
            this.επεξεργασίαToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.επεξεργασίαToolStripMenuItem.Text = "Επεξεργασία";
            this.επεξεργασίαToolStripMenuItem.Click += new System.EventHandler(this.επεξεργασίαToolStripMenuItem_Click);
            // 
            // εξαγωγήToolStripMenuItem
            // 
            this.εξαγωγήToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.εξαγωγήToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.εξαγωγήToolStripMenuItem.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_export_pdf_24;
            this.εξαγωγήToolStripMenuItem.Name = "εξαγωγήToolStripMenuItem";
            this.εξαγωγήToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.εξαγωγήToolStripMenuItem.Text = "Εξαγωγή";
            this.εξαγωγήToolStripMenuItem.Click += new System.EventHandler(this.εξαγωγήToolStripMenuItem_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 583);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1000, 17);
            this.hScrollBar1.TabIndex = 1;
            // 
            // StorageTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.StorageListView);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorageTableView";
            this.Size = new System.Drawing.Size(1000, 600);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StorageListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Company;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader MinQuantity;
        private System.Windows.Forms.ColumnHeader ExperetionDate;
        private System.Windows.Forms.ColumnHeader MarketCost;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader Quality;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem επεξεργασίαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εξαγωγήToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}
