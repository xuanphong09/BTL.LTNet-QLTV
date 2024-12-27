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
using System.Xml.Linq;


namespace home
{
    public partial class frmSach : Form
    {

        public frmSach()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void frmSach_Load(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            
            txtDaMuon.Enabled = false;


            LoadDataGridView();
            FillCombo("SELECT * from theloai", cboMaTL, "MaTL", "TenTL");
            cboMaTL.SelectedIndex = -1;

            FillCombo("SELECT * from NXB", cboMaNXB, "MaNXB", "TenNXB");
            cboMaNXB.SelectedIndex = -1;

            FillCombo("SELECT * from tacgia", cboMaTG, "MaTG", "TenTG");
            cboMaTG.SelectedIndex = -1;
            ResetAll();
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql,dbCon.slqCon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Gắn dữ liệu cho ComboBox
            cbo.DataSource = dt;
            cbo.ValueMember = ma; // Trường giá trị
            cbo.DisplayMember = ten; // Trường hiển thị
            dbCon.DongKetNoi();
        }

        private void LoadDataGridView()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from sach";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "DMSach");

            dgvSach.DataSource = ds.Tables["DMSach"];

            dbCon.DongKetNoi();
        }

        private int vt = -1;
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!isEditing)  ClearAllErrors();

            vt = e.RowIndex;
            if (vt < 0 || vt >= ds.Tables["DMSach"].Rows.Count || isEditing)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            DataGridViewRow currentRow = dgvSach.Rows[vt];

            // Gán giá trị cho các trường thông tin
            txtTenSach.Text = currentRow.Cells["TenSach"].Value.ToString();
            txtSoLuong.Text = currentRow.Cells["SoLuong"].Value.ToString();
            txtDaMuon.Text = currentRow.Cells["DaMuon"].Value.ToString();
            txtNamXB.Text = currentRow.Cells["NamXB"].Value.ToString();
            txtGhiChu.Text = currentRow.Cells["GhiChu"].Value.ToString();

            cboMaTL.SelectedValue = currentRow.Cells["MaTL"].Value.ToString();
            cboMaTG.SelectedValue = currentRow.Cells["MaTG"].Value.ToString();
            cboMaNXB.SelectedValue = currentRow.Cells["MaNXB"].Value.ToString();

            // Kích hoạt các nút cần thiết
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtDaMuon.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetAll();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            isEditing = true;
            plTTCT.Enabled=true;
            txtTenSach.Focus();
        }

        private string setMaSach()
        {
            string newMaSach = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand("SELECT TOP 1 MaSach FROM SACH ORDER BY MaSach DESC", dbCon.slqCon);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                string maSach = reader.GetString(0); 
                string number = maSach.Substring(2); 
                int num = int.Parse(number); 
                num++;
                newMaSach = "MS" + num.ToString("D3"); 
            }
            else
            {
                newMaSach = "MS001"; 
            }

            reader.Close();
            dbCon.DongKetNoi();
            return newMaSach;
        }

        private bool FormValidate()
        {
            bool isValid = true;
            Control firstInvalidControl = null;

            if (string.IsNullOrWhiteSpace(txtTenSach.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtTenSach, "Tên sách không được để trống!");
                if (firstInvalidControl == null) firstInvalidControl = txtTenSach;
            }


            if (!int.TryParse(txtSoLuong.Text.Trim(), out _) || int.Parse(txtSoLuong.Text.Trim()) <= 0)
            {
                isValid = false;
                err.SetError(txtSoLuong, "Số lượng phải là số nguyên không âm!");
                if (firstInvalidControl == null) firstInvalidControl = txtSoLuong;
            }

            if (!int.TryParse(txtDaMuon.Text.Trim(), out _) || int.Parse(txtDaMuon.Text.Trim()) < 0)
            {
                isValid = false;
                err.SetError(txtDaMuon, "Số lượng đã mượn phải là số nguyên không âm!");
                if (firstInvalidControl == null) firstInvalidControl = txtDaMuon;
            }

            if(int.TryParse(txtSoLuong.Text.Trim(), out _) && int.TryParse(txtDaMuon.Text.Trim(),out _))
            {
                if (int.Parse(txtSoLuong.Text.Trim()) < int.Parse(txtDaMuon.Text.Trim()))
                {
                    isValid = false;
                    err.SetError(txtDaMuon, "Số lượng mượn vượt quá số lượng sách");
                    if (firstInvalidControl == null) firstInvalidControl = txtSoLuong;
                }
            }

            if (!int.TryParse(txtNamXB.Text.Trim(), out _) || int.Parse(txtNamXB.Text.Trim()) <= 0)
            {
                isValid = false;
                err.SetError(txtNamXB, "Năm xuất bản phải là số nguyên dương!");
                if (firstInvalidControl == null) firstInvalidControl = txtNamXB;
            }

            if (cboMaTL.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaTL, "Vui lòng chọn thể loại!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaTL;
            }

            if (cboMaTG.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaTG, "Vui lòng chọn tác giả!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaTG;
            }

            if (cboMaNXB.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaNXB, "Vui lòng chọn nhà xuất bản!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaNXB;
            }

            firstInvalidControl?.Focus();

            return isValid;
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            isEditing = true;

            // Tạo SqlCommandBuilder để tự động tạo các lệnh INSERT, UPDATE, DELETE
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

            if (btnThem.Enabled && !btnSua.Enabled) // Thêm sách
            {
                if (FormValidate())
                {
                    DataRow row = ds.Tables["DMSach"].NewRow();
                    row["MaSach"] = setMaSach();
                    row["TenSach"] = txtTenSach.Text.Trim();
                    row["SoLuong"] = txtSoLuong.Text.Trim();
                    row["DaMuon"] = 0;
                    txtDaMuon.Enabled = false;
                    row["NamXB"] = txtNamXB.Text.Trim();
                    row["MaTL"] = cboMaTL.SelectedValue.ToString();
                    row["MaTG"] = cboMaTG.SelectedValue.ToString();
                    row["MaNXB"] = cboMaNXB.SelectedValue.ToString();
                    row["GhiChu"] = txtGhiChu.Text.Trim();

                    ds.Tables["DMSach"].Rows.Add(row);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    int kq = adapter.Update(ds.Tables["DMSach"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetAll();
                    }
                }
            }
            else if (!btnThem.Enabled && btnSua.Enabled) // Sửa sách
            {
                if (FormValidate())
                {

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sách này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataRow row = ds.Tables["DMSach"].Rows[vt];
                        row.BeginEdit();
                        row["TenSach"] = txtTenSach.Text.Trim();
                        row["MaTL"] = cboMaTL.SelectedValue.ToString();
                        row["MaTG"] = cboMaTG.SelectedValue.ToString();
                        row["MaNXB"] = cboMaNXB.SelectedValue.ToString();
                        row["NamXB"] = txtNamXB.Text.Trim();
                        row["DaMuon"] = int.Parse(txtDaMuon.Text.Trim());
                        row["SoLuong"] = int.Parse(txtSoLuong.Text.Trim());
                        row["GhiChu"] = txtGhiChu.Text.Trim();
                        row.EndEdit();

                        // Lưu thay đổi vào cơ sở dữ liệu
                        int kq = adapter.Update(ds.Tables["DMSach"]);
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetAll();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ResetAll()
        {
            txtTenSach.Text = "";
            txtSoLuong.Text = "0";
            txtDaMuon.Text = "0";
            txtNamXB.Text = "";
            txtGhiChu.Text = "";
            cboMaTL.SelectedIndex = -1;
            cboMaTG.SelectedIndex = -1;
            cboMaNXB.SelectedIndex = -1;
            txtDaMuon.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            isEditing = false;
            ClearAllErrors();
            LoadDataGridView();
            plTTCT.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            
            DataRow row = ds.Tables["DMSach"].Rows[vt];
            bool isBookInUse = IsBookInUse(row["MaSach"].ToString());

            if (isBookInUse)
            {
                MessageBox.Show("Sách này đang được sử dụng trong hệ thống, không thể xóa!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetAll();
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa sách: '" + row["TenSach"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    // Sử dụng SqlCommandBuilder để tạo DeleteCommand
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Xóa dòng
                    row.Delete();

                    // Cập nhật thay đổi vào cơ sở dữ liệu
                    int kq = adapter.Update(ds.Tables["DMSach"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetAll();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool IsBookInUse(string maSach)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM CTPhieuMuon WHERE MaSach = @maSach";
            sqlCommand.Parameters.AddWithValue("@maSach", maSach);
            sqlCommand.Connection = dbCon.slqCon;

            int kq = (int)sqlCommand.ExecuteScalar();
            dbCon.DongKetNoi();

            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTK.Text))
            {
                ResetAll();
                LoadDataGridView(); // Hiển thị lại toàn bộ dữ liệu
                return;
            }

            // Chuẩn bị câu lệnh tìm kiếm
            string keyword = txtTK.Text.Trim();
            string query = @"SELECT * 
                     FROM Sach
                     WHERE MaSach = @keyword 
                        OR TenSach LIKE N'%' + @keyword + '%' 
                        OR MaTL = @keyword 
                        OR MaTG = @keyword 
                        OR MaNXB = @keyword";

            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            // Sử dụng lại SqlDataAdapter và DataSet chính
            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            adapter.SelectCommand.Parameters.AddWithValue("@keyword", keyword);

            // Xóa dữ liệu cũ trong DataSet và tải dữ liệu tìm kiếm
            ds.Tables["DMSach"].Clear();
            adapter.Fill(ds, "DMSach");

            // Cập nhật DataGridView với dữ liệu tìm kiếm
            dgvSach.DataSource = ds.Tables["DMSach"];

            dbCon.DongKetNoi();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isEditing = false; // Biến trạng thái
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            isEditing = true;
            plTTCT.Enabled = true;
            txtTenSach.Focus();
            if (int.Parse(txtDaMuon.Text) > 0)
            {
                txtDaMuon.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ClearAllErrors()
        {
            err.SetError(txtTenSach, null);
            err.SetError(txtSoLuong, null);
            err.SetError(txtDaMuon, null);
            err.SetError(txtNamXB, null);
            err.SetError(cboMaTL, null);
            err.SetError(cboMaTG, null);
            err.SetError(cboMaNXB, null);
        }
    }
}
