using DevComponents.DotNetBar;
using ProCBLL;
using System;
using System.Windows.Forms;

namespace ProCUI
{
    public partial class Login : Office2007Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.EnableGlass = false;
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogpwd.Focus();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (loginBLL.login(txtLogname.Text.Trim(),txtLogpwd.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码或用户名错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void labelX3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.PerformClick();
            }
        }

        private void labelX3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员重置密码！");
        }
    }
}
