
namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    partial class StorageListView
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
            this.List = new System.Windows.Forms.ListView();
            this.DrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manifaturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrugType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSelections = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ανανέωσηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.storageNavigator1 = new PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList.StorageNavigator();
            this.listSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrugName,
            this.Category,
            this.Manifaturer,
            this.DueDate,
            this.Quantity,
            this.MinQuantity,
            this.Cost,
            this.Price,
            this.Quality,
            this.DrugType});
            this.List.ContextMenuStrip = this.listSelections;
            this.List.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.List.FullRowSelect = true;
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(0, 54);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(1259, 732);
            this.List.TabIndex = 0;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            this.List.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.List_ColumnClick);
            // 
            // DrugName
            // 
            this.DrugName.Text = "Όνομα";
            this.DrugName.Width = 132;
            // 
            // Category
            // 
            this.Category.Text = "Κατηγορία";
            this.Category.Width = 101;
            // 
            // Manifaturer
            // 
            this.Manifaturer.Text = "Εταιρία";
            this.Manifaturer.Width = 124;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Ημερομηνία Λήξης";
            this.DueDate.Width = 174;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Ποσότητα";
            this.Quantity.Width = 104;
            // 
            // MinQuantity
            // 
            this.MinQuantity.Text = "Ελάχιστη Ποσότητα";
            this.MinQuantity.Width = 122;
            // 
            // Cost
            // 
            this.Cost.Text = "Κόστος Αγοράς (€)";
            this.Cost.Width = 146;
            // 
            // Price
            // 
            this.Price.Text = "Τιμή Προϊόντος (€)";
            this.Price.Width = 149;
            // 
            // Quality
            // 
            this.Quality.Text = "Ποιότητα";
            this.Quality.Width = 102;
            // 
            // DrugType
            // 
            this.DrugType.Text = "Είδος";
            this.DrugType.Width = 130;
            // 
            // listSelections
            // 
            this.listSelections.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listSelections.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listSelections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ανανέωσηToolStripMenuItem,
            this.EditMenu,
            this.RemoveMenu});
            this.listSelections.Name = "listSelections";
            this.listSelections.Size = new System.Drawing.Size(184, 88);
            // 
            // ανανέωσηToolStripMenuItem
            // 
            this.ανανέωσηToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ανανέωσηToolStripMenuItem.Name = "ανανέωσηToolStripMenuItem";
            this.ανανέωσηToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.ανανέωσηToolStripMenuItem.Text = "Ανανέωση";
            this.ανανέωσηToolStripMenuItem.Click += new System.EventHandler(this.ανανέωσηToolStripMenuItem_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Font = new System.Drawing.Font("Calibri", 11F);
            this.EditMenu.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_edit_row_24_1_1;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(183, 28);
            this.EditMenu.Text = "Επεξεργασία";
            this.EditMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // RemoveMenu
            // 
            this.RemoveMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RemoveMenu.Image = global::PharmacyInformationSystem.Properties.Resources.icons8_delete_bin_24;
            this.RemoveMenu.Name = "RemoveMenu";
            this.RemoveMenu.Size = new System.Drawing.Size(183, 28);
            this.RemoveMenu.Text = "Διαγραφή";
            this.RemoveMenu.Click += new System.EventHandler(this.RemoveMenu_Click);
            // 
            // storageNavigator1
            // 
            this.storageNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.storageNavigator1.Location = new System.Drawing.Point(0, 0);
            this.storageNavigator1.Margin = new System.Windows.Forms.Padding(5);
            this.storageNavigator1.Name = "storageNavigator1";
            this.storageNavigator1.Size = new System.Drawing.Size(1259, 55);
            this.storageNavigator1.TabIndex = 1;
            // 
            // StorageListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.storageNavigator1);
            this.Controls.Add(this.List);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorageListView";
            this.Size = new System.Drawing.Size(1259, 786);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StorageListView_Paint);
            this.listSelections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader DrugName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Manifaturer;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader MinQuantity;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quality;
        private System.Windows.Forms.ColumnHeader DrugType;
        //private StorageNavigator storageNavigator1;
        private System.Windows.Forms.ContextMenuStrip listSelections;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenu;
        private StorageNavigator storageNavigator1;
        private System.Windows.Forms.ToolStripMenuItem ανανέωσηToolStripMenuItem;
    }
}
