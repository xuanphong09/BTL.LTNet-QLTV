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
    public partial class LayLaiMatKhau : Form
    {
        public LayLaiMatKhau(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private string maNV = "";
        private bool isCFPassVisible = false;
        private bool isNewPassVisible = false;

        private bool FormValidate()
        {
            bool isValid = true;
            //xac thuc mat khau moi
            if (string.IsNullOrEmpty(txtNewPass.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtNewPass, "Vui lòng nhập mật khẩu mới.");
                txtNewPass.Focus();
            }
            else if (txtNewPass.Text.Length < 8)
            {
                isValid = false;
                err.SetError(txtNewPass, "Mật khẩu phải có ít nhất 8 ký tự.");
                txtNewPass.Focus();
            }
            else if(txtNewPass.Text.Trim().Contains(" "))
            {
                isValid = false;
                err.SetError(txtNewPass, "Mật khẩu không được chứa khoảng trắng.");
                txtNewPass.Focus();
            }
            else
            {
                err.SetError(txtNewPass, null);
            }

            //xac thuc mat khau moi lan 2
            if (string.IsNullOrEmpty(txtCFPass.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtCFPass, "Vui lòng xác nhận mật khẩu mới.");
                txtCFPass.Focus();
            }
            else if (txtCFPass.Text != txtNewPass.Text)
            {
                isValid = false;
                err.SetError(txtCFPass, "Mật khẩu mới không khớp.");
                txtCFPass.Focus();
            }
            else
            {
                err.SetError(txtCFPass, null);
            }

            return isValid;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                dbCon.MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "changePassAdmin";
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@manv", maNV);
                sqlCmd.Parameters.AddWithValue("@pass", txtNewPass.Text.Trim());
                sqlCmd.Connection = dbCon.slqCon;

                int kq = sqlCmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác đổi mật khẩu?", "Hủy thao tác", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //Login login = new Login();
                //login.Show();
            }
        }

        private void LayLaiMatKhau_Load(object sender, EventArgs e)
        {
            txtNewPass.Focus();
        }

    }
}
