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
    public partial class ThemMoiPhieuPhat : Form
    {
        public ThemMoiPhieuPhat()
        {
            InitializeComponent();
        }

        private string MaNV;
        private string MaDG;

        //hàm set mã nhân viên và mã độc giả
        public void SetMaNV(string maNV)
        {
            this.MaNV = maNV;
        }
        public void SetMaDG(string maDG)
        {
            this.MaDG = maDG;
        }

        //hàm load form
        private void ThemMoiPhieuPhat_Load(object sender, EventArgs e)
        {
            txtSoPPhat.Text = SetSoPP();
            txtMaNV.Text = MaNV;
            txtMaDG.Text = MaDG;
        }

        //hàm set số phiếu phạt tự động
        private string SetSoPP()
        {
            string newSoPP = "";

            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 SoPhieuPhat from PhieuPhat order by SoPhieuPhat desc";
            sqlCmd.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                string soPM = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "PP")
                string number = soPM.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newSoPP = "PP" + num.ToString("D3");

            }
            else
            {
                newSoPP = "PP001";
            }
            reader.Close();
            dbCon.DongKetNoi();

            return newSoPP;
        }

        //nút thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                dbCon.MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into PhieuPhat values(@soPP, @maDG, @lyDoPhat, @hinhThucXL, @ngayPhat, @maNV)";
                sqlCmd.Parameters.AddWithValue("@soPP", txtSoPPhat.Text);
                sqlCmd.Parameters.AddWithValue("@maDG", txtMaDG.Text);
                sqlCmd.Parameters.AddWithValue("@lyDoPhat", txtLyDo.Text);
                sqlCmd.Parameters.AddWithValue("@hinhThucXL", txtHinhThucXL.Text);
                string dt = dtpNgayPhat.Value.Year + "-" + dtpNgayPhat.Value.Month + "-" + dtpNgayPhat.Value.Day;
                sqlCmd.Parameters.AddWithValue("@ngayPhat", dt);
                sqlCmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);

                sqlCmd.Connection = dbCon.slqCon;
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm mới phiếu phạt thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới phiếu phạt thất bại");
                }
                dbCon.DongKetNoi();
            }
        }

        //validate thông tin
        private bool FormValidate()
        {
            bool isvalid = true;

            if (string.IsNullOrEmpty(txtLyDo.Text))
            {
                isvalid = false;
                err.SetError(txtLyDo, "Vui lòng nhập lý do phạt");
            }
            else
            {
                err.SetError(txtLyDo, "");
            }
            
            
            if (string.IsNullOrEmpty(txtHinhThucXL.Text))
            {
                isvalid = false;
                err.SetError(txtHinhThucXL, "Vui lòng nhập hình thức xử lý");
            }
            else
            {
                err.SetError(txtHinhThucXL, "");
            }

            return isvalid;
        }
    }
}
