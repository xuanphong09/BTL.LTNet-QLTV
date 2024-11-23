using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class DanhSachDocGia : Form
    {
        public DanhSachDocGia()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int chucnang = 0;
        int index = -1;

        private void DanhSachDocGia_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDocGia();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            gbTTCT.Enabled = false;
            txtMaDG.Enabled = false;

            //gioi tinh
            cbGender.Items.Clear();
            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");
        }

        private void HienThiDanhSachDocGia()
        {
            DatabaseConnection db = new DatabaseConnection();
            db.MoKetNoi();

            string query = "SELECT * FROM DocGia";
            adapter = new SqlDataAdapter(query, db.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();
            adapter.Fill(ds, "ListReader");

            dgvListReader.DataSource = ds.Tables["ListReader"];

            db.DongKetNoi();
        }

        private void XoaDuLieu()
        {
            txtMaDG.Text = "";
            txtName.Text = "";
            err.SetError(txtName, "");
            txtAddress.Text = "";
            err.SetError(txtAddress, "");
            txtPhone.Text = "";
            err.SetError(txtPhone, "");
            txtNote.Text = "";
            cbGender.Text = "";
            err.SetError(cbGender, "");
        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            chucnang = 1;
            gbTTCT.Enabled = true;
            btnCreate.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvListReader.CellClick -= dgvListReader_CellClick;
            //dgvListReader.Enabled = false;
        }

        private void dgvListReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index == -1) return;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            DataRow row = ds.Tables["ListReader"].Rows[index];
            txtMaDG.Text = row["MaDG"].ToString();
            txtName.Text = row["HoTen"].ToString();
            txtAddress.Text = row["DiaChi"].ToString();
            txtPhone.Text = row["SDT"].ToString();
            txtNote.Text = row["GhiChu"].ToString();
            cbGender.Text = row["GioiTinh"].ToString();
            dtpBod.Value = DateTime.Parse(row["NgaySinh"].ToString());
            dtpStart.Value = DateTime.Parse(row["NgayBDThe"].ToString());
            dtpEnd.Value = DateTime.Parse(row["NgayHHThe"].ToString());

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            gbTTCT.Enabled = true;
            btnCreate.Enabled = false;
            dgvListReader.CellClick -= dgvListReader_CellClick;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                if (chucnang == 1)
                {
                    ThemDocGiaMoi();
                    dgvListReader.CellClick += dgvListReader_CellClick;
                    btnCreate.Enabled = true;
                }
                else if (chucnang == 2)
                {
                    ChinhSuaDocGia();
                    dgvListReader.CellClick += dgvListReader_CellClick;
                    btnCreate.Enabled = true;
                }
            }
        }

        private void ThemDocGiaMoi()
        {
            DataRow row = ds.Tables["ListReader"].NewRow();
            row["MaDG"] = setMaDG();
            row["HoTen"] = txtName.Text.Trim();
            row["NgaySinh"] = dtpBod.Value.Year +"-"+dtpBod.Value.Month + "-" + dtpBod.Value.Day;
            row["DiaChi"] = txtAddress.Text.Trim();
            row["SDT"] = txtPhone.Text.Trim();
            if(cbGender.SelectedIndex==0)
            {
                row["GioiTinh"] = "Nam";
            }
            else
            {
                row["GioiTinh"] = "Nữ";
            }
            row["NgayBDThe"] = dtpStart.Value.Year + "-" + dtpStart.Value.Month + "-" + dtpStart.Value.Day;
            row["NgayHHThe"] = dtpEnd.Value.Year + "-" + dtpEnd.Value.Month + "-" + dtpEnd.Value.Day;
            row["GhiChu"] = txtNote.Text.Trim();

            ds.Tables["ListReader"].Rows.Add(row);
            int kq = adapter.Update(ds, "ListReader");
            if (kq > 0)
            {
                MessageBox.Show("Thêm độc giả mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachDocGia();
                XoaDuLieu();
                gbTTCT.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thêm độc giả mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChinhSuaDocGia()
        {
            if(index == -1)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = ds.Tables["ListReader"].Rows[index];
            row.BeginEdit();
            row["HoTen"] = txtName.Text.Trim();
            row["NgaySinh"] = dtpBod.Value.Year + "-" + dtpBod.Value.Month + "-" + dtpBod.Value.Day;
            row["DiaChi"] = txtAddress.Text.Trim();
            row["SDT"] = txtPhone.Text.Trim();
            if (cbGender.SelectedIndex == 0)
            {
                row["GioiTinh"] = "Nam";
            }
            else
            {
                row["GioiTinh"] = "Nữ";
            }
            row["NgayBDThe"] = dtpStart.Value.Year + "-" + dtpStart.Value.Month + "-" + dtpStart.Value.Day;
            row["NgayHHThe"] = dtpEnd.Value.Year + "-" + dtpEnd.Value.Month + "-" + dtpEnd.Value.Day;
            row["GhiChu"] = txtNote.Text.Trim();
            row.EndEdit();

            int kq = adapter.Update(ds, "ListReader");
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa thông tin độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachDocGia();
                XoaDuLieu();
                gbTTCT.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thông tin độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string setMaDG()
        {
            string newMaDG = "";
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 MaDG from DocGia order by MaDG desc";
            sqlCmd.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                string maTG = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "DG")
                string number = maTG.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newMaDG = "DG" + num.ToString("D3");

            }
            else
            {
                newMaDG = "DG001";
            }
            reader.Close();
            dbCon.DongKetNoi();
            return newMaDG;
        }

        private bool FormValidate()
        {
            bool isValidate = true;

            if(string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                isValidate = false;
                err.SetError(txtName, "Vui lòng nhập tên độc giả");
                txtName.Focus();
            }
            else
            {
                err.SetError(txtName, "");
            }

            if(string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                isValidate = false;
                err.SetError(txtAddress, "Vui lòng nhập địa chỉ");
                txtAddress.Focus();
            }
            else
            {
                err.SetError(txtAddress, "");
            }

            if(string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                isValidate = false;
                err.SetError(txtPhone, "Vui lòng nhập số điện thoại");
                txtPhone.Focus();
            }
            else if (txtPhone.Text.Length !=10)
            {
                isValidate = false;
                err.SetError(txtPhone, "Số điện thoại phải có 10 số");
                txtPhone.Focus();
            }
            else
            {
                err.SetError(txtPhone, "");
            }

            if(string.IsNullOrEmpty(cbGender.Text.Trim()))
            {
                isValidate = false;
                err.SetError(cbGender, "Vui lòng chọn giới tính");
            }
            else
            {
                err.SetError(cbGender, "");
            }


            return isValidate;
        }

        private bool IsEmptyReader(string maDG)
        {
            DatabaseConnection dbcon = new DatabaseConnection();
            dbcon.MoKetNoi();
            //kiem tra bang phieu phat
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.CommandText = "SELECT COUNT(1) FROM PhieuPhat WHERE MaDG = @maDG";
            sqlCommand1.Parameters.AddWithValue("@maDG", maDG);
            sqlCommand1.Connection = dbcon.slqCon;
            int kq1 = (int)sqlCommand1.ExecuteScalar();

            //kiem tra bang phieu muon
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.CommandText = "SELECT COUNT(1) FROM PhieuMuon WHERE MaDG = @maDG";
            sqlCommand2.Parameters.AddWithValue("@maDG", maDG);
            sqlCommand2.Connection = dbcon.slqCon;
            int kq2 = (int)sqlCommand2.ExecuteScalar();
            dbcon.DongKetNoi();
            
            if (kq2 > 0 || kq1 > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbTTCT.Enabled = false;
            HienThiDanhSachDocGia();
            XoaDuLieu();
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvListReader.CellClick += dgvListReader_CellClick;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                DataRow row = ds.Tables["ListReader"].Rows[index];
                if (IsEmptyReader(row["MaDG"].ToString()))
                {
                    row.Delete();
                    int kq = adapter.Update(ds, "ListReader");
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDanhSachDocGia();
                        XoaDuLieu();
                        gbTTCT.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Độc giả này đang có thông tin trong hệ thống, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()!= "")
            {
                DatabaseConnection db = new DatabaseConnection();
                db.MoKetNoi();

                string query = "SELECT * FROM DocGia WHERE MaDG = @maDG or HoTen like N'%"+ txtSearch.Text.Trim()+ "%' or DiaChi like N'%" + txtSearch.Text.Trim() + "%'";
                adapter = new SqlDataAdapter(query, db.slqCon);
                adapter.SelectCommand.Parameters.AddWithValue("@maDG", txtSearch.Text.Trim());
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                ds = new DataSet();
                adapter.Fill(ds, "ListReader");

                dgvListReader.DataSource = ds.Tables["ListReader"];

                db.DongKetNoi();
            }    
            else
            {
                HienThiDanhSachDocGia();
            }
        }

    }
}
