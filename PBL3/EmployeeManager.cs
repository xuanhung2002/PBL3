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
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
            GUI();
            CreateDemoEmployee();
            CreateAPictureForShift();
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {
            var btn = (Button)button;
            btn.BackColor = Color.FromArgb(78, 76, 150);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point);

            if (CurrentButton != null && CurrentButton != btn)
            {

                CurrentButton.BackColor = this.BackColor;
                CurrentButton.ForeColor = Color.White;
                CurrentButton.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold, GraphicsUnit.Point);
            }
            CurrentButton = btn;
        }
        DataTable dt = new DataTable();
        
        
        void CreateDemoEmployee()
        {
            dgvEmployee.Width = 1700;
            dgvEmployee.Height = 930;
            dt.Columns.Add("MNV", typeof(string));
            dt.Columns.Add("NameNV", typeof(string));
            dt.Columns.Add("T2S", typeof(Boolean));
            dt.Columns.Add("T2T", typeof(Boolean));
            dt.Columns.Add("T3S", typeof(Boolean));
            dt.Columns.Add("T3T", typeof(Boolean));
            dt.Columns.Add("T4S", typeof(Boolean));
            dt.Columns.Add("T4T", typeof(Boolean));
            dt.Columns.Add("T5S", typeof(Boolean));
            dt.Columns.Add("T5T", typeof(Boolean));
            dt.Columns.Add("T6S", typeof(Boolean));
            dt.Columns.Add("T6T", typeof(Boolean));
            dt.Columns.Add("T7S", typeof(Boolean));
            dt.Columns.Add("T7T", typeof(Boolean));
            dt.Columns.Add("CNS", typeof(Boolean));
            dt.Columns.Add("CNT", typeof(Boolean));
            dt.Rows.Add("101", "NVA", true, false, true, true, true, false, true, true, true, true, false, true, false, true);
            dt.Rows.Add("102", "NVB", true, true, true, true, false, true, true, true, true, true, false, true, false, true);
            dt.Rows.Add("103", "NVC", true, false, true, true, true, true, false, true, true, false, false, true, false, true);
            dt.Rows.Add("104", "NVD", true, true, true, true, true, true, true, true, true, true, false, true, false, true);
            dt.Rows.Add("105", "NVE", true, true, false, true, false, true, true, false, true, true, false, true, false, true);
            dt.Rows.Add("106", "NVF", false, false, true, true, true, true, true, true, true, true, false, true, false, true);
            dt.Rows.Add("107", "NVG", true, true, true, false, true, true, true, false, true, true, false, true, false, true);
            dt.Rows.Add("108", "NVH", true, true, true, true, true, true, true, true, true, true, false, true, false, true);
            dt.Rows.Add("109", "NVI", false, true, false, true, true, false, true, true, false, true, false, true, false, true);
            dt.Rows.Add("110", "NVJ", true, false, true, true, true, true, true, true, true, true, false, true, false, true);
            dt.Rows.Add("111", "NVK", false, true, false, true, false, true, true, true, false, true, false, true, false, true);

        }
        void CreateAPictureForShift()
        {
            Bitmap imgTick = new Bitmap(@"E:\GUI\Icon For GUI\ImgRed.jpg");
            Bitmap imgUnTick = new Bitmap(@"E:\GUI\Icon For GUI\ImgGreen.png");
            DataGridViewImageColumn[] imageCol = new DataGridViewImageColumn[14];
            for(int i = 0; i < 14; i++)
            {
                imageCol[i] = new DataGridViewImageColumn();
                imageCol[i].Width = 90;
            }
            dgvEmployee.Columns.Add("MNV","Mã nhân viên");
            dgvEmployee.Columns.Add("Name","Họ Và tên");
            dgvEmployee.Columns.Add(imageCol[0]);
            dgvEmployee.Columns[1].HeaderText = "Thứ 2 sáng";
            dgvEmployee.Columns.Add(imageCol[1]);
            dgvEmployee.Columns[0].Width = 80;
            dgvEmployee.Columns[2].HeaderText = "Thứ 2 chiều";            
            dgvEmployee.Columns.Add(imageCol[2]);
            dgvEmployee.Columns[3].HeaderText = "Thứ 3 sáng";
            dgvEmployee.Columns.Add(imageCol[3]);
            dgvEmployee.Columns[4].HeaderText = "Thứ 3 chiều";
            dgvEmployee.Columns.Add(imageCol[4]);
            dgvEmployee.Columns[5].HeaderText = "Thứ 4 sáng";
            dgvEmployee.Columns.Add(imageCol[5]);
            dgvEmployee.Columns[6].HeaderText = "Thứ 4 chiều";
            dgvEmployee.Columns.Add(imageCol[6]);
            dgvEmployee.Columns[7].HeaderText = "Thứ 5 sáng";
            dgvEmployee.Columns.Add(imageCol[7]);
            dgvEmployee.Columns[8].HeaderText = "Thứ 5 chiều";
            dgvEmployee.Columns.Add(imageCol[8]);
            dgvEmployee.Columns[9].HeaderText = "Thứ 6 sáng";
            dgvEmployee.Columns.Add(imageCol[9]);
            dgvEmployee.Columns[10].HeaderText = "Thứ 6 chiều";
            dgvEmployee.Columns.Add(imageCol[10]);
            dgvEmployee.Columns[11].HeaderText = "Thứ 7 sáng";
            dgvEmployee.Columns.Add(imageCol[11]);
            dgvEmployee.Columns[12].HeaderText = "Thứ 7 chiều";
            dgvEmployee.Columns.Add(imageCol[12]);
            dgvEmployee.Columns[13].HeaderText = "Chủ nhật sáng";
            dgvEmployee.Columns.Add(imageCol[13]);
            dgvEmployee.Columns[14].HeaderText = "Chủ nhật chiều";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvEmployee.Rows.Add();
                for (int j = 2; j < 16; j++)
                {
                    dgvEmployee.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvEmployee.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    if (dt.Rows[i][j].Equals(true))
                    {
                        dgvEmployee.Rows[i].Cells[j].Value = imgTick;
                    }
                    else if (dt.Rows[i][j].Equals(false))
                    {
                        dgvEmployee.Rows[i].Cells[j].Value = imgUnTick;
                    }
                }
            }
        }
        void GUI()
        {
            DateTime now = new DateTime();
            now =DateTime.Now;
            now;
            lbDayAfter.Text = now.ToString();
            lbDayBefore.Text = now.ToString();
        }

        private void btnShowDSNV_Click(object sender, EventArgs e)
        {
            dgvEmployee.Show();
            
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoicalam_Click(object sender, EventArgs e)
        {

        }
    }
}
