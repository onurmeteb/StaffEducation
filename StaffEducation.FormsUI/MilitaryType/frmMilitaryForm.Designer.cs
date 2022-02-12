namespace StaffEducation.FormsUI.MilitaryType
{
    partial class frmMilitaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMilitaryForm));
            this.lblMilitaryName = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MilitaryName = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MilitaryName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMilitaryName
            // 
            this.lblMilitaryName.Location = new System.Drawing.Point(24, 22);
            this.lblMilitaryName.Name = "lblMilitaryName";
            this.lblMilitaryName.Size = new System.Drawing.Size(83, 13);
            this.lblMilitaryName.TabIndex = 0;
            this.lblMilitaryName.Text = "Askerlik Durumu :";
            // 
            // textEdit_MilitaryName
            // 
            this.textEdit_MilitaryName.Location = new System.Drawing.Point(113, 19);
            this.textEdit_MilitaryName.Name = "textEdit_MilitaryName";
            this.textEdit_MilitaryName.Size = new System.Drawing.Size(344, 20);
            this.textEdit_MilitaryName.TabIndex = 1;
            // 
            // Btn_Save
            // 
            this.Btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_Save.Location = new System.Drawing.Point(382, 45);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 28);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "Kaydet";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // frmMilitaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 202);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.textEdit_MilitaryName);
            this.Controls.Add(this.lblMilitaryName);
            this.Name = "frmMilitaryForm";
            this.Text = "frmMilitaryForm";
            this.Load += new System.EventHandler(this.frmMilitaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MilitaryName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMilitaryName;
        private DevExpress.XtraEditors.TextEdit textEdit_MilitaryName;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
    }
}