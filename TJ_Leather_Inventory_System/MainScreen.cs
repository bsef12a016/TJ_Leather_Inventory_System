using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraCharts;


namespace GUI_Test_4
{
    public partial class App : XtraForm
    {
        public App()
        {
            InitializeComponent();
            InitSkinGallery();
            InitChartControl();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        void InitChartControl()
        {
           /* chartControl.AppearanceName = "Light";
            chartControl.PaletteName = "Office";
            ChangeSeries(ViewType.Bar);
            chartControl.Legend.Visible = false;
            chartControl.Series[0].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;*/
        }
        void ChangeSeries(ViewType viewType)
        {
           /* double[] values = { 3.1, 2.3, 3.2, 3.9, 5.1 };
            Series series = new Series("Series", viewType);
            for (int i = 0; i < values.Length; i++)
                series.Points.Add(new SeriesPoint((i + 1) * 10, new double[] { values[i], values[i] + 3, values[i] + 2, values[i] + 1 }));
            chartControl.Series.Clear();
            chartControl.Series.Add(series);*/
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //DashboardItem Click Event 
        private void ViewDashboardItem_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DashBoard DashMDIChild = new DashBoard();
            DashMDIChild.MdiParent = this;
            DashMDIChild.Show();
        }

        //Raw Materials Data Entry Click Event
        private void RawMaterialsDataEntryItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RawMaterialsDataEntry RawMatDataEntryMDIChild = new RawMaterialsDataEntry();
            RawMatDataEntryMDIChild.MdiParent = this;
            RawMatDataEntryMDIChild.Show();
        }

        //Raw Materials Reports Click Event 
        private void RawMaterialsReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RawMaterialsReports RawMatReporMDIChild=new RawMaterialsReports();
            RawMatReporMDIChild.MdiParent = this;
            RawMatReporMDIChild.Show();
        }

        //View Inventory Click Event
        private void ViewInventory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ViewInventory ViewInventoryMDIChild = new ViewInventory();
            ViewInventoryMDIChild.MdiParent = this;
            ViewInventoryMDIChild.Show();
        }

        //Inventory Report Click Event
        private void ViewInventoryReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InventoryReports ViewInventoryReportMDIChild = new InventoryReports();
            ViewInventoryReportMDIChild.MdiParent = this;
            ViewInventoryReportMDIChild.Show();
        }

        //Invenotry Adjustment Click Event 
        private void AdjustInventory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InventoryAdjustment InventoryAdjMDIChild = new InventoryAdjustment();
            InventoryAdjMDIChild.MdiParent = this;
            InventoryAdjMDIChild.Show();
        }


        //Add inventory items Click Event
        private void AddInventoryItems_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InventoryDataEntry InventoryDataEntryMDIChild = new InventoryDataEntry();
            InventoryDataEntryMDIChild.MdiParent = this;
            InventoryDataEntryMDIChild.Show();
        }

        //View Orders Reports Click Event
        private void ViewOrdersReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OrdersReports ViewOrderReports = new OrdersReports();
            ViewOrderReports.MdiParent = this;
            ViewOrderReports.Show();
        }

        //Orders Data Entry Click Event
        private void OrdersDataEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OrdersDataEntry OrdersDataEntry = new OrdersDataEntry();
            OrdersDataEntry.MdiParent = this;
            OrdersDataEntry.Show();
        }

        //Clients Data Entry Click Event
        private void ClientsDataEntry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ClientDataEntry ClientDataEntry = new ClientDataEntry();
            ClientDataEntry.MdiParent = this;
            ClientDataEntry.Show();
        }

        //View Client Reports Click Event
        private void ViewClientReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ClientReports ViewClientReports = new ClientReports();
            ViewClientReports.MdiParent = this;
            ViewClientReports.Show();
        }

        //Save File Button Click Event
        private void SaveFileButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
        }

        //Import Data Button Click Event
        private void ImportDataButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog imp = new SaveFileDialog();
            imp.ShowDialog();
        }

        //Data Source Selection Button Click Event
        private void DataSoruceButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataSource dtSrc = new DataSource();
            dtSrc.Show();
        }

        //Company Information Button Click Event
        private void CompanyInformationButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompanyInfo cmpInfo = new CompanyInfo();
            cmpInfo.Show();
        }


        //About Us Button Click Event
        private void AboutUsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutScreen abscr = new AboutScreen();
            abscr.Show();
        }

        //Labor Department Click Event
        private void LaborDepartmentItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        //Cutting Department Click Event 
        private void CuttingDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        

        //Upper Department Click Event
        private void UpperDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        //Sole Department Click Event 
        private void SoleDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        //Bottom Department Click Event
        private void BottomDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        //Pasting Department Click Event
        private void PastingDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        //Finising Department Click Event
        private void FinishingDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        //Export Data Button Click Event
        private void ExportDataButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //Help Button Click Event
        private void HelpButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //View Employee Records
        private void EmployeeRecordsItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ViewEmployeeRecords empRecord = new ViewEmployeeRecords();
            empRecord.MdiParent = this;
            empRecord.Show();
        }

        //Add Employee Records
        private void EmployeeAdditionItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddEmployeesForm addempRecord = new AddEmployeesForm();
            addempRecord.MdiParent = this;
            addempRecord.Show();
        }

        


    }
}