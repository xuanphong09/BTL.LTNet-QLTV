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
    public partial class DanhSachPhieuMuon : UserControl
    {
        public DanhSachPhieuMuon()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int index = -1;

        //nút xem và chỉnh sửa phiếu mượn
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = true;
            btnTimKiem.Enabled = false;

            //fill form chinh sua phieu muon vào panleContent
            ChinhSuaPhieuMuon chinhSuaPhieuMuon = new ChinhSuaPhieuMuon();
            DataRow row = ds.Tables["DSPhieuMuon"].Rows[this.index];
            chinhSuaPhieuMuon.setSoPhieuMuon(row["SoPM"].ToString());
            panelContent.Controls.Clear();
            chinhSuaPhieuMuon.Dock = DockStyle.Fill;
            panelContent.Controls.Add(chinhSuaPhieuMuon);
        }

        //nút hủy chỉnh sửa
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dgvDSPM);
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Visible = false;
            btnTimKiem.Enabled = true;
        }

        //hàm load form
        private void DanhSachPhieuMuon_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            HienThiDanhSach();
            
        }

        //hàm hiển thị danh sách phiếu mượn
        private void HienThiDanhSach()
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            string query = "select PhieuMuon.SoPM, PhieuMuon.MaDG, DocGia.HoTen, NgayMuon, HanTra, PhieuMuon.GhiChu  from PhieuMuon inner join DocGia on PhieuMuon.MaDG = DocGia.MaDG where SoPM = '"+txtTK.Text.Trim()+"' or PhieuMuon.MaDG= '"+txtTK.Text.Trim()+"' or HoTen like N'%"+txtTK.Text.Trim()+"%'";

            adapter = new SqlDataAdapter(query, database.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds,"DSPhieuMuon");

            dgvDSPM.DataSource = ds.Tables["DSPhieuMuon"];

            database.DongKetNoi();
        }

        //hàm xử lý sự kiện click vào 1 dòng trong dgvDSPM
        private void dgvDSPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;
            if(this.index== -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }

            DataRow row = ds.Tables["DSPhieuMuon"].Rows[this.index];

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            string ThoiGianHienTai = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string NgayMuon = LayNgayMuon(row["SoPM"].ToString());
            TimeSpan KhoangTG = DateTime.Parse(ThoiGianHienTai) - DateTime.Parse(NgayMuon);
            if (KhoangTG.TotalMinutes > 15)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        //hàm lấy ngày mượn
        private string LayNgayMuon(string soPM)
        {
            string ngayMuon="";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select NgayMuon from PhieuMuon where SoPM = '" + soPM + "'";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                ngayMuon = reader.GetDateTime(0).ToString();
            }
            dbCon.DongKetNoi();
            return ngayMuon;
        }

        //nút xóa phiếu mượn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["DSPhieuMuon"].Rows[this.index];
            string soPM = row["SoPM"].ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu chỉnh sửa phiếu mượn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkPM(soPM) > 0)
                {
                    MessageBox.Show("Phiếu mượn có sách đang mượn hoặc đã trả không thể xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //xoa ct phieu muon
                    DatabaseConnection dbCon = new DatabaseConnection();
                    dbCon.MoKetNoi();
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = dbCon.slqCon;

                    CapNhatSach(soPM);
                    sqlCmd.CommandText = "delete from CTPhieuMuon where SoPM = '" + soPM + "'";
                    sqlCmd.ExecuteNonQuery();

                    sqlCmd.CommandText = "delete from PhieuMuon where SoPM='" + soPM + "'";
                    sqlCmd.ExecuteNonQuery();

                    dbCon.DongKetNoi();
                    MessageBox.Show("Phiếu mượn đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach();
                }
            }

        }

        //nút tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        //hàm cập nhật số lượng sách khi xóa phiếu mượn
        private void CapNhatSach(string soPM)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE Sach SET DaMuon = DaMuon - (SELECT SLMuon FROM CTPhieuMuon WHERE CTPhieuMuon.MaSach = Sach.MaSach AND CTPhieuMuon.SoPM = @SoPM) WHERE EXISTS (SELECT 1 FROM CTPhieuMuon WHERE CTPhieuMuon.MaSach = Sach.MaSach AND CTPhieuMuon.SoPM = @SoPM)";
            sqlCmd.Parameters.AddWithValue("@SoPM", soPM);
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();

        }

        //hàm kiểm tra phiếu mượn có sách đang mượn hoặc đã trả không
        private int checkPM(string soPM)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from CTPhieuMuon where SoPM='" + soPM + "' and SLTra !='0'";

            sqlCmd.Connection = dbCon.slqCon;

            int kq = (int)sqlCmd.ExecuteScalar();

            return kq;
        }


    }
}
