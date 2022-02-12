namespace StaffEducation.FormsUI.Education
{
    partial class frmEducationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEducationForm));
            this.lbl_EducationName = new DevExpress.XtraEditors.LabelControl();
            this.txt_EducationName = new DevExpress.XtraEditors.TextEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EducationName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EducationName
            // 
            this.lbl_EducationName.Location = new System.Drawing.Point(12, 20);
            this.lbl_EducationName.Name = "lbl_EducationName";
            this.lbl_EducationName.Size = new System.Drawing.Size(75, 13);
            this.lbl_EducationName.TabIndex = 0;
            this.lbl_EducationName.Text = "Eğitim Durumu :";
            // 
            // txt_EducationName
            // 
            this.txt_EducationName.Location = new System.Drawing.Point(95, 17);
            this.txt_EducationName.Name = "txt_EducationName";
            this.txt_EducationName.Size = new System.Drawing.Size(455, 20);
            this.txt_EducationName.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Save.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Save.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_Save.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseBorderColor = true;
            this.btn_Save.Appearance.Options.UseForeColor = true;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(462, 57);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 34);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 179);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_EducationName);
            this.Controls.Add(this.lbl_EducationName);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmEducationForm.IconOptions.LargeImage")));
            this.Name = "frmEducationForm";
            this.Text = "Personel Eğitim Yönetimi";
            this.Load += new System.EventHandler(this.frmEducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_EducationName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_EducationName;
        private DevExpress.XtraEditors.TextEdit txt_EducationName;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}