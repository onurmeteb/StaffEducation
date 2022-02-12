using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using StaffEducation.Business.Abstract;
using StaffEducation.Business.Concrete;
using StaffEducation.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffEducation.FormsUI.Course
{
    public partial class frmCourseForm : DevExpress.XtraEditors.XtraForm
    {
        public Int64? ID { get; set; }
        private CourseContentsManager _courseContentsManager { get; set; }
        public frmCourseForm()
        {
            InitializeComponent();
            _courseContentsManager = new CourseContentsManager(new CourseContentsOperation());
        }

        private void frmCourseForm_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                btn_Save.Text = "Güncelle";
                BaseResult<StaffEducation.Entity.Concrete.Course> courseDt = _courseContentsManager.Get(x => x.ID == this.ID.Value);
                if (courseDt.ResultType == ValidationErrorType.Success)
                {
                    Form_Init(courseDt.Result);
                }
                else
                {
                    XtraMessageBox.Show(courseDt.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form_Init(StaffEducation.Entity.Concrete.Course course)
        {

            //Send
            txt_CompanyName.EditValue = course.CompanyName;
            txt_CourseDate.EditValue = course.CourseDate;
            txt_CourseName.EditValue = course.CourseName;
            txt_CourseSubject.EditValue = course.CourseSubject;
            txt_CourseTeacher.EditValue = course.CourseTeacher;
            txt_CourseTime.EditValue = course.CourseTime;


            //burada kaldım
        }

        private StaffEducation.Entity.Concrete.Course Get_Form()
        {
            StaffEducation.Entity.Concrete.Course returnData = new StaffEducation.Entity.Concrete.Course();

            if (ID.HasValue)
                returnData.ID = this.ID.Value;

            returnData.CompanyName = txt_CompanyName.Text;
            returnData.CourseDate = (DateTime?)txt_CourseDate.EditValue;
            returnData.CourseName = txt_CourseName.Text;
            returnData.CourseSubject = txt_CourseSubject.Text;
            returnData.CourseTeacher = txt_CourseTeacher.Text;
            returnData.CourseTime = Convert.ToInt32(txt_CourseTime.Text);
            returnData.DataStatus = 1;

            return returnData;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Değişiklikleri kaydetmke istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BaseResult<bool> res;
                if (ID.HasValue)
                {
                    res = _courseContentsManager.Update(Get_Form());
                }
                else
                {
                    res = _courseContentsManager.Add(Get_Form());
                }



                //---***----
                if (res.ResultType == ValidationErrorType.Error)
                {
                    dxErrorProvider1.ClearErrors();
                    for (int i = 0; i < res.Errors.Count; i++)
                    {
                        ValidationError err = res.Errors[i];
                        Control cntrl = this.Controls.Cast<Control>().First(x => x.Tag != null && x.Tag.ToString() == err.FieldName);
                        if (cntrl != null)
                            dxErrorProvider1.SetError(cntrl, err.Message);
                    }
                }
                else
                {
                    XtraMessageBox.Show(res.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}