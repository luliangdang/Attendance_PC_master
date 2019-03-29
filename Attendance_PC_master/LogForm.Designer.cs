namespace Attendance_PC_master
{
    partial class LogForm
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
            this.bt_regist = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_regist
            // 
            this.bt_regist.Location = new System.Drawing.Point(258, 170);
            this.bt_regist.Name = "bt_regist";
            this.bt_regist.Size = new System.Drawing.Size(75, 23);
            this.bt_regist.TabIndex = 6;
            this.bt_regist.Text = "注册";
            this.bt_regist.UseVisualStyleBackColor = true;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(159, 170);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "登录";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(159, 127);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(174, 21);
            this.tbPasswd.TabIndex = 4;
            this.tbPasswd.UseSystemPasswordChar = true;
            this.tbPasswd.TextChanged += new System.EventHandler(this.TextChangeNum);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(159, 90);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(174, 21);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(114, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lable1.Location = new System.Drawing.Point(100, 93);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(53, 12);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "登录账号";
            // 
            // LogForm
            // 
            this.AcceptButton = this.bt_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Attendance_PC_master.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.bt_regist);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.MaximizeBox = false;
            this.Name = "LogForm";
            this.Text = "智能考勤系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_regist;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
    }
}

