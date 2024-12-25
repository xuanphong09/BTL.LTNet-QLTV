using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class LapPhieuMuon : UserControl
    {
        public LapPhieuMuon(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private string maNV { set; get; } = "";
        private string soPM { set; get; } = "";

        public void setSoPM(string soPM)
        {
            this.soPM = soPM;
        }
         
        //khi mã sách thay đổi sẽ hiển thị thông tin sách
        private void cbMaDG_TextChanged(object sender, EventArgs e)
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select HoTen from DocGia where MaDG='" + cbMaDG.Text + "'";
            sqlCmd.Connection = database.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtTenDG.Text = reader.GetString(0);
                if (HienThiPhieuPhat(cbMaDG.Text.Trim()))
                {
                    gbDSPP.Visible= true;
                }
                else
                {
                    gbDSPP.Visible = false;
                }
            }
            else
            {
                txtTenDG.Text = "";
                gbDSPP.Visible = false;
            }

        }

        //hàm load form
        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select MaDG from DocGia";
            sqlCmd.Connection = database.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                cbMaDG.Items.Add(reader.GetString(0));
            }

            reader.Close();

            if (soPM != "")
            {
                HienThiPhieuMuon();
            }
            gbDSPP.Visible = false;

        }

        //hàm hiển thị thông tin phiếu mượn
        private void HienThiPhieuMuon()
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from PhieuMuon where SoPM='" + soPM + "'";
            sqlCmd.Connection = dbcon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                cbMaDG.Text = reader.GetString(4);
                txtGhiChu.Text = reader.GetString(5);
                dtpHanTra.Value = reader.GetDateTime(2);
            }
        }

        //hàm hiển thị danh sách phiếu phạt
        private bool HienThiPhieuPhat(string maDG)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SoPhieuPhat, LyDoPhat, HinhThucXL, NgayPhat from PhieuPhat where MaDG='" + maDG + "'";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            int i = 0;
            lvDSPP.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy"));
                lvDSPP.Items.Add(item);
                i++;
            }
            
            reader.Close();
            dbCon.DongKetNoi();
            
            if(i>0)
            {
                return true;
            }
            return false;
        }

        //nut hủy phiếu mượn
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkSoPM(this.soPM) > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy phiếu mượn này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DatabaseConnection dbCon = new DatabaseConnection();
                    dbCon.MoKetNoi();
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = dbCon.slqCon;

                    sqlCmd.CommandText = "delete from PhieuMuon where SoPM='" + this.soPM + "'";
                    sqlCmd.ExecuteNonQuery();

                    QuanLyPhieuMuon parentForm = this.ParentForm as QuanLyPhieuMuon;
                    parentForm.panelContent.Controls.Clear();
                    LapPhieuMuon lapPhieuMuon = new LapPhieuMuon(this.maNV);
                    lapPhieuMuon.Dock = DockStyle.Fill;
                    parentForm.panelContent.Controls.Add(lapPhieuMuon);
                }
            }

        }



        //nút tiếp tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                if (CheckDate(cbMaDG.Text.Trim()) <0) {
                    MessageBox.Show("Thẻ đọc giả đã hết hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(CheckDate(cbMaDG.Text.Trim()) ==0)
                    {
                        DialogResult result = MessageBox.Show("Thẻ đọc giả này sẽ hết hạn trong ngày hôm nay.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (CheckDate(cbMaDG.Text.Trim()) <=7)
                    {
                        DialogResult result = MessageBox.Show("Thẻ đọc giả hạn thẻ còn " + CheckDate(cbMaDG.Text.Trim()) + " ngày.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string soPM = setSoPM();
                    string ngayMuon = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    string hanTra = dtpHanTra.Value.Year + "-" + dtpHanTra.Value.Month + "-" + dtpHanTra.Value.Day;
                    string maNV = this.maNV;
                    string maDG = cbMaDG.Text.Trim();
                    string ghiChu = txtGhiChu.Text.Trim();

                    DatabaseConnection dbCon = new DatabaseConnection();
                    dbCon.MoKetNoi();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    if (checkSoPM(this.soPM) <= 0)
                    {
                        sqlCmd.CommandText = "insert into PhieuMuon values('" + soPM + "','" + ngayMuon + "','" + hanTra + "','" + maNV + "','" + maDG + "','" + ghiChu + "')";

                    }
                    else
                    {
                        sqlCmd.CommandText = "update PhieuMuon set soPM='" + this.soPM + "', NgayMuon='" + ngayMuon + "',HanTra='" + hanTra + "',MaNV='" + maNV + "',MaDG='" + maDG + "',GhiChu='" + ghiChu + "' where soPM='" + this.soPM + "'";
                        soPM = this.soPM;

                    }
                    sqlCmd.Connection = dbCon.slqCon;

                    int kq = (int)sqlCmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        QuanLyPhieuMuon parentForm = this.ParentForm as QuanLyPhieuMuon;
                        parentForm.panelContent.Controls.Clear();
                        LapCTPhieuMuon lapCTPhieuMuon = new LapCTPhieuMuon(this.maNV);
                        lapCTPhieuMuon.setSoPM(soPM);
                        lapCTPhieuMuon.Dock = DockStyle.Fill;
                        parentForm.panelContent.Controls.Add(lapCTPhieuMuon);
                    }
                }
            }
        }

        //hàm kiểm tra thông tin nhập vào
        private bool FormValidate()
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(cbMaDG.Text))
            {
                isvalid = false;
                err.SetError(cbMaDG, "Vui lòng nhập thông tin mã đọc giả.");
            }
            else if (CheckMaDG(cbMaDG.Text) <= 0)
            {
                isvalid = false;
                err.SetError(cbMaDG, "Mã đọc giả không tồn tại.");
            }
            else
            {
                err.SetError(cbMaDG, "");
            }

            if (string.IsNullOrEmpty(txtTenDG.Text))
            {
                isvalid = false;
                err.SetError(txtTenDG, "Vui lòng nhập thông tin tên đọc giả.");
            }
            else
            {
                err.SetError(txtTenDG, "");
            }

            //kiểm tra ngày hẹn trả
            DateTime hantra = DateTime.Parse(dtpHanTra.Value.ToString());
            if (DateTime.Compare(hantra, DateTime.Now.Date)<0)
            {
                isvalid = false;
                err.SetError(dtpHanTra, "Ngày hẹn trả không hợp lệ.");
            }
            else
            {
                err.SetError(dtpHanTra, "");
            }

                return isvalid;
        }

        //hàm kiểm tra mã đọc giả
        private int CheckMaDG(string maDG)
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from DocGia where MaDG='" + maDG + "'";

            sqlCmd.Connection = database.slqCon;
            int count = (int)sqlCmd.ExecuteScalar();
            return count;
        }

        //hàm kiểm tra số phiếu mượn đã tồn tại hay chưa
        private int checkSoPM(string soPM)
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from PhieuMuon where SoPM='" + soPM + "'";

            sqlCmd.Connection = database.slqCon;
            int count = (int)sqlCmd.ExecuteScalar();
            return count;
        }

        //hàm tạo số phiếu mượn tự động
        private string setSoPM()
        {
            string newSoPM = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 SoPM from PhieuMuon order by SoPM desc";
            sqlCmd.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                string soPM = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "PM")
                string number = soPM.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newSoPM = "PM" + num.ToString("D3");

            }
            else
            {
                newSoPM = "PM001";
            }
            reader.Close();
            dbCon.DongKetNoi();
            return newSoPM;
        }

        //hàm kiểm tra ngày hết hạn thẻ đọc giả
        private int CheckDate(string maDG)
        {
            bool isvalid = true;

            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select NgayHHThe from DocGia where MaDG='" + maDG + "'";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                DateTime hanThe = reader.GetDateTime(0);
                TimeSpan ngayConLai = hanThe - DateTime.Now.Date;
                return ngayConLai.Days;
            }
            reader.Close();
            dbCon.DongKetNoi();
            return -1;
        }
    }
}
