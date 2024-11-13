using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class DoiMatKhauUser : Form
    {
        public DoiMatKhauUser()
        {
            InitializeComponent();
        }

        private Form chuongTrinhChinh { get; set; }

        public DoiMatKhauUser(Form ChuongTrinhChinh)
        {
            InitializeComponent();
            this.chuongTrinhChinh = ChuongTrinhChinh;
        }

        private string maNV = "";
        private bool isOldPassVisible = false;
        private bool isNewPassVisible = false;
        private bool isCFPassVisible = false;

        public void setMaNV(string maNV)
        {
            this.maNV = maNV;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate()) {
                DatabaseConnection dbCon = new DatabaseConnection();
                dbCon.MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "[changePassUser]";
                sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                sqlCmd.Parameters.AddWithValue("@oldPass", txtOldPass.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@pass", txtNewPass.Text.Trim());
                sqlCmd.Connection = dbCon.slqCon;
                int count = (int)sqlCmd.ExecuteNonQuery();

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show("Đổi mật khẩu thành công. Bạn có muốn đăng nhập lại không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (chuongTrinhChinh is Form1 mainForm)
                        {
                            mainForm.isThoatDMK = true;
                        }
                        chuongTrinhChinh.Close();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác.", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    txtCFPass.Clear();
                    txtNewPass.Clear();
                    txtOldPass.Clear();
                    txtOldPass.Focus();
                }

                dbCon.DongKetNoi();
            }
        }

        private void ptbNewPass_Click(object sender, EventArgs e)
        {
            if (isNewPassVisible)
            {
                ptbNewPass.Image = Properties.Resources.eye_slash_fill;
                isNewPassVisible = false;
                txtNewPass.UseSystemPasswordChar = true;
            }
            else
            {
                ptbNewPass.Image = Properties.Resources.eye_fill;
                isNewPassVisible = true;
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void ptbCFPass_Click(object sender, EventArgs e)
        {
            if (isCFPassVisible)
            {
                ptbCFPass.Image = Properties.Resources.eye_slash_fill;
                isCFPassVisible = false;
                txtCFPass.UseSystemPasswordChar = true;
            }
            else
            {
                ptbCFPass.Image = Properties.Resources.eye_fill;
                isCFPassVisible = true;
                txtCFPass.UseSystemPasswordChar = false;
            }
        }

        private void ptbOldPass_Click(object sender, EventArgs e)
        {
            if (isOldPassVisible)
            {
                ptbOldPass.Image = Properties.Resources.eye_slash_fill;
                isOldPassVisible = false;
                txtOldPass.UseSystemPasswordChar = true;
            }
            else
            {
                ptbOldPass.Image = Properties.Resources.eye_fill;
                isOldPassVisible = true;
                txtOldPass.UseSystemPasswordChar = false;
            }
        }

        private bool FormValidate()
        {
            bool isValid = true;
            //validate old password
            if (string.IsNullOrEmpty(txtOldPass.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtOldPass, "Vui lòng nhập mật khẩu cũ");
                txtOldPass.Focus();
            }
            else
            {
                err.SetError(txtOldPass, null);
            }

            //validate new password
            if (string.IsNullOrEmpty(txtNewPass.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtNewPass, "Vui lòng nhập mật khẩu mới");
                txtNewPass.Focus();
            }
            else
            {
                err.SetError(txtNewPass, null);
            }

            //validate confirm password
            if (string.IsNullOrEmpty(txtCFPass.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtCFPass, "Vui lòng nhập lại mật khẩu mới");
                txtCFPass.Focus();
            }
            else if (txtCFPass.Text.Trim() != txtNewPass.Text.Trim())
            {
                isValid = false;
                err.SetError(txtCFPass, "Mật khẩu không trùng khớp");
                txtCFPass.Focus();
            }
            else
            {
                err.SetError(txtCFPass, null);
            }

            return isValid;
        }
    }
}
