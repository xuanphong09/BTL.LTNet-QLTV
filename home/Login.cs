using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace home
{
    public partial class Login : Form
    {
        //khai bao bien
        string role = "";
        int state;
        string maNV = "";
        private bool isOldPassVisible=false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                //xoa ma nhan vien
                maNV = "";
                role = "";
                //tao doi tuong ket noi
                DatabaseConnection dbConnection = new DatabaseConnection();
                dbConnection.MoKetNoi();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "[checkLoginUsername]";
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmd.Connection = dbConnection.slqCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();


                if (reader.Read())
                {
                    maNV = reader.GetString(0);
                }
                reader.Close();

                if (maNV == "")
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else
                {
                    //check mật khẩu và lấy chức vụ của tài khoản
                    sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "[checkLoginPassword]";
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                    sqlCmd.Connection = dbConnection.slqCon;

                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        role = reader.GetString(0);
                    }
                    reader.Close();

                    //lấy trạng thái của tài khoản
                    sqlCmd.CommandText = "[getStateAccount]";
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                    sqlCmd.Connection = dbConnection.slqCon;
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        state = reader.GetInt32(0);
                    }
                    reader.Close();

                    if (role == "")
                    {
                        if (state < 7)
                        {
                            state++;
                        }
                        else
                        {
                            state = -1;
                        }

                        if (state <= 3)
                        {
                            if (state == -1)
                            {
                                MessageBox.Show("Tài khoản đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsername.Focus();
                            }
                            else if (state == -2)
                            {
                                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsername.Focus();
                            }
                            else
                                MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác. Bạn đã nhập sai " + (state - 3) + " lần. Tài khoản sẽ bị TẠM KHÓA sau 5 lần nhập sai liên tiếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        txtPassword.Clear();
                        txtPassword.Focus();


                    }
                    else
                    {
                        if (state == -1)
                        {
                            MessageBox.Show("Tài khoản đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                        }
                        else
                        {
                            state = 0;
                            txtUsername.Clear();
                            txtPassword.Clear();
                            Form1 chuongTrinhChinh = new Form1();
                            chuongTrinhChinh.SetRole(role);
                            chuongTrinhChinh.setMaNV(maNV);
                            chuongTrinhChinh.Show();
                            this.Hide();
                        }

                    }

                    sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "[updateState]";
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@state", state);
                    sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                    sqlCmd.Connection = dbConnection.slqCon;
                    sqlCmd.ExecuteNonQuery();

                    dbConnection.DongKetNoi();
                }
            }

        }

        private bool FormValidate()
        {
            bool isValid = true;
            //xác thực tên đăng nhập
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                isValid = false;
                txtUsername.Focus();
                err.SetError(txtUsername, "Vui lòng nhập tên đăng nhập.");
            }
            else
            {
                err.SetError(txtUsername, null);
            }

            //xác thực mật khẩu
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                isValid = false;
                txtPassword.Focus();
                err.SetError(txtPassword, "Vui lòng nhập mật khẩu.");
            }
            else
            {
                err.SetError(txtPassword, null);
            }

            return isValid;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void ptbPass_Click(object sender, EventArgs e)
        {
            if(isOldPassVisible)
            {
                ptbPass.Image = Properties.Resources.eye_slash_fill;
                isOldPassVisible = false;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                ptbPass.Image = Properties.Resources.eye_fill;
                isOldPassVisible = true;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Show();
        }
    }
}
