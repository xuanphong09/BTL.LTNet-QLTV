using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace home
{
    public partial class DanhSachTaiKhoan : Form
    {
        private int checkCN = 0;
        // Tạo đối tượng kết nối với cơ sở dữ liệu
        DatabaseConnection dbCon { set; get; } = new DatabaseConnection();
        SqlCommand sqlCmd { set; get; }

        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        string MaNV = "";
        public void setMaNV(string maNV)
        {
            this.MaNV = maNV;
        }

        private void DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            //an cac groupbox va button
            groupBox3.Enabled = false;
            btnEdit.Enabled = false;
            btnChangePass.Enabled = false;
            btnDelete.Enabled = false;

            FillDuLieuCmbTieuChi();
            cmTieuChiTK.SelectedIndex = 0;
            

        }

        private void FillDuLieuCmbTieuChi()
        {

            //lay gia tri co comboBox Role tim kiem
            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "getListRole";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader rd = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();

            DataRow row = dt.NewRow();
            row[dt.Columns[0].ColumnName] = ""; // Value to represent "no selection"
            row[dt.Columns[1].ColumnName] = "Chọn tiêu chí"; // Default text
            dt.Rows.InsertAt(row, 0);

            //thêm các trạng thái
            row = dt.NewRow();
            row[dt.Columns[0].ColumnName] = 0;
            row[dt.Columns[1].ColumnName] = "Hoạt động";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[dt.Columns[0].ColumnName] = -1;
            row[dt.Columns[1].ColumnName] = "Bị khóa";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[dt.Columns[0].ColumnName] = -2;
            row[dt.Columns[1].ColumnName] = "Đã xóa";
            dt.Rows.Add(row);

            cmTieuChiTK.DataSource = dt;
            cmTieuChiTK.DisplayMember = dt.Columns[1].ColumnName;
            cmTieuChiTK.ValueMember = dt.Columns[0].ColumnName;
        }


        private void DanhSachTaiKhoan_Activated(object sender, EventArgs e)
        {
            // Xóa các mục cũ khỏi ListView để tránh trùng lặp
            livListAcc.Items.Clear();

            // Tạo đối tượng truy van
            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "getListAccount";
            sqlCmd.Connection = dbCon.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            {
                while (reader.Read())
                {
                    string maNV = reader.GetString(0);
                    string userName = reader.GetString(1);
                    string phone = reader.GetString(3);
                    string work = reader.GetString(6);
                    string note = reader.GetString(8);
                    string role = reader.GetString(9);

                    ListViewItem liv = new ListViewItem(maNV);
                    liv.SubItems.Add(userName); 
                    liv.SubItems.Add(work);
                    liv.SubItems.Add(role);
                    liv.SubItems.Add(phone);
                    liv.SubItems.Add(note);

                    livListAcc.Items.Add(liv);
                }
            }
            reader.Close();

            //lay gia tri co comboBox Role
            sqlCmd.CommandText = "getListRole";
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader rd = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cbRole.DataSource = dt;
            cbRole.DisplayMember = dt.Columns[1].ColumnName;
            cbRole.ValueMember = dt.Columns[0].ColumnName;
            cbRole.SelectedIndex = -1;
            // Đóng kết nối
            dbCon.DongKetNoi();  // Đóng kết nối sau khi hoàn tất
            cmTieuChiTK.SelectedIndex = 0;
        }

        private void livListAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (livListAcc.SelectedItems.Count == 0)
            {
                RemoveInforOnForm();
                btnEdit.Enabled = false;
                btnChangePass.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }

            ListViewItem liv = livListAcc.SelectedItems[0];
            string maNV = liv.SubItems[0].Text;

            //lay du lieu tu csdl
            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "getItemAccount";
            sqlCmd.Parameters.AddWithValue("@maNV", maNV);
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaNV.Text = reader.GetString(0);
                txtUserName.Text = reader.GetString(1);
                txtName.Text = reader.GetString(2);
                txtPhone.Text = reader.GetString(3);
                txtEmail.Text = reader.GetString(4);
                txtAddress.Text = reader.GetString(5);
                txtWork.Text = reader.GetString(6);
                txtCreateAt.Text = reader.GetDateTime(7).ToString("MM/dd/yyyy");
                txtNote.Text = reader.GetString(8);
                cbRole.Text = reader.GetString(9);

                cbState.Items.Clear();
                cbState.Items.Add("Hoạt động");
                cbState.Items.Add("Bị khóa");
                if (reader.GetInt32(10) == -2) cbState.Items.Add("Đã xóa");

                if (reader.GetInt32(10)==-1) cbState.SelectedIndex = 1;
                else if (reader.GetInt32(10) == -2) cbState.SelectedIndex = 2;
                else cbState.SelectedIndex = 0;
            }
            reader.Close();
            dbCon.DongKetNoi();
            btnEdit.Enabled = true;
            btnChangePass.Enabled = true;
            
            if(txtMaNV.Text.Trim() == MaNV)
            {
                btnDelete.Enabled = false;
            }
            else btnDelete.Enabled = true;

            if(cbState.SelectedIndex == 2)
            {
                btnChangePass.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnCreate.Enabled = false;
            btnChangePass.Enabled = false;
            btnDelete.Enabled = false;
            txtMaNV.Enabled = false;
            txtUserName.Enabled = false;
            txtCreateAt.Enabled = false;
            livListAcc.SelectedIndexChanged -= livListAcc_SelectedIndexChanged; // không cho kick chọn danh sách nữa
            checkCN = 2;
            if (txtMaNV.Text.Trim() == MaNV)
            {
                cbRole.Enabled = false;
                cbState.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            lbMaNV.Text = "Mã nhân viên: ";
            lbUserName.Text = "Tên đăng nhập: ";
            btnChangePass.Enabled = true;
            btnCreate.Enabled = true;
            btnEdit.Enabled = false;
            btnChangePass.Enabled = false;
            livListAcc.SelectedIndexChanged += livListAcc_SelectedIndexChanged;
            cbState.Enabled=true;
            cbRole.Enabled=true;
            RemoveInforOnForm();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            RemoveInforOnForm();
            groupBox3.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnChangePass.Enabled = false;
            txtMaNV.Enabled = true;
            txtUserName.Enabled = true;
            txtCreateAt.Enabled = false;
            cbState.Enabled= false;
            label11.Enabled = false;
            lbMaNV.Text = "Tên đăng nhập: ";
            lbUserName.Text = "Mật khẩu: ";
            livListAcc.SelectedIndexChanged -= livListAcc_SelectedIndexChanged; // Unsubscribe event handler
            checkCN = 1;
            cbRole.SelectedIndex = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkCN == 1)
            {
                if (FormValidate())
                {
                    SaveAccount();
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);

                }
                
            } 
            else if (checkCN == 2)
            {
                if (FormValidate())
                {
                    EditAccount();
                    MessageBox.Show("Chỉnh sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
            }
        }

        //ham xóa thông tin trên form
        private void RemoveInforOnForm()
        {
            txtMaNV.Text="";
            txtMaNV.BackColor = Color.White;
            err.SetError(txtMaNV, null);
            txtUserName.Text = "";
            err.SetError(txtUserName, null);
            txtName.Text = "";
            err.SetError(txtName, null);
            txtPhone.Text = "";
            err.SetError(txtPhone, null);
            txtEmail.Text = "";
            err.SetError(txtEmail, null);
            txtAddress.Text = "";
            txtWork.Text = "";
            txtCreateAt.Text = "";
            txtNote.Text = "";
            cbRole.Text = "";
            err.SetError(cbRole, null);
            cbState.Enabled= true;
            cbState.Items.Clear();
        }

        //ham luu thong tin tai khoan
        private void SaveAccount()
        {
            //lay du lieu tu form
            string maNV = SetMaNV();
            string userName = txtMaNV.Text.Trim();
            string pass = txtUserName.Text.Trim();
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string work = txtWork.Text.Trim();
            string note = txtNote.Text.Trim();
            string role = cbRole.SelectedValue.ToString();

            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;

            //them du lieu vao bang tai khoan
            sqlCmd.CommandText = "[insertDataTaiKhoan]";
            sqlCmd.Parameters.AddWithValue("@maNV", maNV);
            sqlCmd.Parameters.AddWithValue("@userName", userName);
            sqlCmd.Parameters.AddWithValue("@passWord", pass);
            sqlCmd.Parameters.AddWithValue("@role_id", role);
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();

            //them du lieu vao bang nhan vien
            sqlCmd.CommandText = "[insertDataNhanVien]";
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.AddWithValue("@maNV", maNV);
            sqlCmd.Parameters.AddWithValue("@name", name);
            sqlCmd.Parameters.AddWithValue("@phone", phone);
            sqlCmd.Parameters.AddWithValue("@email", email);
            sqlCmd.Parameters.AddWithValue("@address", address);
            sqlCmd.Parameters.AddWithValue("@work", work);
            sqlCmd.Parameters.AddWithValue("@note", note);
            sqlCmd.Connection = dbCon.slqCon;
            sqlCmd.ExecuteNonQuery();

            dbCon.MoKetNoi();

        }

        //ham sua thong tin tai khoan
        private void EditAccount()
        {
            //lay du lieu tu for
            string maNV = txtMaNV.Text.Trim();
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string work = txtWork.Text.Trim();
            string note = txtNote.Text.Trim();
            string role = cbRole.SelectedValue.ToString();
            int state;
            if (cbState.SelectedIndex == 1) state = -1;//bị khóa
            else if (cbState.SelectedIndex == 2) state = -2;//đã xóa
            else state = 0;//hoạt động

            DatabaseConnection db = new DatabaseConnection();
            db.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;

            //chinh sua du lieu vao bang tai khoan
            sqlCmd.CommandText = "[updateDataTaiKhoan]";
            sqlCmd.Parameters.AddWithValue("@maNV", maNV);
            sqlCmd.Parameters.AddWithValue("@role_id", role); 
            sqlCmd.Parameters.AddWithValue("@state", state);// Add state parameter
            sqlCmd.Connection = db.slqCon;
            sqlCmd.ExecuteNonQuery();

            //chinh sua du lieu vao bang nhan vien
            sqlCmd.CommandText = "[updateDataNhanVien]";
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.AddWithValue("@maNV", maNV);
            sqlCmd.Parameters.AddWithValue("@name", name);
            sqlCmd.Parameters.AddWithValue("@phone", phone);
            sqlCmd.Parameters.AddWithValue("@email", email);
            sqlCmd.Parameters.AddWithValue("@address", address);
            sqlCmd.Parameters.AddWithValue("@work", work);
            sqlCmd.Parameters.AddWithValue("@note", note);
            
            sqlCmd.Connection = db.slqCon;
            sqlCmd.ExecuteNonQuery();
            db.MoKetNoi();
        }

        //ham lay manv cuoi cung rồi tăng lên 1 -  ham tự động tăng/sinh mã nv mới
        public string SetMaNV()
        {
            DatabaseConnection db = new DatabaseConnection();
            db.MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 1 MaNV from NhanVien order by MaNV desc";
            sqlCmd.Connection = db.slqCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            string newMaNV = "";
            if (reader.Read())
            {
                string maNV = reader.GetString(0);
                // Tách phần số từ mã cuối cùng (bỏ phần tiền tố "NV")
                string number = maNV.Substring(2);
                int num = int.Parse(number);// chuyển chuỗi thành số
                num++;
                newMaNV = "NV" + num.ToString("D3");
            }
            else
            {
                newMaNV = "NV001";
            }
            reader.Close();
            db.DongKetNoi();
            return newMaNV;
        }

        private bool FormValidate()
        {
            bool isValid = true;
            //xác thực họ tên
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtName, "Họ tên không được để trống");
                txtName.Focus();
            }
            else
            {
                err.SetError(txtName, null);
            }

            //xác thực số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhone.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không được để trống");
                txtPhone.Focus();
            }
            else if (txtPhone.Text.Length != 10)
            {
                isValid = false;
                err.SetError(txtPhone, "Số điện thoại không hợp lệ");
                txtPhone.Focus();
            }
            else
            {
                err.SetError(txtPhone, null);
            }

            //xác thực email
            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtEmail, "Email không được để trống");
                txtEmail.Focus();
            }
            else if (!txtEmail.Text.Trim().EndsWith("@gmail.com"))
            {
                isValid = false;
                err.SetError(txtEmail, "Email không hợp lệ.");
                txtEmail.Focus();
            }
            else
            {
                err.SetError(txtEmail, null);
            }

            //xác thực tên đăng nhập
            if(string.IsNullOrWhiteSpace(txtMaNV.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtMaNV, "Tên đăng nhập không được để trống");
                txtMaNV.Focus();
            }
            else
            {
                err.SetError(txtUserName, null);
            }

            //xác thực mật khẩu
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                isValid = false;
                err.SetError(txtUserName, "Mật khẩu không được để trống");
                txtUserName.Focus();
            }
            else
            {
                err.SetError(txtUserName, null);
            }


            return isValid;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (livListAcc.SelectedItems.Count == 0) return;

            ListViewItem liv = livListAcc.SelectedItems[0];
            string maNV = liv.SubItems[0].Text;
            string userName = liv.SubItems[1].Text;

            DoiMatKhauAdmin dmk = new DoiMatKhauAdmin();
            dmk.maNV = maNV;
            dmk.userName = userName;
            dmk.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (livListAcc.SelectedItems.Count == 0) return;

            ListViewItem liv = livListAcc.SelectedItems[0];
            string maNV = liv.SubItems[0].Text;
            string userName = liv.SubItems[1].Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản có tên là: '"+userName+"' không?","Hộp thoại",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                dbCon.MoKetNoi();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "deleteDataTaiKhoan";
                sqlCmd.Parameters.AddWithValue("@maNV", maNV);
                sqlCmd.Connection = dbCon.slqCon;
                int count = (int)sqlCmd.ExecuteNonQuery();
                dbCon.DongKetNoi();

                if (count > 0) {
                    MessageBox.Show("Xóa tài khoản "+userName+" thành công.","Hộp thoại",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    RemoveInforOnForm();
                    btnEdit.Enabled = false;
                    btnChangePass.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản " + userName + " không thành công.", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            livListAcc.Items.Clear();
            btnEdit.Enabled = false;
            btnChangePass.Enabled = false;
            btnDelete.Enabled = false;
            RemoveInforOnForm();
            string search = "%"+txtSearch.Text.Trim()+"%";
            string tieuChi = cmTieuChiTK.SelectedValue.ToString();

            dbCon.MoKetNoi();
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Clear();
            if (tieuChi == "")
            {
                sqlCmd.CommandText = "[SearchAccount]";
                sqlCmd.Parameters.AddWithValue("@txtSearch", search);
            }
            else
            {
                sqlCmd.CommandText = "[SearchRoleAccount]";
                sqlCmd.Parameters.AddWithValue("@txtSearch", search);
                sqlCmd.Parameters.AddWithValue("@tieuChi", tieuChi);
            }
            sqlCmd.Connection = dbCon.slqCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            {
                while (reader.Read())
                {
                    string maNV = reader.GetString(0);
                    string userName = reader.GetString(1);
                    string phone = reader.GetString(3);
                    string work = reader.GetString(6);
                    string note = reader.GetString(8);
                    string role = reader.GetString(9);

                    ListViewItem liv = new ListViewItem(maNV);
                    liv.SubItems.Add(userName);
                    liv.SubItems.Add(work);
                    liv.SubItems.Add(role);
                    liv.SubItems.Add(phone);
                    liv.SubItems.Add(note);

                    livListAcc.Items.Add(liv);
                }
            }
            reader.Close();



            dbCon.DongKetNoi();
        }
    }
}
