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
    public partial class DoiMatKhauAdmin : Form
    {
        public DoiMatKhauAdmin()
        {
            InitializeComponent();
        }
        //khai bao bien
        public string maNV;
        public string userName;

        private void DoiMatKhauAdmin_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Nhập mật khẩu mới cho tài khoản: " + userName;
            txtNewPass.Focus();
        }

        private void btnOK(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                dbCon.MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "[changePassAdmin]";
                sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                sqlCmd.Parameters.AddWithValue("@pass", txtNewPass.Text.Trim());
                sqlCmd.Connection = dbCon.slqCon;
                int count = (int)sqlCmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
                dbCon.DongKetNoi();
            }
            
        }

        private bool FormValidate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtNewPass.Text.Trim()))
            {
                txtNewPass.Focus();
                err.SetError(txtNewPass, "Mật khẩu không được để trống");
                isValid = false;
            }
            else if (txtNewPass.Text.Trim().Contains(" "))
            {
                isValid = false;
                err.SetError(txtNewPass, "Mật khẩu không được chứa khoảng trắng.");
                txtNewPass.Focus();
            }
            else if (txtNewPass.Text.Trim().Length < 8)
            {
                txtNewPass.Focus();
                err.SetError(txtNewPass, "Mật khẩu phải có ít nhất 8 ký tự");
                isValid = false;
            }
            else
            {
                err.SetError(txtNewPass, "");
            }
            return isValid;
        }
    }
}
