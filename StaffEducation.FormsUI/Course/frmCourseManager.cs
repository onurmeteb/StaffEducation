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

namespace StaffEducation.FormsUI.Course
{
    public partial class frmCourseManager : DevExpress.XtraEditors.XtraForm
    {
        private CourseContentsManager _courseContentsManager { get; set; }
        public frmCourseManager()
        {
            InitializeComponent();
            _courseContentsManager = new CourseContentsManager(new CourseContentsOperation());
        }

        private void frmCourseManager_Load(object sender, EventArgs e)
        {
            grid_Course_Fill();
        }

        private void grid_Course_Fill()
        {
            grid_Course.DataSource = _courseContentsManager.GetAll();
        }

        private void gridView_Course_RightClickMenu_Yenile_Click(object sender, EventArgs e)
        {
            grid_Course_Fill();
        }

        private void gridView_Course_RightClickMenu_Duzenle_Click(object sender, EventArgs e)
        {
            gridView_Course_EditRow();
        }

        private void gridView_Course_EditRow()
        {
            if (gridView_Course.GetFocusedRow() != null)
            {
                StaffEducation.Entity.Concrete.Course selectedRow = ((StaffEducation.Entity.Concrete.Course)gridView_Course.GetFocusedRow());
                Show_frmCourseForm(selectedRow.ID);
            }
        }

        private void Show_frmCourseForm(Int64? ID = null)
        {
            frmCourseForm frmCourseForm = new frmCourseForm();
            frmCourseForm.ID = ID;
            frmCourseForm.StartPosition = FormStartPosition.CenterScreen;
            if (frmCourseForm.ShowDialog() == DialogResult.OK)
            {
                grid_Course_Fill();
            }
        }

        private void gridView_Course_RightClickMenu_Sil_Click(object sender, EventArgs e)
        {
            gridView_Course_DeleteRow();
        }


        //Data Status 0'a çekilecek
        private void gridView_Course_DeleteRow()
        {
            if (gridView_Course.GetFocusedRow() != null)
            {
                if (XtraMessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StaffEducation.Entity.Concrete.Course selectedRow = ((StaffEducation.Entity.Concrete.Course)gridView_Course.GetFocusedRow());
                    _courseContentsManager.Delete(selectedRow);
                    //selectedRow.DataStatus = 0;

                }
            }
        }

        private void gridView_Course_RightClickMenu_ExceleAktar_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog frmdialog = new XtraSaveFileDialog();
            frmdialog.Filter = "Execl files (*.xls)|*.xls";
            frmdialog.FileName = "export.xlsx";
            if (frmdialog.ShowDialog() == DialogResult.OK)
            {
                grid_Course.ExportToXlsx(frmdialog.FileName);
            }
        }

        private void gridView_Course_RightClickMenu_Ekle_Click(object sender, EventArgs e)
        {
            Show_frmCourseForm();
        }

      
    }
}