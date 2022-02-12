using DevExpress.XtraEditors;
using StaffEducation.Business.Abstract;
using StaffEducation.Business.Concrete;
using StaffEducation.DataAccess.Concrete;
using StaffEducation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffEducation.FormsUI.Departman
{

    public partial class frmDepartmanForm : DevExpress.XtraEditors.XtraForm
    {
        public Int64? ID { get; set; }
        private DepartmanManager _departmanManager { get; set; }
        public frmDepartmanForm()
        {
            InitializeComponent();
            _departmanManager = new DepartmanManager(new DepartmanOperation());
        }


        //private void frmCourseForm_Load(object sender, EventArgs e)
        //{
        //    if (ID.HasValue)
        //    {
        //        btn_DepartmanSave.Text = "Güncelle";
        //        StaffEducation.Entity.Concrete.Departman departman = _departmanManager.Get(x => x.ID == this.ID.Value);
        //        Form_Init(departman);
        //    }
        //}

        private void Form_Init(StaffEducation.Entity.Concrete.Departman departman)
        {
            textEdit_Departman.EditValue = departman.DepartmanName;

        }

        private void frmDepartmanForm_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                btn_DepartmanSave.Text = "Güncelle";
                BaseResult<StaffEducation.Entity.Concrete.Departman> courseDt = _departmanManager.Get(x => x.ID == this.ID.Value);
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
        private StaffEducation.Entity.Concrete.Departman Get_Form()
        {
            StaffEducation.Entity.Concrete.Departman returnData = new StaffEducation.Entity.Concrete.Departman();

            if (ID.HasValue)
                returnData.ID = this.ID.Value;

            returnData.DepartmanName = textEdit_Departman.Text;

            returnData.DataStatus = 1;

            return returnData;
        }

        private void btn_DepartmanSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Değişiklikleri kaydetmke istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BaseResult<bool> res;
                if (ID.HasValue)
                    res = _departmanManager.Update(Get_Form());
                else
                    res = _departmanManager.Add(Get_Form());

                XtraMessageBox.Show(res.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (res.ResultType == ValidationErrorType.Error)
                {

                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}