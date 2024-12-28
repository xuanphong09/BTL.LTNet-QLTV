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
    public partial class ChiTietTaiKhoan : Form
    {
        public ChiTietTaiKhoan()
        {
            InitializeComponent();
        }

        DatabaseConnection dbCon = new DatabaseConnection();
        SqlCommand sqlCmd;
        private string maNV = "";

        public void setMaNV(string maNV)
        {
            this.maNV = maNV;
        }

        private void ChiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            panel2.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            panel2.Enabled = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FormValidate())
            {
                dbCon.MoKetNoi();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "[updateDataNhanVien]";
                sqlCmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                sqlCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@work", txtWork.Text);
                sqlCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@note", txtNote.Text);
                sqlCmd.Connection = dbCon.slqCon;
                int count = (int)sqlCmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dbCon.DongKetNoi();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                panel2.Enabled = false;
            }
        }

        private void ChiTietTaiKhoan_Activated(object sender, EventArgs e)
        {
            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "[getItemAccount]";
            sqlCmd.Parameters.AddWithValue("@maNV", this.maNV);
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                txtMaNV.Text = reader.GetString(0);
                txtUsername.Text = reader.GetString(1);
                txtName.Text = reader.GetString(2);
                txtPhone.Text = reader.GetString(3);
                txtEmail.Text = reader.GetString(4);
                txtAddress.Text = reader.GetString(5);
                txtWork.Text = reader.GetString(6);
                txtCreateAt.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy");
                txtNote.Text = reader.GetString(8);
                txtRole.Text = reader.GetString(9);
            }
         
            reader.Close();

            dbCon.DongKetNoi();
        }
           
        private bool FormValidate()
        {
            bool isValid = true;
            //xác thực ho tên
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtName, "Tên nhân viên không được bỏ trống!");
                txtName.Focus();
            }
            else
            {
                err.SetError(txtName, null);
            }

            //xác thực số điện thoại
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không được bỏ trống!");
                txtPhone.Focus();
            }
            else if(!int.TryParse(txtPhone.Text, out int n)){
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không hợp lệ!");
                txtPhone.Focus();
            }
            else if(!txtPhone.Text.Trim().StartsWith("0"))
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại phải bắt đầu từ 0.");
                txtPhone.Focus();
            }
            else if(txtPhone.Text.Trim().Contains(" "))
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không được có khoảng trắng.");
                txtPhone.Focus();
            }
            else if(txtPhone.Text.Length != 10)
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không hợp lệ!");
                txtPhone.Focus();
            }
            else
            {
                err.SetError(txtPhone, null);
            }

            //xác thực email
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtEmail, "Email không được bỏ trống!");
                txtEmail.Focus();
            }
            else if(!txtEmail.Text.Trim().EndsWith("@gmail.com"))
            {
                isValid = false;
                err.SetError(txtEmail, "Email không hợp lệ!");
                txtEmail.Focus();
            }
            else
            {
                err.SetError(txtEmail, null);
            }

            return isValid;
        }
    }
}
