namespace PBL3
{
    partial class inventoryManageForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabControlNguyenLieu = new System.Windows.Forms.TabControl();
            this.tabTonKhoNguyenLieu = new System.Windows.Forms.TabPage();
            this.tabNhatKyNhapKho = new System.Windows.Forms.TabPage();
            this.tabNhatKyXuatKho = new System.Windows.Forms.TabPage();
            this.dgvTonKhoNguyenLieu = new System.Windows.Forms.DataGridView();
            this.dgvNhatKyNhapKho = new System.Windows.Forms.DataGridView();
            this.dgvNhatKyXuatKho = new System.Windows.Forms.DataGridView();
            this.TabControlNguyenLieu.SuspendLayout();
            this.tabTonKhoNguyenLieu.SuspendLayout();
            this.tabNhatKyNhapKho.SuspendLayout();
            this.tabNhatKyXuatKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKhoNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1924, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất kho thanh lý";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TabControlNguyenLieu
            // 
            this.TabControlNguyenLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.TabControlNguyenLieu.Controls.Add(this.tabTonKhoNguyenLieu);
            this.TabControlNguyenLieu.Controls.Add(this.tabNhatKyNhapKho);
            this.TabControlNguyenLieu.Controls.Add(this.tabNhatKyXuatKho);
            this.TabControlNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlNguyenLieu.Location = new System.Drawing.Point(0, 290);
            this.TabControlNguyenLieu.Name = "TabControlNguyenLieu";
            this.TabControlNguyenLieu.SelectedIndex = 0;
            this.TabControlNguyenLieu.Size = new System.Drawing.Size(1924, 765);
            this.TabControlNguyenLieu.TabIndex = 3;
            // 
            // tabTonKhoNguyenLieu
            // 
            this.tabTonKhoNguyenLieu.Controls.Add(this.dgvTonKhoNguyenLieu);
            this.tabTonKhoNguyenLieu.Location = new System.Drawing.Point(4, 27);
            this.tabTonKhoNguyenLieu.Name = "tabTonKhoNguyenLieu";
            this.tabTonKhoNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKhoNguyenLieu.Size = new System.Drawing.Size(1916, 734);
            this.tabTonKhoNguyenLieu.TabIndex = 0;
            this.tabTonKhoNguyenLieu.Text = "Tồn kho nguyên liệu";
            this.tabTonKhoNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // tabNhatKyNhapKho
            // 
            this.tabNhatKyNhapKho.Controls.Add(this.dgvNhatKyNhapKho);
            this.tabNhatKyNhapKho.Location = new System.Drawing.Point(4, 27);
            this.tabNhatKyNhapKho.Name = "tabNhatKyNhapKho";
            this.tabNhatKyNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhatKyNhapKho.Size = new System.Drawing.Size(1916, 734);
            this.tabNhatKyNhapKho.TabIndex = 1;
            this.tabNhatKyNhapKho.Text = "Nhật ký nhập kho";
            this.tabNhatKyNhapKho.UseVisualStyleBackColor = true;
            // 
            // tabNhatKyXuatKho
            // 
            this.tabNhatKyXuatKho.Controls.Add(this.dgvNhatKyXuatKho);
            this.tabNhatKyXuatKho.Location = new System.Drawing.Point(4, 27);
            this.tabNhatKyXuatKho.Name = "tabNhatKyXuatKho";
            this.tabNhatKyXuatKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhatKyXuatKho.Size = new System.Drawing.Size(1916, 734);
            this.tabNhatKyXuatKho.TabIndex = 2;
            this.tabNhatKyXuatKho.Text = "Nhật ký xuất kho";
            this.tabNhatKyXuatKho.UseVisualStyleBackColor = true;
            // 
            // dgvTonKhoNguyenLieu
            // 
            this.dgvTonKhoNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKhoNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKhoNguyenLieu.Location = new System.Drawing.Point(3, 3);
            this.dgvTonKhoNguyenLieu.Name = "dgvTonKhoNguyenLieu";
            this.dgvTonKhoNguyenLieu.RowHeadersWidth = 51;
            this.dgvTonKhoNguyenLieu.RowTemplate.Height = 24;
            this.dgvTonKhoNguyenLieu.Size = new System.Drawing.Size(1910, 728);
            this.dgvTonKhoNguyenLieu.TabIndex = 0;
            // 
            // dgvNhatKyNhapKho
            // 
            this.dgvNhatKyNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKyNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKyNhapKho.Location = new System.Drawing.Point(3, 3);
            this.dgvNhatKyNhapKho.Name = "dgvNhatKyNhapKho";
            this.dgvNhatKyNhapKho.RowHeadersWidth = 51;
            this.dgvNhatKyNhapKho.RowTemplate.Height = 24;
            this.dgvNhatKyNhapKho.Size = new System.Drawing.Size(1910, 728);
            this.dgvNhatKyNhapKho.TabIndex = 0;
            // 
            // dgvNhatKyXuatKho
            // 
            this.dgvNhatKyXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKyXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKyXuatKho.Location = new System.Drawing.Point(3, 3);
            this.dgvNhatKyXuatKho.Name = "dgvNhatKyXuatKho";
            this.dgvNhatKyXuatKho.RowHeadersWidth = 51;
            this.dgvNhatKyXuatKho.RowTemplate.Height = 24;
            this.dgvNhatKyXuatKho.Size = new System.Drawing.Size(1910, 728);
            this.dgvNhatKyXuatKho.TabIndex = 1;
            // 
            // inventoryManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.TabControlNguyenLieu);
            this.Controls.Add(this.groupBox1);
            this.Name = "inventoryManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryManageForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TabControlNguyenLieu.ResumeLayout(false);
            this.tabTonKhoNguyenLieu.ResumeLayout(false);
            this.tabNhatKyNhapKho.ResumeLayout(false);
            this.tabNhatKyXuatKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKhoNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl TabControlNguyenLieu;
        private System.Windows.Forms.TabPage tabTonKhoNguyenLieu;
        private System.Windows.Forms.TabPage tabNhatKyNhapKho;
        private System.Windows.Forms.TabPage tabNhatKyXuatKho;
        private System.Windows.Forms.DataGridView dgvTonKhoNguyenLieu;
        private System.Windows.Forms.DataGridView dgvNhatKyNhapKho;
        private System.Windows.Forms.DataGridView dgvNhatKyXuatKho;
    }
}