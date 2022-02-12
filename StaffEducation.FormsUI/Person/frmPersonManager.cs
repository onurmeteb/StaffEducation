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

namespace StaffEducation.FormsUI.Person
{
    public partial class frmPersonManager : DevExpress.XtraEditors.XtraForm
    {
        private PersonManager _personManager { get; set; }
        public frmPersonManager()
        {
            InitializeComponent();
            _personManager = (new PersonManager(new PersonOperation()));
        }

        private void frmPersonManager_Load(object sender, EventArgs e)
        {
            gridControl_Person.DataSource = _personManager.GetAll();
        }
    }
}