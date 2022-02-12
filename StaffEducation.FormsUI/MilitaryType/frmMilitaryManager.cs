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
    public partial class frmMilitaryManager : DevExpress.XtraEditors.XtraForm
    {
        private MilitaryTypeManager _militaryTypeManager;
        public frmMilitaryManager()
        {
            InitializeComponent();
            _militaryTypeManager = (new MilitaryTypeManager(new MilitaryTypeOperation()));
        }

        private void gridControl_Military_Click(object sender, EventArgs e)
        {

        }

        private void frmMilitaryManager_Load(object sender, EventArgs e)
        {
            Military_Fill();
        }
        private void Military_Fill()
        {
            gridControl_Military.DataSource = _militaryTypeManager.GetAll();
        }
        private void gridView_Course_EditRow()
        {
            if (gridView_Military.GetFocusedRow() != null)
            {
                StaffEducation.Entity.Concrete.MilitaryType selectedRow = ((StaffEducation.Entity.Concrete.MilitaryType)gridView_Military.GetFocusedRow());
                Show_frmCourseForm(selectedRow.ID);
            }
        }
        private void Show_frmCourseForm(Int64? ID = null)
        {
            frmMilitaryForm frmDepartmanForm = new frmMilitaryForm();
            frmDepartmanForm.ID = ID;
            frmDepartmanForm.StartPosition = FormStartPosition.CenterScreen;
            if (frmDepartmanForm.ShowDialog() == DialogResult.OK)
            {
                Military_Fill();
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Military_Fill();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_frmCourseForm();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView_Course_EditRow();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView_Military.GetFocusedRow() != null)
            {
                if (XtraMessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StaffEducation.Entity.Concrete.MilitaryType selectedRow = ((StaffEducation.Entity.Concrete.MilitaryType)gridView_Military.GetFocusedRow());
                    _militaryTypeManager.Delete(selectedRow);
                    //selectedRow.DataStatus = 0;
                }
            }
        }
    }
}