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

namespace StaffEducation.FormsUI.MilitaryType
{

    public partial class frmMilitaryForm : DevExpress.XtraEditors.XtraForm
    {

        public Int64? ID { get; set; }
        private MilitaryTypeManager _militaryTypeManager;
        public frmMilitaryForm()
        {
            InitializeComponent();
            _militaryTypeManager = (new MilitaryTypeManager(new MilitaryTypeOperation()));
        }

        private void frmMilitaryForm_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                Btn_Save.Text = "Güncelle";
                StaffEducation.Entity.Concrete.MilitaryType military = _militaryTypeManager.Get(x => x.ID == this.ID.Value);
                Form_Init(military);
            }
        }

        private void Form_Init(StaffEducation.Entity.Concrete.MilitaryType military)
        {
            textEdit_MilitaryName.EditValue = military.MilitaryName;
        }

        private StaffEducation.Entity.Concrete.MilitaryType Get_Form()
        {
            StaffEducation.Entity.Concrete.MilitaryType returnData = new StaffEducation.Entity.Concrete.MilitaryType();

            if (ID.HasValue)
                returnData.ID = this.ID.Value;

            returnData.MilitaryName = textEdit_MilitaryName.Text;

            returnData.DataStatus = 1;

            return returnData;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Değişiklikleri kaydetmke istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID.HasValue)
                    _militaryTypeManager.Update(Get_Form());
                else
                    _militaryTypeManager.Add(Get_Form());

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}