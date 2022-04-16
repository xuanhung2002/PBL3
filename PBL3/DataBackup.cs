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
    public partial class DataBackup : Form
    {
        public DataBackup()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            DateTime dt = DateTime.Now;
            lblTimeNow.Text = string.Format("{0:MM/dd/yyyy}", dt);
            CreateTable();
            CreateDataGridView();
        }
        DataTable dt = new DataTable();
        private void CreateTable()
        {
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("BackupName", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Status", typeof(bool));
            dt.Rows.Add(1, "Backup-24-03-2022-3:00:01-AM", "24-03-2022-3:00:01-AM", true);
            dt.Rows.Add(2, "Backup-25-03-2022-4:00:01-AM", "25-03-2022-4:00:01-AM", true);
        }
        private void CreateDataGridView()
        {
            dgvDataBackup.Width = 1900;
            dgvDataBackup.Height = 838;
            Bitmap imgCloud = new Bitmap(@"E:\PBL3\PBL3\Image\Icloud.png");
            Button btn = new Button();
            btn.Image = imgCloud;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            dgvDataBackup.Columns.Add("STT", "Số thứ tự");
            dgvDataBackup.Columns.Add("NameBackup", "Tên mục sao lưu");
            dgvDataBackup.Columns.Add("TimeBackup", "Thời gian sao lưu");
            dgvDataBackup.Columns.Add("Status", "Trạng thái");
            dgvDataBackup.Columns[0].Width = 50;
            dgvDataBackup.Columns[1].Width = 400;
            dgvDataBackup.Columns[2].Width = 400;
            dgvDataBackup.Columns[3].Width = 200;
            dgvDataBackup.Columns.Add(button);
            button.Text = "Tải về";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;
            dgvDataBackup.Columns[4].Width = 100;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDataBackup.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dgvDataBackup.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                    if (dt.Rows[i][3].Equals(true))
                    {
                        dgvDataBackup.Rows[i].Cells[3].Value = "Xong";
                        dgvDataBackup.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                    }
                    dgvDataBackup.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
    }
}