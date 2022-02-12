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

namespace StaffEducation.FormsUI.Driving
{
    public partial class frmDrivingManager : DevExpress.XtraEditors.XtraForm
    {
        private DrivingLicanceManager _drivingLicanceManager { get; set; }
      
        public frmDrivingManager()
        {
            InitializeComponent();
            _drivingLicanceManager = (new DrivingLicanceManager(new DrivingLicanceOperation()));
        }

        private void frmDrivingManager_Load(object sender, EventArgs e)
        {
            gridControl_Driving.DataSource = _drivingLicanceManager.GetAll();
        }
    }
}