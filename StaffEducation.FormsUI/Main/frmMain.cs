using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffEducation.FormsUI.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Seven Classic");

        }
        private void navBar_Menus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag != null)
            {
                string formName = e.Link.Item.Tag.ToString();
                Form frm = GetForm(formName);
                if (frm != null)
                {
                    frm.ControlBox = false;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    panelControl_Forms.Controls.Clear();
                    panelControl_Forms.Controls.Add(frm);
                    frm.Show();
                }
            }
        }
        public Form GetForm(string FormName)
        {
            if (!String.IsNullOrEmpty(FormName) && Type.GetType(FormName) != null)
                return (Form)Activator.CreateInstance(Type.GetType(FormName));
            return null;
        }

    }
}