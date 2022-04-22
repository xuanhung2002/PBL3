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
        private void Main_Load(object sender, EventArgs e)
        {
            SetupForm(EmployeeForm);
            SetupForm(InventorymanagerForm);
            SetupForm(DatabackupForm);
            pnIsMDI.Controls.Add(EmployeeForm);
            pnIsMDI.Controls.Add(InventorymanagerForm);
            pnIsMDI.Controls.Add(DatabackupForm);
        }
        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            //pnIsMDI.Controls.Add(form);
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            GUI();
        }
        void GUI()
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnNhanVien);
            
            EmployeeForm.Show();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            SetUIForButton(btnKho);
            
            InventorymanagerForm.Show();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        { 
            SetUIForButton(btnSaoLuu);
            
            DatabackupForm.Show();
        }

        
    }
}
