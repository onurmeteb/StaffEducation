using DevExpress.XtraEditors;
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

namespace StaffEducation.FormsUI.Education
{

    public partial class frmEducationForm : DevExpress.XtraEditors.XtraForm
    {
        public Int64? ID { get; set; }
        private EducationManager _educationManager;
        public frmEducationForm()
        {
            InitializeComponent();
            _educationManager = new EducationManager(new EducationOperation());
        }

        private void frmEducationForm_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                btn_Save.Text = "Güncelle";
                StaffEducation.Entity.Concrete.Education education = _educationManager.Get(x => x.ID == this.ID.Value);
                Form_Init(education);
            }
        }

        private void Form_Init(Entity.Concrete.Education education)
        {
            txt_EducationName.EditValue = education.EducationName;
        }

        private StaffEducation.Entity.Concrete.Education Get_Form()
        {
            StaffEducation.Entity.Concrete.Education returnData = new StaffEducation.Entity.Concrete.Education();

            if (ID.HasValue)
                returnData.ID = this.ID.Value;

            returnData.EducationName = txt_EducationName.Text;
            returnData.DataStatus = 1;

            return returnData;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Değişiklikleri kaydetmke istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID.HasValue)
                    _educationManager.Update(Get_Form());
                else
                    _educationManager.Add(Get_Form());

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}