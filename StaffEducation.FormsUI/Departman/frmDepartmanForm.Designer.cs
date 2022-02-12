namespace StaffEducation.FormsUI.Departman
{
    partial class frmDepartmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanForm));
            this.lblDepartmanName = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Departman = new DevExpress.XtraEditors.TextEdit();
            this.btn_DepartmanSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Departman.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmanName
            // 
            this.lblDepartmanName.Location = new System.Drawing.Point(28, 40);
            this.lblDepartmanName.Name = "lblDepartmanName";
            this.lblDepartmanName.Size = new System.Drawing.Size(75, 13);
            this.lblDepartmanName.TabIndex = 0;
            this.lblDepartmanName.Text = "Departman Adı:";
            // 
            // textEdit_Departman
            // 
            this.textEdit_Departman.Location = new System.Drawing.Point(109, 37);
            this.textEdit_Departman.Name = "textEdit_Departman";
            this.textEdit_Departman.Size = new System.Drawing.Size(467, 20);
            this.textEdit_Departman.TabIndex = 2;
            // 
            // btn_DepartmanSave
            // 
            this.btn_DepartmanSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanSave.ImageOptions.Image")));
            this.btn_DepartmanSave.Location = new System.Drawing.Point(478, 63);
            this.btn_DepartmanSave.Name = "btn_DepartmanSave";
            this.btn_DepartmanSave.Size = new System.Drawing.Size(98, 32);
            this.btn_DepartmanSave.TabIndex = 3;
            this.btn_DepartmanSave.Text = "Ekle";
            this.btn_DepartmanSave.Click += new System.EventHandler(this.btn_DepartmanSave_Click);
            // 
            // frmDepartmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 304);
            this.Controls.Add(this.btn_DepartmanSave);
            this.Controls.Add(this.textEdit_Departman);
            this.Controls.Add(this.lblDepartmanName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDepartmanForm.IconOptions.LargeImage")));
            this.Name = "frmDepartmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmDepartmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Departman.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDepartmanName;
        private DevExpress.XtraEditors.TextEdit textEdit_Departman;
        private DevExpress.XtraEditors.SimpleButton btn_DepartmanSave;
    }
}