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
    public partial class ChinhSuaPhieuMuon : UserControl
    {
        public ChinhSuaPhieuMuon()
        {
            InitializeComponent();

            //tạo datatable để lưu thông tin sách thay đổi
            dtSach = new DataTable();
            dtSach.Columns.Add("MaSach",typeof(string));
            dtSach.Columns.Add("SLMuon", typeof(int));
            dtSach.Columns.Add("TT", typeof(int));
        }


        private string sophieumuon="";
        int chucNang = 0;
        int index = -1;

        DataTable dtSach = null;

        public void setSoPhieuMuon(string sophieumuon)
        {
            this.sophieumuon = sophieumuon;
        }

        SqlDataAdapter adapter_HTCTPM = null;
        DataSet ds_HTCTPM = null;

        SqlDataAdapter adapter_CSCTPM = null;
        DataSet ds_CSCTPM = null;

        //thong tin phieu muon
        public string ghiChu { set; get; }

        //hàm load form
        private void ChinhSuaPhieuMuon_Load(object sender, EventArgs e)
        {
            
            ChinhSuaCTPM();
            HienThiMaSach();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            gbTTCTPM.Enabled = false;

            string ThoiGianHienTai = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string NgayMuon = LayNgayMuon(sophieumuon);
            TimeSpan KhoangTG = DateTime.Parse(ThoiGianHienTai) - DateTime.Parse(NgayMuon);
            if(KhoangTG.TotalMinutes > 15)
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            HienThiPhieuMuon();
            HienThiCTPM();

            //add item cho combobox tinh trang
            cbTinhTrang.Items.Add("Đã trả");
            cbTinhTrang.Items.Add("Đang mượn");
            cbTinhTrang.Items.Add("Mất sách");
            cbTinhTrang.Items.Add("Trả muộn");
            cbTinhTrang.Items.Add("Trả quá hạn");
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

        //hàm chọn sách và fill vào gb thông tin chi tiết
        private void dgvDSCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1) return;

            DataRow row = ds_HTCTPM.Tables["HTCTPhieuMuon"].Rows[index];

            cbMaSach.Text = row["MaSach"].ToString();
            txtTenSach.Text = row["TenSach"].ToString();
            txtSLMuon.Text = row["SLMuon"].ToString();
            txtSLTra.Text = row["SLTra"].ToString();
            cbTinhTrang.Text = row["TinhTrang"].ToString();
            
            if (row["NgayTra"].ToString() == "")
            {
                dtpNgayTra.Value = DateTime.Now;
            }
            else
            {
                dtpNgayTra.Value = DateTime.Parse(row["NgayTra"].ToString());
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        //hàm hiển thị thông tin phiếu mượn
        private void HienThiPhieuMuon()
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select PhieuMuon.SoPM, PhieuMuon.MaDG, DocGia.HoTen,PhieuMuon.MaNV, NhanVien.HoTen, NgayMuon, HanTra, PhieuMuon.GhiChu  from PhieuMuon inner join DocGia on PhieuMuon.MaDG = DocGia.MaDG inner join NhanVien on PhieuMuon.MaNV= NhanVien.MaNV where PhieuMuon.SoPM = '"+sophieumuon+"'";
            sqlCmd.Connection = database.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtSoPM.Text = reader.GetString(0);
                txtMaDG.Text = reader.GetString(1);
                txtTenDG.Text = reader.GetString(2);
                txtMaNV.Text = reader.GetString(3);
                txtTenNV.Text = reader.GetString(4);
                dtpNgayMuon.Value = reader.GetDateTime(5);
                dtpHanTra.Value = reader.GetDateTime(6);
                if(reader.IsDBNull(7))
                {
                    txtGhiChu.Text = "";
                }
                else
                {
                    txtGhiChu.Text = reader.GetString(7);
                }
            }

        }

        //hàm hiển thị chi tiết phiếu mượn
        private void HienThiCTPM()
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            string query = "select CTPhieuMuon.MaSach, Sach.TenSach, SLMuon, SLTra, TinhTrang, NgayTra  from PhieuMuon inner join CTPhieuMuon on PhieuMuon.SoPM = CTPhieuMuon.SoPM inner join Sach on Sach.MaSach = CTPhieuMuon.MaSach where CTPhieuMuon.SoPM = '" + sophieumuon + "'";

            adapter_HTCTPM = new SqlDataAdapter(query, database.slqCon);
            ds_HTCTPM = new DataSet();
            adapter_HTCTPM.Fill(ds_HTCTPM, "HTCTPhieuMuon");

            dgvDSCTPM.DataSource = ds_HTCTPM.Tables["HTCTPhieuMuon"];

            database.DongKetNoi();
        }

        //hàm lấy ctpm về để sửa
        private void ChinhSuaCTPM()
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            string query = "select * from CTPhieuMuon where CTPhieuMuon.SoPM = '" + sophieumuon + "'";

            adapter_CSCTPM = new SqlDataAdapter(query, database.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter_CSCTPM);
            ds_CSCTPM = new DataSet();
            adapter_CSCTPM.Fill(ds_CSCTPM, "CSCTPhieuMuon");
            
            database.DongKetNoi();
        }

        //hàm xóa dữ liệu
        private void XoaDuLieu()
        {
            cbMaSach.Text = "";
            err.SetError(cbMaSach, "");
            txtTenSach.Text = "";
            err.SetError(txtTenSach, "");
            txtSLMuon.Text = "";
            err.SetError(txtSLMuon, "");
            txtSLTra.Text = "";
            err.SetError(txtSLTra, "");
            cbTinhTrang.Text = "";
            err.SetError(cbTinhTrang, "");
            dtpNgayTra.Value = DateTime.Now;
            lbSLTra.Text = "Số lượng trả:";
            cbTinhTrang.Enabled = true;
            cbMaSach.Enabled = true;
            
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            this.ghiChu = txtGhiChu.Text;
        }

        //bút hủy thêm sửa xóa thông tin sách
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            btnThem.Enabled = true;
            gbTTCTPM.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDSCTPM.CellClick += dgvDSCTPM_CellClick;
        }

        //nút thêm sách vào phiếu mượn
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            btnThem.Enabled = false;
            chucNang = 1;
            gbTTCTPM.Enabled = true;
            cbTinhTrang.Enabled = false;
            lbSLTra.Text = "Số lượng kho:";
            dgvDSCTPM.CellClick -= dgvDSCTPM_CellClick;
        }

        //nút sửa sách trong phiếu mượn
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            chucNang = 2;
            gbTTCTPM.Enabled = true;
            btnSua.Enabled = false;
            cbMaSach.Enabled = false;

            dgvDSCTPM.CellClick -= dgvDSCTPM_CellClick;
        }

        //nút xóa sách trong phiếu mượn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này khỏi phiếu mượn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataRow row_HT = ds_HTCTPM.Tables["HTCTPhieuMuon"].Rows[index];
                DataRow row_CS = ds_CSCTPM.Tables["CSCTPhieuMuon"].Rows[index];
                
                bool isUpdated = false;
                //xoa du lieu trong datatable
                foreach (DataRow row in dtSach.Rows)
                {
                    if (row["MaSach"].ToString() == row_CS["MaSach"].ToString() && (int)row["TT"]==1)
                    {
                        row.Delete();
                        isUpdated = true;
                        break;
                    }
                    else if(row["MaSach"].ToString() == row_CS["MaSach"].ToString() && (int)row["TT"] == 2)
                    {
                        row["SLMuon"] = - LaySLMuon(row_CS["MaSach"].ToString());
                        isUpdated = true;
                        break;
                    }
                }
                
                if(!isUpdated)
                {
                    dtSach.Rows.Add(row_CS["MaSach"].ToString(), -LaySLMuon(row_CS["MaSach"].ToString()), 2);
                }

                row_CS.Delete();
                row_HT.Delete();
            }
        }

        //hàm lưu thông tin sách trong sửa, thêm
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ThoiGianHienTai = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string NgayMuon = LayNgayMuon(sophieumuon);
            TimeSpan KhoangTG = DateTime.Parse(ThoiGianHienTai) - DateTime.Parse(NgayMuon);
            if (KhoangTG.TotalMinutes > 15)
            {
                MessageBox.Show("Không thể chỉnh sửa phiếu mượn sau 15 phút kể từ lúc mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {
                if (FormValidate())
                {
                    if (chucNang == 1)
                    {
                        ThemSachCTPM();
                    }
                    else if (chucNang == 2)
                    {
                        SuaSachCTPM();
                    }
                    btnThem.Enabled = true;
                    XoaDuLieu();
                    gbTTCTPM.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    dgvDSCTPM.CellClick += dgvDSCTPM_CellClick;
                }
            }
        }

        //hàm lưu toàn bộ thông tin phiếu mượn
        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            //update phieu muon
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;

            string hanTra = dtpHanTra.Value.Year + "-" + dtpHanTra.Value.Month + "-" + dtpHanTra.Value.Day;
            sqlCmd.CommandText = "update PhieuMuon set GhiChu = N'" + this.ghiChu + "', HanTra = '"+hanTra+"' where SoPM = '" + this.sophieumuon + "'";

            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();

            //update chi tiet phieu muon
            adapter_CSCTPM.Update(ds_CSCTPM, "CSCTPhieuMuon");
            foreach (DataRow row in dtSach.Rows)
            {
                CapNhatSLSach(row["MaSach"].ToString(), (int)row["SLMuon"]);
            }
            dtSach.Clear();

            dbCon.DongKetNoi();
            MessageBox.Show("Chỉnh sửa phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            QuanLyPhieuMuon quanLyPhieuMuon = this.ParentForm as QuanLyPhieuMuon;
            quanLyPhieuMuon.panelContent.Controls.Clear();
            quanLyPhieuMuon.panelContent.Controls.Add(new DanhSachPhieuMuon());
        }

        private void CapNhatSLSach(string maSach, int sLMuon)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Sach set DaMuon = DaMuon + " + sLMuon + " where MaSach = '" + maSach + "'";
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();
            dbCon.DongKetNoi();
        }

        //hàm thêm sách vào chi tiết phiếu mượn
        private void ThemSachCTPM()
        {
            DataRow row_CS = ds_CSCTPM.Tables["CSCTPhieuMuon"].NewRow();
            DataRow row_HT = ds_HTCTPM.Tables["HTCTPhieuMuon"].NewRow();

            //hiển thị
            row_HT["MaSach"] = cbMaSach.Text;
            row_HT["TenSach"] = txtTenSach.Text;
            row_HT["SLMuon"] = txtSLMuon.Text;
            row_HT["SLTra"] = 0;
            row_HT["TinhTrang"] = "Đang mượn";
            row_HT["NgayTra"] = DBNull.Value;

            row_CS["SoPM"] = sophieumuon;
            row_CS["MaSach"] = cbMaSach.Text;
            row_CS["SLMuon"] = txtSLMuon.Text;
            row_CS["SLTra"] = 0;
            row_CS["TinhTrang"] = "Đang mượn";
            row_CS["NgayTra"] = DBNull.Value;

            ds_CSCTPM.Tables["CSCTPhieuMuon"].Rows.Add(row_CS);
            ds_HTCTPM.Tables["HTCTPhieuMuon"].Rows.Add(row_HT);

            //them ma sach va so luong muon vao datatable de ty cap nhat so luong sach
            dtSach.Rows.Add(cbMaSach.Text, txtSLMuon.Text, 1);
        }

        //hàm sửa thông tin sách trong chi tiết phiếu mượn
        private void SuaSachCTPM()
        {
            DataRow row_HT = ds_HTCTPM.Tables["HTCTPhieuMuon"].Rows[index];
            DataRow row_CS = ds_CSCTPM.Tables["CSCTPhieuMuon"].Rows[index];

            //hiển thị
            row_HT.BeginEdit();
            row_HT["SLMuon"] = txtSLMuon.Text;
            row_HT["TinhTrang"] = cbTinhTrang.Text;
            row_HT.EndEdit();

            //cap nhat
            row_CS.BeginEdit();
            row_CS["SLMuon"] = txtSLMuon.Text;
            row_CS["TinhTrang"] = cbTinhTrang.Text;
            
            bool isUpdated = false;
            //luu du lieu cap nhat vao datatable
            int SLMuon = int.Parse(txtSLMuon.Text) - LaySLMuon(row_CS["MaSach"].ToString());
            foreach (DataRow row in dtSach.Rows)
            {
                if ((int)row["TT"] == 1 && row["MaSach"].ToString()== row_CS["MaSach"].ToString())
                {
                    row["SLMuon"] = txtSLMuon.Text;
                    isUpdated = true;
                    break;
                }
                else if ((int)row["TT"] == 2 && row["MaSach"].ToString() == row_CS["MaSach"].ToString())
                {
                    isUpdated = true;
                    row["SLMuon"] = SLMuon;
                    break;
                }
            }

            if (!isUpdated)
            {
                dtSach.Rows.Add(row_CS["MaSach"].ToString(), SLMuon, 2);
            }
            row_CS.EndEdit();

        }

        //lay so luong muon
        private int LaySLMuon(string maSach)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SLMuon from CTPhieuMuon where SoPM='" + sophieumuon + "' and MaSach='" + maSach + "'";
            sqlCmd.Connection = dbCon.slqCon;

            int slMuon = 0;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                slMuon = reader.GetInt32(0);
            }

            dbCon.DongKetNoi();

            return slMuon;
        }

        //hàm add mã sách vào combobox
        private void HienThiMaSach()
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            string query = "select MaSach from Sach";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = query;
            sqlCmd.Connection = database.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                cbMaSach.Items.Add(reader.GetString(0));
            }

            database.DongKetNoi();

        }

        //hàm hiển thị tên sách theo mã sách
        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            string query = "select TenSach, SoLuong, DaMuon from Sach where MaSach = '"+cbMaSach.Text.Trim()+"'";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = query;
            sqlCmd.Connection = database.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtTenSach.Text = reader.GetString(0);
                if (chucNang == 1)
                {
                    txtSLTra.Text = (reader.GetInt32(1) - reader.GetInt32(2)).ToString();
                }
            }
            else
            {
                txtTenSach.Text = "";
            }
            database.DongKetNoi();
        }

        //hàm validate dữ liệu
        private bool FormValidate()
        {
            bool isvalid = true;

            if (string.IsNullOrEmpty(cbMaSach.Text))
            {
                isvalid = false;
                err.SetError(cbMaSach, "Vui lòng nhập mã sách.");
            }
            else if (CheckMaSach() <= 0)
            {
                isvalid = false;
                err.SetError(cbMaSach, "Mã sách không tồn tại.");
            }
            else if (checkSoPMAndMaSach(this.sophieumuon, cbMaSach.Text) > 0 && this.chucNang == 1)
            {
                isvalid = false;
                err.SetError(cbMaSach, "Mã sách đã tồn tại trong phiếu mượn.");
            }
            else
            {
                err.SetError(cbMaSach, "");
            }

            if (string.IsNullOrEmpty(txtSLMuon.Text.Trim()))
            {
                isvalid = false;
                err.SetError(txtSLMuon, "Vui lòng nhập số lượng mượn.");
            }
            else if (int.Parse(txtSLMuon.Text.Trim()) <= 0)
            {
                isvalid = false;
                err.SetError(txtSLMuon, "Số lượng mượn phải lớn hơn 0.");
            }
            else if (CheckSLSach(cbMaSach.Text) == 0)
            {
                isvalid = false;
                err.SetError(txtSLMuon, "Số lượng sách không đủ.");
            }
            else
            {
                err.SetError(txtSLMuon, "");
            }

            return isvalid;
        }

        //hàm check mã sách có tồn tại hay không
        private int CheckMaSach()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from Sach where MaSach='" + cbMaSach.Text + "'";

            sqlCmd.Connection = dbCon.slqCon;
            int count = (int)sqlCmd.ExecuteScalar();
            return count;
        }

        //hàm check số lượng sách
        private int CheckSLSach(string maSach)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SLMuon from CTPhieuMuon where MaSach='" + maSach + "' and SoPM = '" + this.sophieumuon + "'";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader1 = sqlCmd.ExecuteReader();

            int slMuon = 0;
            if (reader1.Read())
            {
                slMuon = reader1.GetInt32(0);
            }
            reader1.Close();

            sqlCmd.CommandText = "select SoLuong, DaMuon from Sach where MaSach='" + maSach + "'";

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetInt32(0) - reader.GetInt32(1) + slMuon < int.Parse(txtSLMuon.Text.Trim()))
                {
                    return 0;
                }
            }
            return 1;
        }

        //hàm check xem mã sách đã tồn tại trong phiếu mượn chưa
        private int checkSoPMAndMaSach(string soPM, string maSach)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from CTPhieuMuon where SoPM='" + soPM + "' and MaSach='" + maSach + "'";

            sqlCmd.Connection = dbCon.slqCon;
            int count = (int)sqlCmd.ExecuteScalar();
            return count;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            InPhieuMuonTra inPhieuMuonTra = new InPhieuMuonTra();
            inPhieuMuonTra.SetSoPM(this.sophieumuon);
            inPhieuMuonTra.ShowDialog();
        }
    }
}
