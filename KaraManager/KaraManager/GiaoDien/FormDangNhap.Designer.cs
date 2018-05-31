namespace KaraManager.GiaoDien
{
    partial class FormDangNhap
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbPasswordShow = new System.Windows.Forms.CheckBox();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLoginForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(384, 115);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(262, 22);
            this.txtPass.TabIndex = 0;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(384, 52);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(262, 22);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(245, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 40);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(498, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cbPasswordShow
            // 
            this.cbPasswordShow.AutoSize = true;
            this.cbPasswordShow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordShow.Location = new System.Drawing.Point(384, 166);
            this.cbPasswordShow.Name = "cbPasswordShow";
            this.cbPasswordShow.Size = new System.Drawing.Size(142, 22);
            this.cbPasswordShow.TabIndex = 7;
            this.cbPasswordShow.Text = "Hiển thị mật khẩu";
            this.cbPasswordShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPasswordShow.UseVisualStyleBackColor = true;
            // 
            // pBLogin
            // 
            this.pBLogin.Image = global::KaraManager.Properties.Resources.Login;
            this.pBLogin.Location = new System.Drawing.Point(45, 40);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(152, 148);
            this.pBLogin.TabIndex = 8;
            this.pBLogin.TabStop = false;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Image = global::KaraManager.Properties.Resources.Password;
            this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPassword.Location = new System.Drawing.Point(229, 110);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 29);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Mật Khẩu";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLoginForm
            // 
            this.lbLoginForm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginForm.Image = global::KaraManager.Properties.Resources.User;
            this.lbLoginForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLoginForm.Location = new System.Drawing.Point(229, 40);
            this.lbLoginForm.Name = "lbLoginForm";
            this.lbLoginForm.Size = new System.Drawing.Size(149, 31);
            this.lbLoginForm.TabIndex = 4;
            this.lbLoginForm.Text = "Tên Đăng Nhập";
            this.lbLoginForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 282);
            this.Controls.Add(this.pBLogin);
            this.Controls.Add(this.cbPasswordShow);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLoginForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPass);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbLoginForm;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox cbPasswordShow;
        private System.Windows.Forms.PictureBox pBLogin;

    }
}