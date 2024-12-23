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
            ResetValues();
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            if (string.IsNullOrEmpty(sql) || string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                throw new ArgumentException("Tham số không được để trống.");
            }

            if (cbo == null)
            {
                throw new ArgumentNullException(nameof(cbo), "ComboBox không được null.");
            }

            try
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                using (SqlConnection sqlCon = new SqlConnection(dbCon.strCon))
                {
                    SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
                    DataTable table = new DataTable();
                    dap.Fill(table);

                    // Kiểm tra dữ liệu
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo");
                        return;
                    }

                    // Gắn dữ liệu cho ComboBox
                    cbo.DataSource = table;
                    cbo.ValueMember = ma; // Trường giá trị
                    cbo.DisplayMember = ten; // Trường hiển thị
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void ResetValues()
        {
            txtTenSach.Text = "";
            txtSoLuong.Text = "0";
            txtDaMuon.Text = "0";
            txtNamXB.Text = "";
            txtGhiChu.Text = "";
            cboMaTL.Text = "";
            cboMaTG.Text = "";
            cboMaNXB.Text = "";
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
            ClearAllErrors();
            if (e.RowIndex < 0 || e.RowIndex >= ds.Tables["DMSach"].Rows.Count)
            {
                ResetValues();
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                txtDaMuon.Enabled = false;
                return;
            }

            vt = e.RowIndex;

            DataRow row = ds.Tables["DMSach"].Rows[vt];
            txtTenSach.Text = row["TenSach"].ToString();
            txtSoLuong.Text = row["SoLuong"].ToString();
            txtDaMuon.Text = row["DaMuon"].ToString();
            txtNamXB.Text = row["NamXB"].ToString();
            txtGhiChu.Text = row["GhiChu"].ToString();

            cboMaTL.SelectedValue = row["MaTL"].ToString();
            cboMaTG.SelectedValue = row["MaTG"].ToString();
            cboMaNXB.SelectedValue = row["MaNXB"].ToString();

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtDaMuon.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            ResetFields();
            plTTCT.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtDaMuon.Enabled=false;
            dgvSach.CellClick -= dgvSach_CellClick;
            txtTenSach.Focus();
        }

        private string setMaSach()
        {
            string newMaSach = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 MaSach FROM SACH ORDER BY MaSach DESC";
            sqlCmd.Connection = dbCon.slqCon;

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
            else
            {
                err.SetError(txtTenSach, null);
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out _) || int.Parse(txtSoLuong.Text.Trim()) <= 0)
            {
                isValid = false;
                err.SetError(txtSoLuong, "Số lượng phải lớn hơn 0!");
                if (firstInvalidControl == null) firstInvalidControl = txtSoLuong;
            }
            else
            {
                err.SetError(txtSoLuong, null);
            }

            if (!int.TryParse(txtDaMuon.Text.Trim(), out _) || int.Parse(txtDaMuon.Text.Trim()) < 0)
            {
                isValid = false;
                err.SetError(txtDaMuon, "Số lượng đã mượn phải là số nguyên không âm!");
                if (firstInvalidControl == null) firstInvalidControl = txtDaMuon;
            }
            else
            {
                err.SetError(txtDaMuon, null);
            }

            if (!int.TryParse(txtNamXB.Text.Trim(), out _) || int.Parse(txtNamXB.Text.Trim()) <= 0)
            {
                isValid = false;
                err.SetError(txtNamXB, "Năm xuất bản phải là số nguyên dương!");
                if (firstInvalidControl == null) firstInvalidControl = txtNamXB;
            }
            else
            {
                err.SetError(txtNamXB, null);
            }

            if (cboMaTL.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaTL, "Vui lòng chọn thể loại!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaTL;
            }
            else
            {
                err.SetError(cboMaTL, null);
            }

            if (cboMaTG.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaTG, "Vui lòng chọn tác giả!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaTG;
            }
            else
            {
                err.SetError(cboMaTG, null);
            }

            if (cboMaNXB.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(cboMaNXB, "Vui lòng chọn nhà xuất bản!");
                if (firstInvalidControl == null) firstInvalidControl = cboMaNXB;
            }
            else
            {
                err.SetError(cboMaNXB, null);
            }

            firstInvalidControl?.Focus();

            return isValid;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled && !btnSua.Enabled) // Thêm sách
            {
                if (FormValidate())
                {
                    if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || !int.TryParse(txtNamXB.Text.Trim(), out int namXB))
                    {
                        MessageBox.Show("Số lượng và Năm xuất bản phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DataRow row = ds.Tables["DMSach"].NewRow();
                    row["MaSach"] = setMaSach();
                    row["TenSach"] = txtTenSach.Text.Trim();
                    row["SoLuong"] = soLuong;
                    row["DaMuon"] = 0;
                    txtDaMuon.Enabled = false;
                    row["NamXB"] = namXB;
                    row["MaTL"] = cboMaTL.SelectedValue.ToString();
                    row["MaTG"] = cboMaTG.SelectedValue.ToString();
                    row["MaNXB"] = cboMaNXB.SelectedValue.ToString();
                    row["GhiChu"] = txtGhiChu.Text.Trim();

                    try
                    {
                        ds.Tables["DMSach"].Rows.Add(row);
                        int kq = adapter.Update(ds.Tables["DMSach"]);
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView();
                            ResetFields();
                        }
                        else
                        {
                            MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                plTTCT.Enabled = false;
            }
            else if (!btnThem.Enabled && btnSua.Enabled) // Sửa sách
            {
                if (vt == -1)
                {
                    MessageBox.Show("Vui lòng chọn sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.Parse(txtSoLuong.Text) < int.Parse(txtDaMuon.Text))
                {
                    MessageBox.Show("Số lượng mượn không được vượt quá số lượng sách!", "Lỗi dữ liệu");
                    return;
                }

                if (FormValidate())
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sách này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
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

                            int kq = adapter.Update(ds.Tables["DMSach"]);
                            if (kq > 0)
                            {
                                MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataGridView();
                                ResetFields();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thông tin sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                btnThem.Enabled=true;
                btnLuu.Enabled=false;
                btnXoa.Enabled=false;
                btnSua.Enabled=false;
                dgvSach.CellClick += dgvSach_CellClick;
            }
        }

        private void ResetFields()
        {
            txtTenSach.Text = "";
            txtSoLuong.Text = "0";
            txtDaMuon.Text = "0";
            txtNamXB.Text = "";
            txtGhiChu.Text = "";
            cboMaTL.SelectedIndex = -1;
            cboMaTG.SelectedIndex = -1;
            cboMaNXB.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            if (vt == -1)
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = ds.Tables["DMSach"].Rows[vt];
            bool isBookInUse = IsBookInUse(row["MaSach"].ToString());

            if (isBookInUse)
            {
                MessageBox.Show("Sách này đang được sử dụng trong hệ thống, không thể xóa!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFields();
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                LoadDataGridView();
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa sách: '" + row["TenSach"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["DMSach"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFields();
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = false;
                        LoadDataGridView();
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
                LoadDataGridView();
                return;
            }

            DatabaseConnection database = new DatabaseConnection();
            database.MoKetNoi();

            try
            {
                string query = @"SELECT MaSach, TenSach, SoLuong, DaMuon, NamXB, MaTL, MaTG, MaNXB, GhiChu 
                         FROM Sach
                         WHERE MaSach = @keyword 
                            OR TenSach LIKE N'%' + @keyword + '%' 
                            OR MaTL = @keyword 
                            OR MaTG = @keyword 
                            OR MaNXB = @keyword";

                using (SqlCommand cmd = new SqlCommand(query, database.slqCon))
                {
                    cmd.Parameters.AddWithValue("@keyword", txtTK.Text.Trim());

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Sach");

                        dgvSach.DataSource = ds.Tables["Sach"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            finally
            {
                database.DongKetNoi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            plTTCT.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvSach.CellClick -= dgvSach_CellClick;
            txtTenSach.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            plTTCT.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled= true;
            txtDaMuon.Enabled = false;
            dgvSach.CellClick += dgvSach_CellClick;
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
