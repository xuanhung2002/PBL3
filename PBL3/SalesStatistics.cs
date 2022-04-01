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
    public partial class SalesStatistics : Form
    {
        public SalesStatistics()
        {
            InitializeComponent();
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

        private void btn7day_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void btnCustomOK_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }
    }
}
