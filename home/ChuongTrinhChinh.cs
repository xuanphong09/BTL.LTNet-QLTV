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
    public partial class Form1 : Form
    {
        private bool isThoat = true;
        public bool isThoatDMK = false;
        private string maNV { get; set; } = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        public void SetRole(string role)
        {
            if (role == "admin")
            {

            }
            else if (role == "user")
            {
                tSMIQuanLyTaiKhoan.Visible = false;
            }
        }

        public void setMaNV(string maNV)
        {
            this.maNV = maNV;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat && !isThoatDMK)
            {
                //DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
                //if (dialog == DialogResult.Yes)
                //{
                    Application.Exit();
                //}
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập tài khoản thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MenuItemAccountView_Click(object sender, EventArgs e)
        {
            //tao đối tượng kết nối với cơ sỏ dữ liệu
            //DatabaseConnection dbCon = new DatabaseConnection();
            //dbCon.MoKetNoi();
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = "select * from NhanVien inner join role on nhanvien.role_id=role.role_id";
            //sqlCommand.Connection = dbCon.slqCon;

            //SqlDataReader reader = sqlCommand.ExecuteReader();

            DanhSachTaiKhoan danhSachTaiKhoan = new DanhSachTaiKhoan();
            //danhSachTaiKhoan.reader = reader;
            danhSachTaiKhoan.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTen();

        }

        private void HienThiTen()
        {
            DatabaseConnection dbCon = new DatabaseConnection();

            dbCon.MoKetNoi();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select HoTen from NhanVien where maNV = @maNV";

            sqlCommand.Parameters.AddWithValue("@maNV", maNV);
            sqlCommand.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                tSMIName.Text ="Xin chào "+ reader.GetString(0)+"!";
            }
            reader.Close();
            dbCon.DongKetNoi();
        }

        private void MenuItemAccountEdit_Click(object sender, EventArgs e)
        {
            ChiTietTaiKhoan chiTietTaiKhoan = new ChiTietTaiKhoan();
            chiTietTaiKhoan.setMaNV(maNV);
            chiTietTaiKhoan.ShowDialog();
        }

        private void MenuItemAccountChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhauUser doiMatKhauUser = new DoiMatKhauUser(this);
            doiMatKhauUser.setMaNV(maNV);
            doiMatKhauUser.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tsmiDanhSachTG_Click(object sender, EventArgs e)
        {
            DanhSachTacGia danhSachTacGia = new DanhSachTacGia();
            danhSachTacGia.ShowDialog();
        }

        private void tsmiDanhSachDG_Click(object sender, EventArgs e)
        {
            DanhSachDocGia danhSachDocGia = new DanhSachDocGia();
            danhSachDocGia.ShowDialog();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            QuanLyPhieuMuon quanLyPhieuMuon = new QuanLyPhieuMuon(this.maNV);
            quanLyPhieuMuon.ShowDialog();
        }

        private void tSMIChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            ChiTietTaiKhoan chiTietTaiKhoan = new ChiTietTaiKhoan();
            chiTietTaiKhoan.setMaNV(maNV);
            chiTietTaiKhoan.ShowDialog();
        }

        private void tSMIDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhauUser doiMatKhauUser = new DoiMatKhauUser(this);
            doiMatKhauUser.setMaNV(maNV);
            doiMatKhauUser.ShowDialog();
        }

        private void tSMIDangXuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();

                Login login = new Login();
                login.Show();
            }
        }

        private void tsMIThoat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mIQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            DanhSachTaiKhoan danhSachTaiKhoan = new DanhSachTaiKhoan();
            danhSachTaiKhoan.ShowDialog();
        }

        private void tSMITacGia_Click(object sender, EventArgs e)
        {
            DanhSachTacGia danhSachTacGia = new DanhSachTacGia();
            danhSachTacGia.ShowDialog();
        }

        private void tSMISach_Click(object sender, EventArgs e)
        {
        }

        private void tSMINhaXuatBan_Click(object sender, EventArgs e)
        {
            
        }

        private void tsMITheLoai_Click(object sender, EventArgs e)
        {

        }

        private void tsMIPhieuPhat_Click(object sender, EventArgs e)
        {

        }
    }
}
