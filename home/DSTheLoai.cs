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
    public partial class frmDanhSachTheLoai : Form
    {
        private bool isEditing;
        public frmDanhSachTheLoai()
        {
            InitializeComponent();
        }

        private void frmDanhSachTheLoai_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            grbTTCT.Enabled = false;
            HienThiDanhSach();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void HienThiDanhSach()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from theloai";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "DSTheLoai");

            dgvDSTheLoai.DataSource = ds.Tables["DSTheLoai"];

            dbCon.DongKetNoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetAll();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            isEditing = true;
            grbTTCT.Enabled = true;
            dgvDSTheLoai.CellClick -= dgvDSTheLoai_CellClick;
            txtTenTL.Focus();
        }

        private string setMaTL()
        {
            string newMaTL = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("select top 1 MaTL from TheLoai order by MaTL desc", dbCon.slqCon);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                string maTL = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "TG")
                string number = maTL.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newMaTL = "TL" + num.ToString("D3");
            }
            else
            {
                newMaTL = "TL001";
            }
            reader.Close();
            dbCon.DongKetNoi();
            return newMaTL;
        }

        private bool FormValidate()
        {
            bool isValid = true;

            // Kiểm tra tên thể loại trống
            if (string.IsNullOrWhiteSpace(txtTenTL.Text.Trim()))
            {
                isValid = false;
                error.SetError(txtTenTL, "Tên thể loại không được để trống!");
                txtTenTL.Focus();
            }
            else if (IsCategory(txtTenTL.Text.Trim()) && btnThem.Enabled && !btnSua.Enabled) // Kiểm tra tên thể loại đã tồn tại
            {
                isValid = false;
                error.SetError(txtTenTL, "Tên thể loại đã tồn tại!");
                txtTenTL.Focus();
            }
            else if (IsCategory(txtTenTL.Text.Trim()) && !btnThem.Enabled && btnSua.Enabled) // Kiểm tra tên thể loại đã tồn tại
            {
                isValid = false;
                error.SetError(txtTenTL, "Tên thể loại đã tồn tại!");
                txtTenTL.Focus();
            }
            else
            {
                error.SetError(txtTenTL, null); // Xóa lỗi nếu hợp lệ
            }

            return isValid;
        }

        private bool IsEmptyBook(string maTL)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();
            //kiem tra bang sach
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM Sach WHERE MaTL = @maTL";
            sqlCommand.Parameters.AddWithValue("@maTL", maTL);
            sqlCommand.Connection = dbcon.slqCon;
            int kq = (int)sqlCommand.ExecuteScalar();
            dbcon.DongKetNoi();
            if (kq > 0)
            {
                return true;
            }
            else return false;
        }

        private bool IsCategory(string tenTL)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();

            // Kiểm tra trong bảng thể loại
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM theloai WHERE TenTL = @tenTL";
            sqlCommand.Parameters.AddWithValue("@tenTL", tenTL);
            sqlCommand.Connection = dbcon.slqCon;

            int kq = (int)sqlCommand.ExecuteScalar();
            dbcon.DongKetNoi();

            return kq > 0; // Nếu số lượng > 0, tức là thể loại đã tồn tại
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            isEditing = true;
            if (btnThem.Enabled && !btnSua.Enabled) // Thêm thể loại
            {
                if (FormValidate()) // Nếu thông tin hợp lệ
                {
                    DataRow row = ds.Tables["DSTheLoai"].NewRow();
                    row["MaTL"] = setMaTL(); // Tạo mã thể loại mới
                    row["TenTL"] = txtTenTL.Text.Trim();

                    ds.Tables["DSTheLoai"].Rows.Add(row);

                    int kq = adapter.Update(ds.Tables["DSTheLoai"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thể loại thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thể loại không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (!btnThem.Enabled && btnSua.Enabled) // Sửa thể loại
            {
                if (FormValidate()) //Sửa thông tin
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin thể loại này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
                        row.BeginEdit();
                        row["TenTL"] = txtTenTL.Text.Trim();
                        row.EndEdit();

                        int kq = adapter.Update(ds.Tables["DSTheLoai"]);
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thể loại thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiDanhSach();
                            ResetAll();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thể Loại không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearErr();
            if (vt == -1)
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
            bool isbook = IsEmptyBook(row["MaTL"].ToString());

            if (isbook)
            {
                MessageBox.Show("Thể loại này đang có thông tin trong hệ thống, không thể xóa", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetAll();
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa thể loại: '" + row["TenTL"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["DSTheLoai"]);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thể loại thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetAll();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thể loại không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetAll();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ResetAll();
            if (string.IsNullOrWhiteSpace(txtTKTenTL.Text))
            {
                ResetAll();
                HienThiDanhSach();
                return;
            }

            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from theloai where TenTL like N'%" + txtTKTenTL.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "DSTheLoai");

            dgvDSTheLoai.DataSource = ds.Tables["DSTheLoai"];

            dbCon.DongKetNoi();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void clearErr()
        {
            error.SetError(txtTenTL,null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEditing = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            grbTTCT.Enabled = true;
            txtMaTL.Enabled = false;
            txtTenTL.Focus();
            dgvDSTheLoai.CellClick -= dgvDSTheLoai_CellClick;
        }

        private void ResetAll()
        {
            isEditing =false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            grbTTCT.Enabled = false;
            txtMaTL.Enabled = false;
            error.SetError(txtTenTL,null);
            txtTenTL.Text = "";
            txtMaTL.Text = "";
            dgvDSTheLoai.CellClick += dgvDSTheLoai_CellClick;
            HienThiDanhSach();
            clearErr();
        }

        int vt = -1;
        private void dgvDSTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (isEditing) return; 
            if (vt == -1) return;

            if (vt < ds.Tables["DSTheLoai"].Rows.Count)
            {
                //lay du lieu cua dong duoc chon
                DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
                txtTenTL.Text = row["TenTL"].ToString();
                txtMaTL.Text = row["MaTL"].ToString();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                grbTTCT.Enabled = false;
            }
            else if (vt == ds.Tables["DSTheLoai"].Rows.Count)
            {
                txtMaTL.Text = "";
                txtTenTL.Text = "";
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
    }

}
