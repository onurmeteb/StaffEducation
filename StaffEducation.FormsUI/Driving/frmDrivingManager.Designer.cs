namespace StaffEducation.FormsUI.Driving
{
    partial class frmDrivingManager
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
            this.gridControl_Driving = new DevExpress.XtraGrid.GridControl();
            this.gridView_Driving = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Driving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Driving)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Driving
            // 
            this.gridControl_Driving.Location = new System.Drawing.Point(12, 12);
            this.gridControl_Driving.MainView = this.gridView_Driving;
            this.gridControl_Driving.Name = "gridControl_Driving";
            this.gridControl_Driving.Size = new System.Drawing.Size(653, 200);
            this.gridControl_Driving.TabIndex = 0;
            this.gridControl_Driving.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Driving});
            // 
            // gridView_Driving
            // 
            this.gridView_Driving.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView_Driving.GridControl = this.gridControl_Driving;
            this.gridView_Driving.Name = "gridView_Driving";
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
            this.gridColumn2.Caption = "Ehliyet Durumu";
            this.gridColumn2.FieldName = "LicenceName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmDrivingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 377);
            this.Controls.Add(this.gridControl_Driving);
            this.Name = "frmDrivingManager";
            this.Text = "frmDrivingManager";
            this.Load += new System.EventHandler(this.frmDrivingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Driving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Driving)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Driving;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Driving;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}