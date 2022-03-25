namespace PBL3
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(177, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnClose);
            this.gbLogin.Controls.Add(this.btnLogIn);
            this.gbLogin.Controls.Add(this.cbRemember);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Location = new System.Drawing.Point(273, 124);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(390, 253);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Thông tin đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(111, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbRemember.Location = new System.Drawing.Point(111, 142);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(169, 20);
            this.cbRemember.TabIndex = 4;
            this.cbRemember.Text = "Lưu thông tin đăng nhập";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogIn.Location = new System.Drawing.Point(111, 196);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(96, 35);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(236, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 410);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 457);
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

