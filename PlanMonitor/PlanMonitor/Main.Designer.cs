namespace Monitor
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_captchacode = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_captchacode = new System.Windows.Forms.TextBox();
            this.pic_captchacode = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_logmessage = new System.Windows.Forms.TextBox();
            this.gb_logmessage = new System.Windows.Forms.GroupBox();
            this.gp_login = new System.Windows.Forms.GroupBox();
            this.lbl_loginurl = new System.Windows.Forms.Label();
            this.txt_loginurl = new System.Windows.Forms.TextBox();
            this.sts_message = new System.Windows.Forms.StatusStrip();
            this.sts_lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.mst_menu = new System.Windows.Forms.MenuStrip();
            this.tsm_settings = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic_captchacode)).BeginInit();
            this.gb_logmessage.SuspendLayout();
            this.gp_login.SuspendLayout();
            this.sts_message.SuspendLayout();
            this.mst_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(17, 90);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(62, 18);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "用户名";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(262, 87);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 18);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "密 码";
            // 
            // lbl_captchacode
            // 
            this.lbl_captchacode.AutoSize = true;
            this.lbl_captchacode.Location = new System.Drawing.Point(17, 136);
            this.lbl_captchacode.Name = "lbl_captchacode";
            this.lbl_captchacode.Size = new System.Drawing.Size(62, 18);
            this.lbl_captchacode.TabIndex = 2;
            this.lbl_captchacode.Text = "验证码";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(92, 84);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(162, 28);
            this.txt_username.TabIndex = 3;
            this.txt_username.Text = "wangjackie";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(328, 84);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(162, 28);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "86liu5229147678j";
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_captchacode
            // 
            this.txt_captchacode.Location = new System.Drawing.Point(92, 133);
            this.txt_captchacode.Name = "txt_captchacode";
            this.txt_captchacode.Size = new System.Drawing.Size(162, 28);
            this.txt_captchacode.TabIndex = 3;
            // 
            // pic_captchacode
            // 
            this.pic_captchacode.Location = new System.Drawing.Point(274, 133);
            this.pic_captchacode.Name = "pic_captchacode";
            this.pic_captchacode.Size = new System.Drawing.Size(98, 28);
            this.pic_captchacode.TabIndex = 4;
            this.pic_captchacode.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(203, 183);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 41);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "运行";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_logmessage
            // 
            this.txt_logmessage.Location = new System.Drawing.Point(6, 27);
            this.txt_logmessage.Multiline = true;
            this.txt_logmessage.Name = "txt_logmessage";
            this.txt_logmessage.Size = new System.Drawing.Size(503, 167);
            this.txt_logmessage.TabIndex = 6;
            // 
            // gb_logmessage
            // 
            this.gb_logmessage.Controls.Add(this.txt_logmessage);
            this.gb_logmessage.Location = new System.Drawing.Point(14, 313);
            this.gb_logmessage.Name = "gb_logmessage";
            this.gb_logmessage.Size = new System.Drawing.Size(515, 200);
            this.gb_logmessage.TabIndex = 7;
            this.gb_logmessage.TabStop = false;
            this.gb_logmessage.Text = "运行日志";
            // 
            // gp_login
            // 
            this.gp_login.Controls.Add(this.txt_loginurl);
            this.gp_login.Controls.Add(this.lbl_loginurl);
            this.gp_login.Controls.Add(this.lbl_password);
            this.gp_login.Controls.Add(this.btn_login);
            this.gp_login.Controls.Add(this.lbl_username);
            this.gp_login.Controls.Add(this.pic_captchacode);
            this.gp_login.Controls.Add(this.lbl_captchacode);
            this.gp_login.Controls.Add(this.txt_captchacode);
            this.gp_login.Controls.Add(this.txt_username);
            this.gp_login.Controls.Add(this.txt_password);
            this.gp_login.Location = new System.Drawing.Point(12, 48);
            this.gp_login.Name = "gp_login";
            this.gp_login.Size = new System.Drawing.Size(509, 248);
            this.gp_login.TabIndex = 8;
            this.gp_login.TabStop = false;
            this.gp_login.Text = "登录";
            // 
            // lbl_loginurl
            // 
            this.lbl_loginurl.AutoSize = true;
            this.lbl_loginurl.Location = new System.Drawing.Point(33, 41);
            this.lbl_loginurl.Name = "lbl_loginurl";
            this.lbl_loginurl.Size = new System.Drawing.Size(53, 18);
            this.lbl_loginurl.TabIndex = 6;
            this.lbl_loginurl.Text = "网 址";
            // 
            // txt_loginurl
            // 
            this.txt_loginurl.Location = new System.Drawing.Point(92, 36);
            this.txt_loginurl.Name = "txt_loginurl";
            this.txt_loginurl.Size = new System.Drawing.Size(399, 28);
            this.txt_loginurl.TabIndex = 7;
            this.txt_loginurl.Text = "https://123.jn700.com/Login";
            // 
            // sts_message
            // 
            this.sts_message.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sts_message.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sts_lbl_message});
            this.sts_message.Location = new System.Drawing.Point(0, 534);
            this.sts_message.Name = "sts_message";
            this.sts_message.Size = new System.Drawing.Size(541, 29);
            this.sts_message.TabIndex = 9;
            // 
            // sts_lbl_message
            // 
            this.sts_lbl_message.Name = "sts_lbl_message";
            this.sts_lbl_message.Size = new System.Drawing.Size(46, 24);
            this.sts_lbl_message.Text = "消息";
            // 
            // mst_menu
            // 
            this.mst_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mst_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_settings});
            this.mst_menu.Location = new System.Drawing.Point(0, 0);
            this.mst_menu.Name = "mst_menu";
            this.mst_menu.Size = new System.Drawing.Size(541, 32);
            this.mst_menu.TabIndex = 10;
            this.mst_menu.Text = "menuStrip1";
            // 
            // tsm_settings
            // 
            this.tsm_settings.Name = "tsm_settings";
            this.tsm_settings.Size = new System.Drawing.Size(94, 28);
            this.tsm_settings.Text = "系统设置";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 563);
            this.Controls.Add(this.sts_message);
            this.Controls.Add(this.mst_menu);
            this.Controls.Add(this.gp_login);
            this.Controls.Add(this.gb_logmessage);
            this.MainMenuStrip = this.mst_menu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_captchacode)).EndInit();
            this.gb_logmessage.ResumeLayout(false);
            this.gb_logmessage.PerformLayout();
            this.gp_login.ResumeLayout(false);
            this.gp_login.PerformLayout();
            this.sts_message.ResumeLayout(false);
            this.sts_message.PerformLayout();
            this.mst_menu.ResumeLayout(false);
            this.mst_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_captchacode;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_captchacode;
        private System.Windows.Forms.PictureBox pic_captchacode;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_logmessage;
        private System.Windows.Forms.GroupBox gb_logmessage;
        private System.Windows.Forms.GroupBox gp_login;
        private System.Windows.Forms.TextBox txt_loginurl;
        private System.Windows.Forms.Label lbl_loginurl;
        private System.Windows.Forms.StatusStrip sts_message;
        private System.Windows.Forms.ToolStripStatusLabel sts_lbl_message;
        private System.Windows.Forms.MenuStrip mst_menu;
        private System.Windows.Forms.ToolStripMenuItem tsm_settings;
    }
}

