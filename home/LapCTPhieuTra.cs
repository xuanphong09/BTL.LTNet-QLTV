using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class LapCTPhieuTra : UserControl
    {
        public LapCTPhieuTra()
        {
            InitializeComponent();

            // Tạo một DataTable để lưu thông tin số lượng trả của từng sách
            dtSLTra = new DataTable("SLTraTable");

            // Thêm các cột vào DataTable
            dtSLTra.Columns.Add("MaSach", typeof(string));    // Cột mã sách (kiểu chuỗi)
            dtSLTra.Columns.Add("SoLuongTra", typeof(int));   // Cột số lượng trả (kiểu số nguyên)
        }


        private string SoPM;
        private string MaNV;

        SqlDataAdapter adapter_hienthiCTPM = null;
        DataSet ds_hienthiCTPM = null;

        SqlDataAdapter adapter_ChinhSuaCTPM = null;
        DataSet ds_ChinhSuaCTPM = null;
        int index = -1;

        DataTable dtSLTra= null;


        public void SetSoPM(string soPM)
        {
            this.SoPM = soPM;
        }
        public void SetMaNV(string maNV)
        {
            this.MaNV = maNV;
        }

        //hàm load form
        private void LapCTPhieuTra_Load(object sender, EventArgs e)
        {
            HienThiCTPM();
            HienThiPM();
            ChinhSuaCTPM();
            btnTraSach.Enabled = false;
            gbTTCTPM.Enabled = false;

            //add item cho combobox tinh trang
            cbTinhTrang.Items.Add("Đã trả");
            cbTinhTrang.Items.Add("Đang mượn");
            cbTinhTrang.Items.Add("Mất sách");
            cbTinhTrang.Items.Add("Trả muộn");
            cbTinhTrang.Items.Add("Trả quá hạn");
            
        }

        //hàm lấy dữ liệu chi tiết phiếu mượn để hiển thị
        private void HienThiCTPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select CTPhieuMuon.MaSach,TenSach, SLMuon, SLTra, TinhTrang, NgayTra from CTPhieuMuon inner join Sach on CTPhieuMuon.MaSach = Sach.MaSach where SoPM='" + SoPM + "'";

            adapter_hienthiCTPM = new SqlDataAdapter(query, dbCon.slqCon);
            ds_hienthiCTPM = new DataSet();
            adapter_hienthiCTPM.Fill(ds_hienthiCTPM, "DSCTPM");

            dgvDSCTPM.DataSource = ds_hienthiCTPM.Tables["DSCTPM"];
        }

        //hàm lấy dữ liệu chi tiết phiếu mượn để chỉnh sửa
        private void ChinhSuaCTPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from CTPhieuMuon where SoPM='" + SoPM + "'";

            adapter_ChinhSuaCTPM = new SqlDataAdapter(query, dbCon.slqCon);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter_ChinhSuaCTPM);

            ds_ChinhSuaCTPM = new DataSet();
            adapter_ChinhSuaCTPM.Fill(ds_ChinhSuaCTPM, "ChinhSuaCTPM");
        }

        //hàm hiển thị thông tin phiếu mượn
        private void HienThiPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select PhieuMuon.SoPM, PhieuMuon.MaDG, DocGia.HoTen, PhieuMuon.MaNV, NhanVien.HoTen , NgayMuon, HanTra, PhieuMuon.GhiChu  from PhieuMuon inner join DocGia on PhieuMuon.MaDG = DocGia.MaDG inner join NhanVien on PhieuMuon.MaNV= NhanVien.MaNV where SoPM='" + SoPM + "'";
            sqlCmd.Connection = dbCon.slqCon;
            
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtSoPM.Text= reader.GetString(0);
                txtMaDG.Text = reader.GetString(1);
                txtTenDG.Text = reader.GetString(2);
                txtMaNV.Text = reader.GetString(3);
                txtTenNV.Text = reader.GetString(4);
                string[] dt = reader.GetDateTime(5).ToString("MM/dd/yyyy").Split('/');
                dtpNgayMuon.Value = new DateTime(int.Parse(dt[2].Trim()), int.Parse(dt[0].Trim()), int.Parse(dt[1].Trim()));
                //dtpNgayMuon.Value = DateTime.Parse(reader.GetDateTime(5).ToString());
                dtpHanTra.Value = DateTime.Parse(reader.GetDateTime(6).ToString());
                txtGhiChu.Text = reader.GetString(7);
            }

            dbCon.DongKetNoi();
        }

        //hàm xử lý sự kiện click vào 1 dòng trong dgvDSCTPM thì sẽ fill dữ liệu vào form
        private void dgvDSCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1)
            {
                btnTraSach.Enabled = false;
                return;
            }

            DataRow row = ds_hienthiCTPM.Tables["DSCTPM"].Rows[index];
            txtMaSach.Text = row["MaSach"].ToString();
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

            btnTraSach.Enabled = true;
        }

        //hàm xử lý sự kiện click vào nút trả sách
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            gbTTCTPM.Enabled = true;
            dgvDSCTPM.CellClick -= dgvDSCTPM_CellClick;
            btnTraSach.Enabled = false;
        }

        //hàm xử lý sự kiện click vào nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                //chỉnh sửa dữ liệu trong dataset trong hiển thị
                DataRow row = ds_hienthiCTPM.Tables["DSCTPM"].Rows[index];
                row.BeginEdit();

                row["SLTra"] = txtSLTra.Text;
                row["TinhTrang"] = cbTinhTrang.Text;
                row["NgayTra"] = dtpNgayTra.Value.Year+"-"+ dtpNgayTra.Value.Month + "-" + dtpNgayTra.Value.Day;
                row.EndEdit();

                //chỉnh sửa dữ liệu trong dataset trong chinh sua
                DataRow row1 = ds_ChinhSuaCTPM.Tables["ChinhSuaCTPM"].Rows[index];
                row1.BeginEdit();
                row1["SLTra"] = txtSLTra.Text;
                row1["TinhTrang"] = cbTinhTrang.Text;
                row1["NgayTra"] = dtpNgayTra.Value.Year + "-" + dtpNgayTra.Value.Month + "-" + dtpNgayTra.Value.Day;

                // Lưu số lượng trả của từng sách vào DataTable
                int slTra = int.Parse(txtSLTra.Text) - LaySLTra(txtMaSach.Text);
                bool isUpdated = false; // Đánh dấu nếu dòng đã được cập nhật

                // Kiểm tra từng dòng trong DataTable
                foreach (DataRow row2 in dtSLTra.Rows)
                {
                    // Nếu MaSach đã tồn tại, cập nhật SoLuongTra
                    if (row2["MaSach"].ToString() == txtMaSach.Text)
                    {
                        row2["SoLuongTra"] = slTra; // Cập nhật số lượng trả
                        isUpdated = true;          // Đánh dấu là đã cập nhật
                        break;
                    }
                }

                // Nếu chưa có dòng nào phù hợp, thêm dòng mới
                if (!isUpdated)
                {
                    dtSLTra.Rows.Add(txtMaSach.Text, slTra);
                }

                row1.EndEdit();


                XoaDuLieu();
                dgvDSCTPM.CellClick += dgvDSCTPM_CellClick;
                btnTraSach.Enabled = false;
                gbTTCTPM.Enabled = false;
            }
        }

        //hàm xử lý sự kiện click vào nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            dgvDSCTPM.CellClick += dgvDSCTPM_CellClick;
            btnTraSach.Enabled = false;
            gbTTCTPM.Enabled = false;
        }

        //hàm xóa dữ liệu
        private void XoaDuLieu()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtSLMuon.Text = "";
            txtSLTra.Text = "";
            cbTinhTrang.Text = "";
            dtpNgayTra.Value = DateTime.Now;
            err.SetError(txtSLTra, "");
        }

        //validate form
        private bool FormValid()
        {
            bool isValid = true;
            DataRow row = ds_hienthiCTPM.Tables["DSCTPM"].Rows[index];

            if (string.IsNullOrEmpty(txtSLTra.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtSLTra, "Vui lòng điền số lượng sách muốn trả.");
            }
            else if (!int.TryParse(txtSLTra.Text.Trim(), out int slMuon))
            {
                isValid = false;
                err.SetError(txtSLTra, "Vui lòng nhập số hợp lệ.");
            }
            else if (int.Parse(txtSLTra.Text.Trim()) > int.Parse(txtSLMuon.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtSLTra, "Số lượng trả không được lớn hơn số lượng mượn.");
            }
            else if (int.Parse(txtSLTra.Text.Trim()) < 0)
            {
                isValid = false;
                err.SetError(txtSLTra, "Số lượng trả không được nhỏ hơn 0.");
            }
            else if (int.Parse(txtSLTra.Text.Trim()) < LaySLTra(row["MaSach"].ToString()))
            {
                isValid = false;
                err.SetError(txtSLTra, "Số lượng trả không được nhỏ hơn số lượng đã trả.");
            }
            else
            {
                err.SetError(txtSLTra, "");
            }

            return isValid;
        }

        //hàm lấy số lượng trả của sách
        private int LaySLTra(string maSach)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SLTra from CTPhieuMuon where SoPM='" + SoPM + "' and MaSach='" + maSach + "'";
            sqlCmd.Connection = dbCon.slqCon;

            int slTra = int.Parse(sqlCmd.ExecuteScalar().ToString());

            dbCon.DongKetNoi();

            return slTra;
        }

        //hàm xử lý sự kiện click vào nút hoàn thành để lưu thông tin phiếu trả
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update PhieuMuon set GhiChu = N'"+txtGhiChu.Text.Trim()+"' where SoPM='" + SoPM + "'";
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();
            dbCon.DongKetNoi();

            adapter_ChinhSuaCTPM.Update(ds_ChinhSuaCTPM, "ChinhSuaCTPM");

            foreach (DataRow row in dtSLTra.Rows)
            {
                CapNhatSLSach(row["MaSach"].ToString(), (int)row["SoLuongTra"]);
            }

            MessageBox.Show("Trả sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            QuanLyPhieuMuon quanLyPhieuMuon = this.ParentForm as QuanLyPhieuMuon;
            quanLyPhieuMuon.panelContent.Controls.Clear();
            LapPhieuTra lapPhieuTra = new LapPhieuTra();
            lapPhieuTra.Dock = DockStyle.Fill;
            quanLyPhieuMuon.panelContent.Controls.Add(lapPhieuTra);

        }

        //hàm cập nhật số lượng sách khi trả sách
        private void CapNhatSLSach(string maSach, int slTra)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Sach set DaMuon = DaMuon - "+slTra+" where MaSach='" + maSach + "'";
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();
            dbCon.DongKetNoi();
        }

        //hàm xử lý sự kiện click vào nút quay lại
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuanLyPhieuMuon quanLyPhieuMuon = this.ParentForm as QuanLyPhieuMuon;
            quanLyPhieuMuon.panelContent.Controls.Clear();
            LapPhieuTra lapPTra = new LapPhieuTra();
            lapPTra.SetMaNV(MaNV);

            lapPTra.Dock = DockStyle.Fill;

            quanLyPhieuMuon.panelContent.Controls.Add(lapPTra);
        }

        //hàm xử lý sự kiện click vào nút lập phiếu phạt
        private void btnLapPhieuPhat_Click(object sender, EventArgs e)
        {
            ThemMoiPhieuPhat themMoiPhieuPhat = new ThemMoiPhieuPhat();
            themMoiPhieuPhat.SetMaNV(this.MaNV);
            themMoiPhieuPhat.SetMaDG(txtMaDG.Text);
            themMoiPhieuPhat.ShowDialog();
        }

        private void btnInPhieuMuon_Click(object sender, EventArgs e)
        {
            InPhieuMuonTra inPhieuMuonTra = new InPhieuMuonTra();
            inPhieuMuonTra.SetSoPM(this.SoPM);
            inPhieuMuonTra.ShowDialog();

        }
    }
}
