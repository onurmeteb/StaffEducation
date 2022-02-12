namespace StaffEducation.FormsUI.PersonCourse
{
    partial class frmPersonCourseManager
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
            this.gridControl_PersonCourse = new DevExpress.XtraGrid.GridControl();
            this.gridView_PersonCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PersonCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PersonCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_PersonCourse
            // 
            this.gridControl_PersonCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_PersonCourse.Location = new System.Drawing.Point(0, 0);
            this.gridControl_PersonCourse.MainView = this.gridView_PersonCourse;
            this.gridControl_PersonCourse.Name = "gridControl_PersonCourse";
            this.gridControl_PersonCourse.Size = new System.Drawing.Size(716, 455);
            this.gridControl_PersonCourse.TabIndex = 0;
            this.gridControl_PersonCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PersonCourse});
            this.gridControl_PersonCourse.Click += new System.EventHandler(this.gridControl_PersonCourse_Click);
            // 
            // gridView_PersonCourse
            // 
            this.gridView_PersonCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView_PersonCourse.GridControl = this.gridControl_PersonCourse;
            this.gridView_PersonCourse.Name = "gridView_PersonCourse";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kurs Numarası";
            this.gridColumn2.FieldName = "CourseID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Personel Numarası";
            this.gridColumn3.FieldName = "PersonelID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmPersonCourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 455);
            this.Controls.Add(this.gridControl_PersonCourse);
            this.Name = "frmPersonCourseManager";
            this.Text = "frmPersonCourseManager";
            this.Load += new System.EventHandler(this.frmPersonCourseManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PersonCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PersonCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_PersonCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PersonCourse;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}