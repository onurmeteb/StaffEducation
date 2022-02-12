using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StaffEducation.Business.Abstract;
using StaffEducation.Business.Concrete;
using StaffEducation.DataAccess.Concrete;
using StaffEducation.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffEducation.FormsUI.Departman
{
    public partial class frmDepartmanManager : DevExpress.XtraEditors.XtraForm
    {

        //gridView_Departmans
        public frmDepartmanManager()
        {
            InitializeComponent();
            _departmanManager = new DepartmanManager(new DepartmanOperation());
            GridView view = gridView_Departmans;
            view.OptionsBehavior.Editable = true;
            view.ShowEditor();
        }

        private DepartmanManager _departmanManager { get; set; }
        private void grid_Departmans_Fill()
        {
            BaseResult<List<StaffEducation.Entity.Concrete.Departman>> res = _departmanManager.GetAll();
            if (res.ResultType == ValidationErrorType.Success)
            {
                gridControl_Departman.DataSource = new BindingList<StaffEducation.Entity.Concrete.Departman>(res.Result);
            }
            else
            {
                XtraMessageBox.Show(res.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridControl_Departman.DataSource = null;
            }
        }
        private void frmDepartmanManager_Load(object sender, EventArgs e)
        {
            grid_Departmans_Fill();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridView_Course_DeleteRow()
        {
            if (gridView_Departmans.GetFocusedRow() != null)
            {
                if (XtraMessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StaffEducation.Entity.Concrete.Departman selectedRow = ((StaffEducation.Entity.Concrete.Departman)gridView_Departmans.GetFocusedRow());
                    _departmanManager.Delete(selectedRow);
                    //selectedRow.DataStatus = 0;

                }
            }
        }
        private void gridView_Course_EditRow()
        {
            if (gridView_Departmans.GetFocusedRow() != null)
            {
                StaffEducation.Entity.Concrete.Departman selectedRow = ((StaffEducation.Entity.Concrete.Departman)gridView_Departmans.GetFocusedRow());
                Show_frmCourseForm(selectedRow.ID);
            }
        }
        private void Show_frmCourseForm(Int64? ID = null)
        {
            frmDepartmanForm frmDepartmanForm = new frmDepartmanForm();
            frmDepartmanForm.ID = ID;
            frmDepartmanForm.StartPosition = FormStartPosition.CenterScreen;
            if (frmDepartmanForm.ShowDialog() == DialogResult.OK)
            {
                grid_Departmans_Fill();
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_Departmans_Fill();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_frmCourseForm();
        }


        //edit
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView_Course_EditRow();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView_Departmans.GetFocusedRow() != null)
            {
                if (XtraMessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StaffEducation.Entity.Concrete.Departman selectedRow = ((StaffEducation.Entity.Concrete.Departman)gridView_Departmans.GetFocusedRow());
                    _departmanManager.Delete(selectedRow);
                    //selectedRow.DataStatus = 0;
                    //buraya kürşatla beraber bakıcaz.
                }
            }
        }

        private void gridView_Departmans_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gridView_Departmans.GetRow(e.RowHandle) != null)
                _departmanManager.Update(((StaffEducation.Entity.Concrete.Departman)e.Row));
            else
                _departmanManager.Add(((StaffEducation.Entity.Concrete.Departman)e.Row));

            grid_Departmans_Fill();
        }
    }
}