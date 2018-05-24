namespace ProCUI
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtLogname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLogpwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(60, 72);
            this.labelX1.Margin = new System.Windows.Forms.Padding(6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(140, 60);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "用户名：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(60, 178);
            this.labelX2.Margin = new System.Windows.Forms.Padding(6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 60);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "密  码：";
            // 
            // txtLogname
            // 
            this.txtLogname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLogname.Border.Class = "TextBoxBorder";
            this.txtLogname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLogname.DisabledBackColor = System.Drawing.Color.White;
            this.txtLogname.ForeColor = System.Drawing.Color.Black;
            this.txtLogname.Location = new System.Drawing.Point(182, 80);
            this.txtLogname.Margin = new System.Windows.Forms.Padding(6);
            this.txtLogname.Name = "txtLogname";
            this.txtLogname.PreventEnterBeep = true;
            this.txtLogname.Size = new System.Drawing.Size(418, 35);
            this.txtLogname.TabIndex = 2;
            this.txtLogname.Text = "xijialin";
            this.txtLogname.WatermarkText = "请输入登录用户名/手机号码/邮箱";
            this.txtLogname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxX1_KeyDown);
            // 
            // txtLogpwd
            // 
            this.txtLogpwd.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLogpwd.Border.Class = "TextBoxBorder";
            this.txtLogpwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLogpwd.DisabledBackColor = System.Drawing.Color.White;
            this.txtLogpwd.ForeColor = System.Drawing.Color.Black;
            this.txtLogpwd.Location = new System.Drawing.Point(182, 186);
            this.txtLogpwd.Margin = new System.Windows.Forms.Padding(6);
            this.txtLogpwd.Name = "txtLogpwd";
            this.txtLogpwd.PasswordChar = '*';
            this.txtLogpwd.PreventEnterBeep = true;
            this.txtLogpwd.Size = new System.Drawing.Size(418, 35);
            this.txtLogpwd.TabIndex = 3;
            this.txtLogpwd.Text = "xijialin123";
            this.txtLogpwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxX2_KeyDown);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(450, 264);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(150, 46);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "登  录";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(310, 266);
            this.labelX3.Margin = new System.Windows.Forms.Padding(6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(122, 46);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "忘记密码";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            this.labelX3.MouseEnter += new System.EventHandler(this.labelX3_MouseEnter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 316);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtLogpwd);
            this.Controls.Add(this.txtLogname);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLogname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLogpwd;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}

