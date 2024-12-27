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
    public partial class DanhSachTacGia : Form
    {
        public DanhSachTacGia()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void DanhSachTacGia_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            HienThiDanhSach();

        }

        private void HienThiDanhSach()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from tacgia";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ListAuthor");

            dgvListAuthor.DataSource = ds.Tables["ListAuthor"];

            dbCon.DongKetNoi();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DataRow row = ds.Tables["ListAuthor"].NewRow();
                row["MaTG"] = setMaTG();
                row["TenTG"] = txtName.Text.Trim();
                row["QueQuan"] = txtCountry.Text.Trim();

                ds.Tables["ListAuthor"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["ListAuthor"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm tác giả thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm tác giả không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtCountry.Text = "";
                txtName.Text = "";
            }
        }

        private string setMaTG()
        {
            string newMaTG="";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 MaTG from TacGia order by MaTG desc";
            sqlCmd.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read()) {
                string maTG = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "TG")
                string number = maTG.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newMaTG = "TG" + num.ToString("D3");

            }
            else
            {
                newMaTG = "TG001";
            }
            reader.Close();
            dbCon.DongKetNoi();
            return newMaTG;
        }

        int vt = -1;
        private void dgvListAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            vt = e.RowIndex;
            if (vt == -1) return;

            if (vt < ds.Tables["ListAuthor"].Rows.Count)
            {
                //lay du lieu cua dong duoc chon
                DataRow row = ds.Tables["ListAuthor"].Rows[vt];
                txtName.Text = row["TenTG"].ToString();
                txtCountry.Text = row["QueQuan"].ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (vt == ds.Tables["ListAuthor"].Rows.Count)
            {
                txtCountry.Text = "";
                txtName.Text = "";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private bool FormValidate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtName, "Tên tác giả không được để trống!");
                txtName.Focus();
            }
            else
            {
                err.SetError(txtName, null);
            }

            if (string.IsNullOrWhiteSpace(txtCountry.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtCountry, "Quê quán không được để trống!");
                txtCountry.Focus();
            }
            else
            {
                err.SetError(txtCountry, null);
            }

            return isValid;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin tác giả này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataRow row = ds.Tables["ListAuthor"].Rows[vt];
                    row.BeginEdit();
                    row["TenTG"] = txtName.Text.Trim();
                    row["QueQuan"] = txtCountry.Text.Trim();
                    row.EndEdit();

                    int kq = adapter.Update(ds.Tables["ListAuthor"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa tác giả thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDanhSach();
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        txtName.Text = "";
                        txtCountry.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa tác giả không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            DataRow row = ds.Tables["ListAuthor"].Rows[vt];
            bool isbook = IsEmptyBook(row["MaTG"].ToString());

            if (isbook)
            {
                MessageBox.Show("Tác giả này đang có thông tin trong hệ thống, không thể xóa", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                txtCountry.Text = "";
                txtName.Text = "";
                HienThiDanhSach();
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa tác giả: '" + row["TenTG"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    row.Delete();

                    int kq = adapter.Update(ds.Tables["ListAuthor"]);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa tác giả thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        txtCountry.Text = "";
                        txtName.Text = "";
                        HienThiDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private bool IsEmptyBook(string maTG)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();
            //kiem tra bang phieu phat
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM Sach WHERE MaTG = @maTG";
            sqlCommand.Parameters.AddWithValue("@maTG", maTG);
            sqlCommand.Connection = dbcon.slqCon;
            int kq = (int)sqlCommand.ExecuteScalar();
            dbcon.DongKetNoi();
            if (kq > 0)
            {
                return true;
            }
            else return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            err.SetError(txtName, null);
            err.SetError(txtCountry, null);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            if (txtName.Text.Trim() != "" && txtCountry.Text.Trim()=="")
            {
                TimKiemTheoTenTG();
            }
            else if (txtName.Text.Trim() == "" && txtCountry.Text.Trim() != "")
            {
                TimKiemTheoQueQuan();
            }
            else if (txtName.Text.Trim() != "" && txtCountry.Text.Trim() != "")
            {
                TimKiemTheoTenTG();
            }
            else
            {
                HienThiDanhSach();
            }
        }

        private void TimKiemTheoTenTG()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from tacgia where TenTG like N'%" +txtName.Text.Trim() +"%'";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ListAuthor");

            dgvListAuthor.DataSource = ds.Tables["ListAuthor"];

            dbCon.DongKetNoi();
        }
        private void TimKiemTheoQueQuan()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();

            string query = "select * from tacgia where QueQuan like N'%" + txtCountry.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(query, dbCon.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ListAuthor");

            dgvListAuthor.DataSource = ds.Tables["ListAuthor"];

            dbCon.DongKetNoi();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCountry.Text = "";
            txtName.Text = "";
            HienThiDanhSach();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            err.SetError(txtName, null);
            err.SetError(txtCountry, null);
        }
    }
}
