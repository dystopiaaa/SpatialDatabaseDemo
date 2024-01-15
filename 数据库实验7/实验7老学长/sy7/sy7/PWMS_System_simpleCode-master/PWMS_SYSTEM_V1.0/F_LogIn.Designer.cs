namespace PWMS_SYSTEM_V1._0
{
    partial class F_LogIn
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butLogIn = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butLogIn
            // 
            this.butLogIn.Location = new System.Drawing.Point(136, 243);
            this.butLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(100, 29);
            this.butLogIn.TabIndex = 0;
            this.butLogIn.Text = "LogIn";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(287, 243);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(100, 29);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Cancel";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(191, 118);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(176, 25);
            this.textName.TabIndex = 4;
            // 
            // textPass
            // 
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPass.Location = new System.Drawing.Point(191, 165);
            this.textPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(176, 25);
            this.textPass.TabIndex = 5;
            // 
            // F_LogIn
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PWMS_SYSTEM_V1._0.Properties.Resources.登录界面1;
            this.ClientSize = new System.Drawing.Size(517, 334);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Activated += new System.EventHandler(this.F_LogIn_Activated);
            this.Load += new System.EventHandler(this.F_LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPass;
    }
}

