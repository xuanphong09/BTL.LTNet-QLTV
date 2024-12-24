using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace home
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int otp;
        private string maNV = "";

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
           btnCheck.Visible = false;
           txtOtp.Enabled = false;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                string email = txtEmail.Text;
                DatabaseConnection db = new DatabaseConnection();
                db.MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "CheckEmail";
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@Email", email);
                sqlCmd.Connection = db.slqCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Email không tồn tại.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.maNV = reader.GetString(0);

                    //tao ma xac thuc gồm 6 số
                    this.otp = random.Next(100000, 999999);

                    //gui ma xac thuc qua email
                    try
                    {
                        
                        //cấu hình và gửi email thông qua một máy chủ SMTP.
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com")//"smtp.gmail.com": Địa chỉ máy chủ SMTP của Gmail.
                        {
                            Port = 587,
                            Credentials = new NetworkCredential("phong13092005@gmail.com", "zetmhzkkcerfluoj"),
                            EnableSsl = true
                        };


                        MailMessage mail = new MailMessage
                        {
                            From = new MailAddress("phong13092005@gmail.com"),
                            Subject = "Mã xác thực quên mật khẩu", //tiêu đề email
                            Body = "Mã xác thực của bạn là: " + otp, //nội dung email
                            IsBodyHtml = false,

                        };
                        //email người nhận
                        mail.To.Add(txtEmail.Text);

                        // Gửi email qua máy chủ SMTP đã cấu hình.
                        SmtpServer.Send(mail);

                        MessageBox.Show("Mã xác thực đã được gửi đến email của bạn","Hộp thoại",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnCheck.Visible = true;
                        btnSendCode.Visible = false;
                        txtOtp.Enabled = true;
                        txtEmail.Enabled = false;

                    }
                    catch
                    {
                        MessageBox.Show("Gửi mã xác thực không thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                db.DongKetNoi();
            }
            
        }

        private bool FormValidate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                isValid = false;
                err.SetError(txtEmail, "Vui lòng nhập email để lấy lại mật khẩu.");
            }
            return isValid;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string checkOtp = txtOtp.Text.Trim();
            if (checkOtp == otp.ToString())
            {
                this.Close();
                LayLaiMatKhau layLaiMatKhau = new LayLaiMatKhau(maNV);
                layLaiMatKhau.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã xác thực không chính xác.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
