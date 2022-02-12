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
    public partial class frmEducationManager : DevExpress.XtraEditors.XtraForm
    {
        private EducationManager _educationManager;
        public frmEducationManager()
        {
            InitializeComponent();
            _educationManager = (new EducationManager(new EducationOperation()));
        }

        private void gridControl_Education_Click(object sender, EventArgs e)
        {

        }

        private void frmEducationManager_Load(object sender, EventArgs e)
        {
            frm_Educadion_Fill();
        }
       private void frm_Educadion_Fill()
        {
            gridControl_Education.DataSource = _educationManager.GetAll();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Educadion_Fill();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            
        }
    }
}