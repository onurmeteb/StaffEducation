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

namespace StaffEducation.FormsUI.PersonCourse
{
    public partial class frmPersonCourseManager : DevExpress.XtraEditors.XtraForm
    {

        private PersonCourseManager _personCourseManager { get; set; }
        public frmPersonCourseManager()
        {
            InitializeComponent();
            _personCourseManager = (new PersonCourseManager(new PersonCourseOperation()));
        }

        private void frmPersonCourseManager_Load(object sender, EventArgs e)
        {
            Fill_PersonCourse();
        }
        private void Fill_PersonCourse ()
        {
            gridControl_PersonCourse.DataSource = _personCourseManager.GetAll();
        }

        private void gridControl_PersonCourse_Click(object sender, EventArgs e)
        {

        }
    }
}