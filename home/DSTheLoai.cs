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
        public frmDanhSachTheLoai()
        {
            InitializeComponent();
        }

        private void frmDanhSachTheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.qLTVDataSet.TheLoai);
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

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
            if (FormValidate())
            {
                DataRow row = ds.Tables["DSTheLoai"].NewRow();
                row["MaTL"] = setMaTL();
                row["TenTL"] = txtTKTenTL.Text.Trim();

                ds.Tables["DSTheLoai"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["DSTheLoai"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thể loại thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm thể loại không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtTKTenTL.Text = "";
            }
        }
        private string setMaTL()
        {
            string newMaTL = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 MaTL from TheLoai order by MaTL desc";
            sqlCmd.Connection = dbCon.slqCon;

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

        int vt = -1;
        private void dgvDSTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            if (vt < ds.Tables["DSTheLoai"].Rows.Count)
            {
                //lay du lieu cua dong duoc chon
                DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
                txtTKTenTL.Text = row["TenTL"].ToString();
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
            }
            else if (vt == ds.Tables["DSTheLoai"].Rows.Count)
            {
                txtTKTenTL.Text = "";
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private bool FormValidate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTKTenTL.Text.Trim()))
            {
                isValid = false;
                error.SetError(txtTKTenTL, "Tên thể loại không được để trống!");
                txtTKTenTL.Focus();
            }
            else
            {
                error.SetError(txtTKTenTL, null);
            }

            return isValid;
        }

        private bool IsEmptyBook(string maTL)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();
            //kiem tra bang phieu phat
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin thể loại này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
                    row.BeginEdit();
                    row["TenTL"] = txtTKTenTL.Text.Trim();
                    row.EndEdit();

                    int kq = adapter.Update(ds.Tables["DSTheLoai"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thể loại thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDanhSach();
                        btnLuu.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTKTenTL.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thể Loại không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["DSTheLoai"].Rows[vt];
            bool isbook = IsEmptyBook(row["MaTL"].ToString());

            if (isbook)
            {
                MessageBox.Show("Tác giả này đang có thông tin trong hệ thống, không thể xóa", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                txtTKTenTL.Text = "";
                HienThiDanhSach();
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa the loai: '" + row["TenTL"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["DSTheLoai"]);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa the loai thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTKTenTL.Text = "";
                        HienThiDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa the loai không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            error.SetError(txtTKTenTL, null);
            if (txtTKTenTL.Text.Trim() != "")
            {
                TimKiemTheoTenTL();
            }
            else
            {
                HienThiDanhSach();
            }
        }

        private void TimKiemTheoTenTL()
        {
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
    }

}
