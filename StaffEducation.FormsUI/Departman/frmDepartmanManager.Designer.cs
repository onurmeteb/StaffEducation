namespace StaffEducation.FormsUI.Departman
{
    partial class frmDepartmanManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanManager));
            this.gridControl_Departman = new DevExpress.XtraGrid.GridControl();
            this.gridView_Departmans_RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Departmans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Departman)).BeginInit();
            this.gridView_Departmans_RightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departmans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Departman
            // 
            this.gridControl_Departman.ContextMenuStrip = this.gridView_Departmans_RightClickMenu;
            this.gridControl_Departman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Departman.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Departman.MainView = this.gridView_Departmans;
            this.gridControl_Departman.Name = "gridControl_Departman";
            this.gridControl_Departman.Size = new System.Drawing.Size(856, 536);
            this.gridControl_Departman.TabIndex = 0;
            this.gridControl_Departman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Departmans});
            this.gridControl_Departman.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView_Departmans_RightClickMenu
            // 
            this.gridView_Departmans_RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.toolStripSeparator1,
            this.silToolStripMenuItem});
            this.gridView_Departmans_RightClickMenu.Name = "gridView_Departmans_RightClickMenu";
            this.gridView_Departmans_RightClickMenu.Size = new System.Drawing.Size(117, 98);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // gridView_Departmans
            // 
            this.gridView_Departmans.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView_Departmans.GridControl = this.gridControl_Departman;
            this.gridView_Departmans.Name = "gridView_Departmans";
            this.gridView_Departmans.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_Departmans.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView_Departmans.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_Departmans_RowUpdated);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Departman No";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 133;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Departman Adı";
            this.gridColumn2.FieldName = "DepartmanName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 698;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // frmDepartmanManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.gridControl_Departman);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDepartmanManager.IconOptions.LargeImage")));
            this.Name = "frmDepartmanManager";
            this.Text = "Departman Yönetim";
            this.Load += new System.EventHandler(this.frmDepartmanManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Departman)).EndInit();
            this.gridView_Departmans_RightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departmans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Departman;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Departmans;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip gridView_Departmans_RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    }
}