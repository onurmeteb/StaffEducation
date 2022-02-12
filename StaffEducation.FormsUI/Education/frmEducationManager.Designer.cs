namespace StaffEducation.FormsUI.Education
{
    partial class frmEducationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEducationManager));
            this.gridControl_Education = new DevExpress.XtraGrid.GridControl();
            this.gridView_Education = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip_Right_Click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Education)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Education)).BeginInit();
            this.contextMenuStrip_Right_Click.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Education
            // 
            this.gridControl_Education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Education.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Education.MainView = this.gridView_Education;
            this.gridControl_Education.Name = "gridControl_Education";
            this.gridControl_Education.Size = new System.Drawing.Size(742, 510);
            this.gridControl_Education.TabIndex = 0;
            this.gridControl_Education.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Education});
            this.gridControl_Education.Click += new System.EventHandler(this.gridControl_Education_Click);
            // 
            // gridView_Education
            // 
            this.gridView_Education.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.gridView_Education.GridControl = this.gridControl_Education;
            this.gridView_Education.Name = "gridView_Education";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "No";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Okul Eğitim Seviye";
            this.gridColumn1.FieldName = "EducationName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // contextMenuStrip_Right_Click
            // 
            this.contextMenuStrip_Right_Click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.ekleToolStripMenuItem});
            this.contextMenuStrip_Right_Click.Name = "contextMenuStrip_Right_Click";
            this.contextMenuStrip_Right_Click.Size = new System.Drawing.Size(117, 70);
            this.contextMenuStrip_Right_Click.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // frmEducationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 510);
            this.Controls.Add(this.gridControl_Education);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmEducationManager.IconOptions.LargeImage")));
            this.Name = "frmEducationManager";
            this.Text = "Personel Okul Yönetimi";
            this.Load += new System.EventHandler(this.frmEducationManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Education)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Education)).EndInit();
            this.contextMenuStrip_Right_Click.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Education;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Education;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Right_Click;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
    }
}