namespace PBL3
{
    partial class EmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoicalam = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnShowDSNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn3week = new System.Windows.Forms.Button();
            this.btn2week = new System.Windows.Forms.Button();
            this.btn1week = new System.Windows.Forms.Button();
            this.lbDayAfter = new System.Windows.Forms.Label();
            this.lbDayBefore = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnDoicalam);
            this.panel1.Controls.Add(this.btnXoaNV);
            this.panel1.Controls.Add(this.btnThemNV);
            this.panel1.Controls.Add(this.btnShowDSNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 933);
            this.panel1.TabIndex = 0;
            // 
            // btnDoicalam
            // 
            this.btnDoicalam.BackColor = System.Drawing.Color.White;
            this.btnDoicalam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoicalam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDoicalam.Image = global::PBL3.Properties.Resources.icons8_settings_64;
            this.btnDoicalam.Location = new System.Drawing.Point(0, 333);
            this.btnDoicalam.Name = "btnDoicalam";
            this.btnDoicalam.Size = new System.Drawing.Size(123, 111);
            this.btnDoicalam.TabIndex = 3;
            this.btnDoicalam.UseVisualStyleBackColor = false;
            this.btnDoicalam.Click += new System.EventHandler(this.btnDoicalam_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.White;
            this.btnXoaNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaNV.Image = global::PBL3.Properties.Resources.icons8_denied_96;
            this.btnXoaNV.Location = new System.Drawing.Point(0, 222);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(123, 111);
            this.btnXoaNV.TabIndex = 2;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.White;
            this.btnThemNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemNV.Image = global::PBL3.Properties.Resources.icons8_add_user_group_man_man_96;
            this.btnThemNV.Location = new System.Drawing.Point(0, 111);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(123, 111);
            this.btnThemNV.TabIndex = 1;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnShowDSNV
            // 
            this.btnShowDSNV.BackColor = System.Drawing.Color.White;
            this.btnShowDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowDSNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowDSNV.Image = global::PBL3.Properties.Resources.icons8_person_64;
            this.btnShowDSNV.Location = new System.Drawing.Point(0, 0);
            this.btnShowDSNV.Name = "btnShowDSNV";
            this.btnShowDSNV.Size = new System.Drawing.Size(123, 111);
            this.btnShowDSNV.TabIndex = 0;
            this.btnShowDSNV.UseVisualStyleBackColor = false;
            this.btnShowDSNV.Click += new System.EventHandler(this.btnShowDSNV_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.btn3week);
            this.panel2.Controls.Add(this.btn2week);
            this.panel2.Controls.Add(this.btn1week);
            this.panel2.Controls.Add(this.lbDayAfter);
            this.panel2.Controls.Add(this.lbDayBefore);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 100);
            this.panel2.TabIndex = 1;
            // 
            // btn3week
            // 
            this.btn3week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3week.Location = new System.Drawing.Point(1368, 12);
            this.btn3week.Name = "btn3week";
            this.btn3week.Size = new System.Drawing.Size(170, 69);
            this.btn3week.TabIndex = 7;
            this.btn3week.Text = "3 Tuần trước";
            this.btn3week.UseVisualStyleBackColor = true;
            // 
            // btn2week
            // 
            this.btn2week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2week.Location = new System.Drawing.Point(1544, 12);
            this.btn2week.Name = "btn2week";
            this.btn2week.Size = new System.Drawing.Size(170, 69);
            this.btn2week.TabIndex = 6;
            this.btn2week.Text = "2 Tuần trước";
            this.btn2week.UseVisualStyleBackColor = true;
            // 
            // btn1week
            // 
            this.btn1week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1week.Location = new System.Drawing.Point(1720, 12);
            this.btn1week.Name = "btn1week";
            this.btn1week.Size = new System.Drawing.Size(170, 69);
            this.btn1week.TabIndex = 5;
            this.btn1week.Text = "1 Tuần trước";
            this.btn1week.UseVisualStyleBackColor = true;
            // 
            // lbDayAfter
            // 
            this.lbDayAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDayAfter.AutoSize = true;
            this.lbDayAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDayAfter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.lbDayAfter.Location = new System.Drawing.Point(1193, 31);
            this.lbDayAfter.Name = "lbDayAfter";
            this.lbDayAfter.Size = new System.Drawing.Size(106, 34);
            this.lbDayAfter.TabIndex = 4;
            this.lbDayAfter.Text = "lb-7day";
            // 
            // lbDayBefore
            // 
            this.lbDayBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDayBefore.AutoSize = true;
            this.lbDayBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDayBefore.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.lbDayBefore.Location = new System.Drawing.Point(996, 31);
            this.lbDayBefore.Name = "lbDayBefore";
            this.lbDayBefore.Size = new System.Drawing.Size(106, 34);
            this.lbDayBefore.TabIndex = 3;
            this.lbDayBefore.Text = "lb-7day";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1902, 436);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.dgvEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1902, 1033);
            this.panel4.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(120, 100);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1782, 933);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManager";
            this.Text = "EmployeeManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnShowDSNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnDoicalam;
        private System.Windows.Forms.Button btn3week;
        private System.Windows.Forms.Button btn2week;
        private System.Windows.Forms.Button btn1week;
        private System.Windows.Forms.Label lbDayAfter;
        private System.Windows.Forms.Label lbDayBefore;
    }
}