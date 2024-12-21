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
    public partial class LapCTPhieuMuon : UserControl
    {
        public LapCTPhieuMuon(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private string maNV= "";
        private string soPM = "";
        private int index = -1;
        
        SqlDataAdapter adapter= null;
        DataSet ds = null;
        SqlDataAdapter adapter1 = null;
        DataSet ds1 = null;

        int chucNang = 0;

        //set soPM
        public void setSoPM(string soPM)
        {
            this.soPM = soPM;
        }

        //nút quay lại
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuanLyPhieuMuon parentForm = this.ParentForm as QuanLyPhieuMuon;
            parentForm.panelContent.Controls.Clear();
            LapPhieuMuon lapPhieuMuon = new LapPhieuMuon(this.maNV);
            lapPhieuMuon.setSoPM(this.soPM);
            lapPhieuMuon.Dock = DockStyle.Fill;
            parentForm.panelContent.Controls.Add(lapPhieuMuon);
        }

        //nút xong
        private void btnXong_Click(object sender, EventArgs e)
        {
            if (checkPM()>0)
            {
                QuanLyPhieuMuon parentForm = this.ParentForm as QuanLyPhieuMuon;
                parentForm.panelContent.Controls.Clear();
                DanhSachPhieuMuon danhSachPhieuMuon = new DanhSachPhieuMuon();
                danhSachPhieuMuon.Dock = DockStyle.Fill;
                parentForm.panelContent.Controls.Add(danhSachPhieuMuon);
                //doi mau nut
                parentForm.btnDSPM.BackColor = Color.FromArgb(128, 255, 255);
                parentForm.btnLPM.BackColor = Color.FromArgb(255, 255, 255);
                parentForm.btnDSPM.Enabled = false;
                parentForm.btnLPM.Enabled = true;
            }
            else
            {
                MessageBox.Show("Phiếu mượn đang trống!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            


        }

        //hàm kiểm tra phiếu mượn có sách không
        private int checkPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from CTPhieuMuon where SoPM='" + this.soPM + "'";

            sqlCmd.Connection = dbCon.slqCon;

            int  kq = (int)sqlCmd.ExecuteScalar();

            return kq;
        }

        //hàm load form
        private void LapCTPhieuMuon_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbNTTS.Enabled = false;
            HienThiDSCTPM();
            LayDSSach();
            LayDSCTPM();
        }

        //hàm hiển thị danh sách chi tiết phiếu mượn
        private void HienThiDSCTPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select CTPhieuMuon.MaSach, TenSach, SLMuon from CTPhieuMuon inner join Sach on CTPhieuMuon.MaSach = Sach.MaSach where SoPM='"+this.soPM+"'";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();
            adapter.Fill(ds, "DSCTPM");
            dgvDSCTPM.DataSource = ds.Tables["DSCTPM"];
        }

        //hàm lấy danh sách chi tiết phiếu mượn
        private void LayDSCTPM()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from CTPhieuMuon where SoPM = '"+this.soPM+"'";

            adapter1 = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);

            ds1 = new DataSet();
            adapter1.Fill(ds1, "CTPM");
        }

        //hàm lấy danh sách sách để fill vào combobox
        private void LayDSSach()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select MaSach from Sach";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            cbMaSach.Items.Clear();
            while (reader.Read()) {
                cbMaSach.Items.Add(reader.GetString(0));
            }

            reader.Close();
        }

        //hàm xóa dữ liệu
        private void XoaDuLieu()
        {
            txtSLMuon.Text = "";
            txtTenSach.Text = "";
            txtSLTK.Text = "";
            txtTenTG.Text = "";
            txtTenNXB.Text = "";
            cbMaSach.Text = "";
            cbMaSach.Enabled = true;
            err.SetError(txtSLMuon, "");
            err.SetError(txtTenSach, "");
            err.SetError(cbMaSach, "");

        }

        //nút thêm sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            gbNTTS.Enabled= true;
            XoaDuLieu();
            btnThem.Enabled= false;
            chucNang = 1;
        }

        //nút sửa sách
        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            btnSua.Enabled= false;
            btnThem.Enabled = false;
            btnXoa.Enabled= false;
            cbMaSach.Enabled= false;
            gbNTTS.Enabled = true;
        }

        //nút xóa sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa sách này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if(result == DialogResult.Yes)
            {
                DataRow row = ds1.Tables["CTPM"].Rows[index];
                ChinhSuaSLSach(row["MaSach"].ToString(), -(int)row["SLMuon"]);
                row.Delete();
                int kq = adapter1.Update(ds1.Tables["CTPM"]);
                if (kq > 0)
                {
                    gbNTTS.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = true;
                    MessageBox.Show("Xóa sách thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaDuLieu();
                    HienThiDSCTPM();
                }
                else
                {
                    MessageBox.Show("Xóa sách không thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //nếu combobox mã sách thay đổi thì sẽ hiển thị thông tin sách
        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select TenSach, SoLuong, DaMuon, TenTG, TenNXB from Sach inner join TacGia on Sach.MaTG = TacGia.MaTG inner join NXB on Sach.MaNXB = NXB.MaNXB where MaSach='" + cbMaSach.Text + "'";
            sqlCmd.Connection = dbcon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read()) {
                txtTenSach.Text = reader.GetString(0);
                txtSLTK.Text = (reader.GetInt32(1) - reader.GetInt32(2)).ToString();
                txtTenTG.Text = reader.GetString(3);
                txtTenNXB.Text = reader.GetString(4);
            }
            else
            {
                txtTenSach.Text = "";
                txtSLTK.Text = "";
                txtTenTG.Text = "";
                txtTenNXB.Text = "";
            }
        }

        //validate form
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
            else if (checkSoPMAndMaSach(this.soPM, cbMaSach.Text) > 0 && this.chucNang==1)
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
            else if (CheckSLSach(cbMaSach.Text)==0)
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

        //kiểm tra xem mã sách có tồn tại không
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

        //kiểm tra số lượng sách có đủ không
        private int CheckSLSach(string maSach) {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SLMuon from CTPhieuMuon where MaSach='" + maSach + "' and SoPM = '"+ this.soPM+"'";
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

        //kiểm tra xem mã sách đã tồn tại trong phiếu mượn chưa
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

        //nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                if (chucNang == 1)
                {
                    ThemSachMoi();
                }
                else if (chucNang == 2)
                {
                    ChinhSuaSach();
                }
            }
        }

        //hàm thêm sách mới
        private void ThemSachMoi()
        {
            DataRow row = ds1.Tables["CTPM"].NewRow();
            row["SoPM"] = this.soPM;
            row["MaSach"] = cbMaSach.Text;
            row["SLMuon"] = txtSLMuon.Text;
            row["SLTra"] = 0;
            row["TinhTrang"] = "Đang mượn";
            row["NgayTra"] = DBNull.Value;
    

            ds1.Tables["CTPM"].Rows.Add(row);
            int kq = adapter1.Update(ds1.Tables["CTPM"]);
            if (kq > 0) {
                ChinhSuaSLSach(row["MaSach"].ToString(), (int)row["SLMuon"]);
                MessageBox.Show("Thêm sách mới thành công","Hội thoại",MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThem.Enabled = true;
                gbNTTS.Enabled = false;
                XoaDuLieu();
                HienThiDSCTPM();
            }
            else
            {
                MessageBox.Show("Thêm sách mới không thành công", "Hội thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //hàm chỉnh sửa số lượng sách
        private void ChinhSuaSLSach(string maSach, int n)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Sach set DaMuon=DaMuon+" + n + " where MaSach='" + maSach + "'";
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();
        }

        //hàm chỉnh sửa sách
        private void ChinhSuaSach()
        {
            if (index == -1) return;
            DataRow row = ds1.Tables["CTPM"].Rows[index];
            int tmp = (int)row["SLMuon"];
            row.BeginEdit();
            row["SoPM"] = this.soPM;
            row["MaSach"] = cbMaSach.Text;
            row["SLMuon"] = txtSLMuon.Text;
            row["SLTra"] = 0;
            row["TinhTrang"] = "Đang mượn";
            row["NgayTra"] = DBNull.Value;
            row.EndEdit();

            int sl = int.Parse(txtSLMuon.Text) - tmp;

            int kq = adapter1.Update(ds1.Tables["CTPM"]);
            if (kq > 0)
            {
                ChinhSuaSLSach(row["MaSach"].ToString(), sl);
                MessageBox.Show("Chỉnh sửa sách thành công.","Hộp thoại",MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbNTTS.Enabled = false;
                btnThem.Enabled = true;
                XoaDuLieu();
                HienThiDSCTPM();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa sách không thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbNTTS.Enabled=false;
        }

        //nếu click vào cell thì sẽ fill thông tin sách vào form
        private void dgvDSCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index==-1) { return; }
            DataRow row = ds.Tables["DSCTPM"].Rows[index];
            cbMaSach.Text = row["MaSach"].ToString().Trim();
            txtTenSach.Text = row["TenSach"].ToString();
            txtSLMuon.Text = row["SlMuon"].ToString();
            btnSua.Enabled=true;
            btnXoa.Enabled=true;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            InPhieuMuonTra inPhieuMuonTra = new InPhieuMuonTra();
            inPhieuMuonTra.SetSoPM(this.soPM);
            inPhieuMuonTra.ShowDialog();
        }
    }   
}
