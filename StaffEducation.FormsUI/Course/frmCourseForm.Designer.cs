namespace StaffEducation.FormsUI.Course
{
    partial class frmCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseForm));
            this.txt_CourseName = new DevExpress.XtraEditors.TextEdit();
            this.txt_CompanyName = new DevExpress.XtraEditors.TextEdit();
            this.txt_CourseTeacher = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CourseDate = new DevExpress.XtraEditors.DateEdit();
            this.txt_CourseSubject = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CourseTime = new DevExpress.XtraEditors.SpinEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Location = new System.Drawing.Point(12, 36);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(618, 20);
            this.txt_CourseName.TabIndex = 0;
            this.txt_CourseName.Tag = "CourseName";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(335, 137);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(295, 20);
            this.txt_CompanyName.TabIndex = 2;
            this.txt_CompanyName.Tag = "CompanyName";
            // 
            // txt_CourseTeacher
            // 
            this.txt_CourseTeacher.Location = new System.Drawing.Point(12, 137);
            this.txt_CourseTeacher.Name = "txt_CourseTeacher";
            this.txt_CourseTeacher.Size = new System.Drawing.Size(295, 20);
            this.txt_CourseTeacher.TabIndex = 4;
            this.txt_CourseTeacher.Tag = "CourseTeacher";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Kurs Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kurs Tarihi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(335, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Kurs Veren Şirket";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Kurs Konusu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Kurs Sorumlusu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(335, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Kurs Süresi";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(481, 327);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(149, 38);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_CourseDate
            // 
            this.txt_CourseDate.EditValue = null;
            this.txt_CourseDate.Location = new System.Drawing.Point(12, 85);
            this.txt_CourseDate.Name = "txt_CourseDate";
            this.txt_CourseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_CourseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_CourseDate.Properties.DisplayFormat.FormatString = "";
            this.txt_CourseDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_CourseDate.Properties.EditFormat.FormatString = "";
            this.txt_CourseDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_CourseDate.Properties.MaskSettings.Set("mask", "");
            this.txt_CourseDate.Size = new System.Drawing.Size(295, 20);
            this.txt_CourseDate.TabIndex = 1;
            this.txt_CourseDate.Tag = "CourseDate";
            // 
            // txt_CourseSubject
            // 
            this.txt_CourseSubject.Location = new System.Drawing.Point(12, 192);
            this.txt_CourseSubject.Name = "txt_CourseSubject";
            this.txt_CourseSubject.Size = new System.Drawing.Size(618, 118);
            this.txt_CourseSubject.TabIndex = 3;
            this.txt_CourseSubject.Tag = "CourseSubject";
            // 
            // txt_CourseTime
            // 
            this.txt_CourseTime.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_CourseTime.Location = new System.Drawing.Point(335, 85);
            this.txt_CourseTime.Name = "txt_CourseTime";
            this.txt_CourseTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_CourseTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_CourseTime.Size = new System.Drawing.Size(295, 20);
            this.txt_CourseTime.TabIndex = 5;
            this.txt_CourseTime.Tag = "CourseTime";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 377);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_CourseTeacher);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.txt_CourseDate);
            this.Controls.Add(this.txt_CourseSubject);
            this.Controls.Add(this.txt_CourseTime);
            this.Name = "frmCourseForm";
            this.Text = "Kurs Yönetim";
            this.Load += new System.EventHandler(this.frmCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_CourseName;
        private DevExpress.XtraEditors.TextEdit txt_CompanyName;
        private DevExpress.XtraEditors.TextEdit txt_CourseTeacher;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.DateEdit txt_CourseDate;
        private DevExpress.XtraEditors.MemoEdit txt_CourseSubject;
        private DevExpress.XtraEditors.SpinEdit txt_CourseTime;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}