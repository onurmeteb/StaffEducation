namespace StaffEducation.FormsUI.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barButtonItem_Newrow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_EditRow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DeleteRow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBar_Menus = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_Persons = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Personeller = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_PerCourseManager = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_ModulSettings = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_CourseManagement = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_DrivingLicance = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_EduManagement = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_MilitaryManagement = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Departmans = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl_Forms = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar_Menus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Forms)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.skinDropDownButtonItem1,
            this.barButtonItem_Newrow,
            this.barButtonItem_EditRow,
            this.barButtonItem_DeleteRow,
            this.barButtonItem_ExcelExport});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1108, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 5;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barButtonItem_Newrow
            // 
            this.barButtonItem_Newrow.Caption = "Yeni Kayıt";
            this.barButtonItem_Newrow.Id = 6;
            this.barButtonItem_Newrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Newrow.ImageOptions.Image")));
            this.barButtonItem_Newrow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Newrow.ImageOptions.LargeImage")));
            this.barButtonItem_Newrow.Name = "barButtonItem_Newrow";
            // 
            // barButtonItem_EditRow
            // 
            this.barButtonItem_EditRow.Caption = "Düzenle";
            this.barButtonItem_EditRow.Id = 7;
            this.barButtonItem_EditRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_EditRow.ImageOptions.Image")));
            this.barButtonItem_EditRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_EditRow.ImageOptions.LargeImage")));
            this.barButtonItem_EditRow.Name = "barButtonItem_EditRow";
            // 
            // barButtonItem_DeleteRow
            // 
            this.barButtonItem_DeleteRow.Caption = "Sil";
            this.barButtonItem_DeleteRow.Id = 8;
            this.barButtonItem_DeleteRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DeleteRow.ImageOptions.Image")));
            this.barButtonItem_DeleteRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DeleteRow.ImageOptions.LargeImage")));
            this.barButtonItem_DeleteRow.Name = "barButtonItem_DeleteRow";
            // 
            // barButtonItem_ExcelExport
            // 
            this.barButtonItem_ExcelExport.Caption = "Excel Dışarı Aktar";
            this.barButtonItem_ExcelExport.Id = 9;
            this.barButtonItem_ExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ExcelExport.ImageOptions.Image")));
            this.barButtonItem_ExcelExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ExcelExport.ImageOptions.LargeImage")));
            this.barButtonItem_ExcelExport.Name = "barButtonItem_ExcelExport";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Araçlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasarım Ayarları";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_Newrow);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_EditRow);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem_DeleteRow);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Yönetim";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_ExcelExport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Dışarı Aktar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 714);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1108, 24);
            // 
            // navBar_Menus
            // 
            this.navBar_Menus.ActiveGroup = this.navBarGroup_Persons;
            this.navBar_Menus.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar_Menus.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_Persons,
            this.navBarGroup_ModulSettings});
            this.navBar_Menus.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_Personeller,
            this.navBarItem_PerCourseManager,
            this.navBarItem_CourseManagement,
            this.navBarItem_DrivingLicance,
            this.navBarItem_EduManagement,
            this.navBarItem_MilitaryManagement,
            this.navBarItem_Departmans,
            this.navBarItem1,
            this.navBarItem2});
            this.navBar_Menus.Location = new System.Drawing.Point(0, 158);
            this.navBar_Menus.Name = "navBar_Menus";
            this.navBar_Menus.OptionsNavPane.ExpandedWidth = 236;
            this.navBar_Menus.Size = new System.Drawing.Size(236, 556);
            this.navBar_Menus.TabIndex = 2;
            this.navBar_Menus.Text = "navBarControl1";
            this.navBar_Menus.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBar_Menus_LinkClicked);
            // 
            // navBarGroup_Persons
            // 
            this.navBarGroup_Persons.Caption = "Personel Yönetimi";
            this.navBarGroup_Persons.Expanded = true;
            this.navBarGroup_Persons.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Personeller),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_PerCourseManager)});
            this.navBarGroup_Persons.Name = "navBarGroup_Persons";
            // 
            // navBarItem_Personeller
            // 
            this.navBarItem_Personeller.Caption = "Personeller";
            this.navBarItem_Personeller.Name = "navBarItem_Personeller";
            // 
            // navBarItem_PerCourseManager
            // 
            this.navBarItem_PerCourseManager.Caption = "Personel Kurs Yönetimi";
            this.navBarItem_PerCourseManager.Name = "navBarItem_PerCourseManager";
            // 
            // navBarGroup_ModulSettings
            // 
            this.navBarGroup_ModulSettings.Caption = "Modül Ayarları";
            this.navBarGroup_ModulSettings.Expanded = true;
            this.navBarGroup_ModulSettings.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_CourseManagement),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_DrivingLicance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_EduManagement),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_MilitaryManagement),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Departmans),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup_ModulSettings.Name = "navBarGroup_ModulSettings";
            // 
            // navBarItem_CourseManagement
            // 
            this.navBarItem_CourseManagement.Caption = "Kurslar";
            this.navBarItem_CourseManagement.Name = "navBarItem_CourseManagement";
            this.navBarItem_CourseManagement.Tag = "StaffEducation.FormsUI.Course.frmCourseManager";
            // 
            // navBarItem_DrivingLicance
            // 
            this.navBarItem_DrivingLicance.Caption = "Ehliyet Bilgileri";
            this.navBarItem_DrivingLicance.Name = "navBarItem_DrivingLicance";
            this.navBarItem_DrivingLicance.Tag = "StaffEducation.FormsUI.Driving.frmDrivingManager";
            // 
            // navBarItem_EduManagement
            // 
            this.navBarItem_EduManagement.Caption = "Okul Bilgileri";
            this.navBarItem_EduManagement.Name = "navBarItem_EduManagement";
            this.navBarItem_EduManagement.Tag = "StaffEducation.FormsUI.Education.frmEducationManager";
            // 
            // navBarItem_MilitaryManagement
            // 
            this.navBarItem_MilitaryManagement.Caption = "Askerlik Bilgileri";
            this.navBarItem_MilitaryManagement.Name = "navBarItem_MilitaryManagement";
            this.navBarItem_MilitaryManagement.Tag = "StaffEducation.FormsUI.MilitaryType.frmMilitaryManager";
            // 
            // navBarItem_Departmans
            // 
            this.navBarItem_Departmans.Caption = "Departmanlar";
            this.navBarItem_Departmans.Name = "navBarItem_Departmans";
            this.navBarItem_Departmans.Tag = "StaffEducation.FormsUI.Departman.frmDepartmanManager";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Personel Kurs";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.Tag = "StaffEducation.FormsUI.PersonCourse.frmPersonCourseManager";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Personel";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.Tag = "StaffEducation.FormsUI.Person.frmPersonManager";
            // 
            // panelControl_Forms
            // 
            this.panelControl_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_Forms.Location = new System.Drawing.Point(236, 158);
            this.panelControl_Forms.Name = "panelControl_Forms";
            this.panelControl_Forms.Size = new System.Drawing.Size(872, 556);
            this.panelControl_Forms.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 738);
            this.Controls.Add(this.panelControl_Forms);
            this.Controls.Add(this.navBar_Menus);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "İnsan Kaynakları Modülü";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar_Menus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Forms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBar_Menus;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Persons;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Personeller;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_PerCourseManager;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_ModulSettings;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_CourseManagement;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_DrivingLicance;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_EduManagement;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_MilitaryManagement;
        private DevExpress.XtraEditors.PanelControl panelControl_Forms;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Newrow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_EditRow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteRow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ExcelExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Departmans;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
    }
}