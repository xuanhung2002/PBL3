using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = Color.FromArgb(254, 82, 0);//tạo màu nền cho btn
            btn.ForeColor = Color.White;//tạo màu chữ cho btn
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {

                CurrentButton.BackColor = Color.FromArgb(112, 216, 255);
                CurrentButton.ForeColor = Color.Black;
            }
            CurrentButton = btn;
        }
        EmployeeManager EmployeeForm = new EmployeeManager();
        inventoryManageForm InventorymanagerForm = new inventoryManageForm();
        DataBackup DatabackupForm = new DataBackup();
        SalesStatistics SalestatisticsForm = new SalesStatistics();
        OverView OverviewForm = new OverView();
        Report ReportForm = new Report();
        SupportForUsers SupportforusersForm = new SupportForUsers();
        private int CurrentTabPageIndex = 0;
        private void Main_Load(object sender, EventArgs e)
        {

            SetupForm(EmployeeForm);
            SetupForm(InventorymanagerForm);
            SetupForm(DatabackupForm);
            SetupForm(SalestatisticsForm);
            SetupForm(ReportForm);
            SetupForm(OverviewForm);
            SetupForm(SupportforusersForm);

            tabTongQuan.Controls.Add(OverviewForm);
            tabSaoLuu.Controls.Add(DatabackupForm);
            tabBaoCao.Controls.Add(ReportForm);
            tabThongKe.Controls.Add(SalestatisticsForm);
            TabNhanVien.Controls.Add(EmployeeForm);
            tabKho.Controls.Add(InventorymanagerForm);
            tabTroGiup.Controls.Add(SupportforusersForm);
            LoadForm(tabTongQuan, OverviewForm);
            LoadForm(tabBaoCao, ReportForm);
            LoadForm(tabKho, InventorymanagerForm);
            LoadForm(TabNhanVien, EmployeeForm);
            LoadForm(tabThongKe, SalestatisticsForm);
            LoadForm(tabSaoLuu, DatabackupForm);
            LoadForm(tabTroGiup, SupportforusersForm);
        }
        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            GUI();
        }
        void GUI()
        {

        }
        private void LoadForm(TabPage tab, Form form)
        {
            tab.Show();
            form.Show();
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnTongQuan);
            //LoadForm(tabTongQuan, OverviewForm);
            tabMain.SelectedTab = tabTongQuan;
            CurrentTabPageIndex = 0;
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnBaoCao);
            //LoadForm(tabBaoCao, ReportForm);
            tabMain.SelectedTab = tabBaoCao;
            CurrentTabPageIndex = 1;
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnKho);
            //LoadForm(tabKho, InventorymanagerForm);
            tabMain.SelectedTab = tabKho;
            CurrentTabPageIndex = 2;
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnNhanVien);
            //LoadForm(TabNhanVien, EmployeeForm);
            tabMain.SelectedTab = TabNhanVien;
            CurrentTabPageIndex = 3;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnThongKe);
            //LoadForm(tabThongKe, SalestatisticsForm);
            tabMain.SelectedTab = tabThongKe;
            CurrentTabPageIndex = 4;
        }
        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnSaoLuu);
            //LoadForm(tabSaoLuu, DatabackupForm);
            tabMain.SelectedTab = tabSaoLuu;
            CurrentTabPageIndex = 5;
        }
        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnTroGiup);
            //LoadForm(tabTroGiup,SupportforusersForm);
            tabMain.SelectedTab = tabTroGiup;
            CurrentTabPageIndex = 6;
        }
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form frm = new Form();
            if (tabMain.SelectedIndex == 0)
            {
                frm = OverviewForm;
            }
            else
                if (tabMain.SelectedIndex == 1)
            {
                frm = ReportForm;
            }
            else if (tabMain.SelectedIndex == 2)
            {
                frm = InventorymanagerForm;
            }
            else if (tabMain.SelectedIndex == 3)
            {
                frm = EmployeeForm;
            }
            else if (tabMain.SelectedIndex == 4)
            {
                frm = SalestatisticsForm;
            }
            else if (tabMain.SelectedIndex == 5)
            {
                frm = DatabackupForm;
            }
            else if (tabMain.SelectedIndex == 6)
            {
                frm = SupportforusersForm;
            }
            LoadForm(tabMain.SelectedTab, frm);
        }
    }
}
