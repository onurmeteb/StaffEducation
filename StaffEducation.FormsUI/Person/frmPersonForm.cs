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
    public partial class frmPersonForm : DevExpress.XtraEditors.XtraForm
    {
        public Int64? ID { get; set; }
        private PersonManager _personManager;
        public frmPersonForm()
        {
            InitializeComponent();
            _personManager = (new PersonManager(new PersonOperation()));
        }

        private void frmPersonForm_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
            {
                btn_Save.Text = "Güncelle";
                StaffEducation.Entity.Concrete.Person person = _personManager.Get(x => x.ID == this.ID.Value);
                Form_Init(person);
            }
        }

        private void Form_Init(Entity.Concrete.Person person)
        {

            textEdit_Birthday.EditValue = person.BirthDate;
            textEdit_DateOfStart.EditValue = person.DateOfStart;
            textEdit_Email.EditValue = person.MailAddress;
            textEdit_Name.EditValue = person.Name;
            textEdit_Surname.EditValue = person.Surname;
            textEdit_Phone.EditValue = person.Surname;
            textEdit_Salary.EditValue = person.Salary;
            comboBoxEdit_Departmen.EditValue = person.DepartmentID;
            comboBoxEdit_Driving.EditValue = person.DrivingLicenceID;
            comboBoxEdit_Education.EditValue = person.EducationID;
            comboBoxEdit_Marital.EditValue = person.MaritalStatus;
            comboBoxEdit_Military.EditValue = person.MilitaryStatusID;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}