namespace StaffEducation.FormsUI.Course
{
    partial class frmCourseManager
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
            this.grid_Course = new DevExpress.XtraGrid.GridControl();
            this.gridView_Course_RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridView_Course_RightClickMenu_Yenile = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Course_RightClickMenu_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Course_RightClickMenu_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Course_RightClickMenu_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gridView_Course_RightClickMenu_ExceleAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView_Course = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Course)).BeginInit();
            this.gridView_Course_RightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Course
            // 
            this.grid_Course.ContextMenuStrip = this.gridView_Course_RightClickMenu;
            this.grid_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Course.Location = new System.Drawing.Point(0, 0);
            this.grid_Course.MainView = this.gridView_Course;
            this.grid_Course.Name = "grid_Course";
            this.grid_Course.Size = new System.Drawing.Size(758, 512);
            this.grid_Course.TabIndex = 0;
            this.grid_Course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Course});
            // 
            // gridView_Course_RightClickMenu
            // 
            this.gridView_Course_RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridView_Course_RightClickMenu_Yenile,
            this.gridView_Course_RightClickMenu_Ekle,
            this.gridView_Course_RightClickMenu_Duzenle,
            this.gridView_Course_RightClickMenu_Sil,
            this.toolStripSeparator1,
            this.gridView_Course_RightClickMenu_ExceleAktar});
            this.gridView_Course_RightClickMenu.Name = "gridView_Course_RightClickMenu";
            this.gridView_Course_RightClickMenu.Size = new System.Drawing.Size(142, 120);
            // 
            // gridView_Course_RightClickMenu_Yenile
            // 
            this.gridView_Course_RightClickMenu_Yenile.Name = "gridView_Course_RightClickMenu_Yenile";
            this.gridView_Course_RightClickMenu_Yenile.Size = new System.Drawing.Size(141, 22);
            this.gridView_Course_RightClickMenu_Yenile.Text = "Yenile";
            this.gridView_Course_RightClickMenu_Yenile.Click += new System.EventHandler(this.gridView_Course_RightClickMenu_Yenile_Click);
            // 
            // gridView_Course_RightClickMenu_Ekle
            // 
            this.gridView_Course_RightClickMenu_Ekle.Name = "gridView_Course_RightClickMenu_Ekle";
            this.gridView_Course_RightClickMenu_Ekle.Size = new System.Drawing.Size(141, 22);
            this.gridView_Course_RightClickMenu_Ekle.Text = "Ekle";
            this.gridView_Course_RightClickMenu_Ekle.Click += new System.EventHandler(this.gridView_Course_RightClickMenu_Ekle_Click);
            // 
            // gridView_Course_RightClickMenu_Duzenle
            // 
            this.gridView_Course_RightClickMenu_Duzenle.Name = "gridView_Course_RightClickMenu_Duzenle";
            this.gridView_Course_RightClickMenu_Duzenle.Size = new System.Drawing.Size(141, 22);
            this.gridView_Course_RightClickMenu_Duzenle.Text = "Düzenle";
            this.gridView_Course_RightClickMenu_Duzenle.Click += new System.EventHandler(this.gridView_Course_RightClickMenu_Duzenle_Click);
            // 
            // gridView_Course_RightClickMenu_Sil
            // 
            this.gridView_Course_RightClickMenu_Sil.Name = "gridView_Course_RightClickMenu_Sil";
            this.gridView_Course_RightClickMenu_Sil.Size = new System.Drawing.Size(141, 22);
            this.gridView_Course_RightClickMenu_Sil.Text = "Sil";
            this.gridView_Course_RightClickMenu_Sil.Click += new System.EventHandler(this.gridView_Course_RightClickMenu_Sil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // gridView_Course_RightClickMenu_ExceleAktar
            // 
            this.gridView_Course_RightClickMenu_ExceleAktar.Name = "gridView_Course_RightClickMenu_ExceleAktar";
            this.gridView_Course_RightClickMenu_ExceleAktar.Size = new System.Drawing.Size(141, 22);
            this.gridView_Course_RightClickMenu_ExceleAktar.Text = "Excel\'e Aktar";
            this.gridView_Course_RightClickMenu_ExceleAktar.Click += new System.EventHandler(this.gridView_Course_RightClickMenu_ExceleAktar_Click);
            // 
            // gridView_Course
            // 
            this.gridView_Course.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_Course.GridControl = this.grid_Course;
            this.gridView_Course.Name = "gridView_Course";
            this.gridView_Course.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kayıt No";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 61;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Kurs Adı";
            this.gridColumn3.FieldName = "CourseName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 111;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kurs Tarihi";
            this.gridColumn2.FieldName = "CourseDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 111;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Kurs Konusu";
            this.gridColumn4.FieldName = "CourseSubject";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 111;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kurs Sorumlusu";
            this.gridColumn5.FieldName = "CourseTeacher";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 111;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Kurs Saati";
            this.gridColumn6.FieldName = "CourseTime";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 111;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Şirket";
            this.gridColumn7.FieldName = "CompanyName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 117;
            // 
            // frmCourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 512);
            this.ControlBox = false;
            this.Controls.Add(this.grid_Course);
            this.Name = "frmCourseManager";
            this.Text = "frmCourseManager";
            this.Load += new System.EventHandler(this.frmCourseManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Course)).EndInit();
            this.gridView_Course_RightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_Course;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Course;
        private System.Windows.Forms.ContextMenuStrip gridView_Course_RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem gridView_Course_RightClickMenu_Yenile;
        private System.Windows.Forms.ToolStripMenuItem gridView_Course_RightClickMenu_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem gridView_Course_RightClickMenu_Sil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gridView_Course_RightClickMenu_ExceleAktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.ToolStripMenuItem gridView_Course_RightClickMenu_Ekle;
    }
}