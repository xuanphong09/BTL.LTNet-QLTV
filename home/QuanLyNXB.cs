using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class QuanLyNXB : Form
    {
        public QuanLyNXB()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        DatabaseConnection conn = new DatabaseConnection();
        int currRow;
        int flag;

        private void QuanLyNXB_Load(object sender, EventArgs e)
        {
            loadData();
            saveBtn.Enabled = false;    
            cancelBtn.Enabled = false;    
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;  
        }

        private void loadData()
        {
            conn.MoKetNoi();

            string querry = "select * from NXB";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "NXB_DS");

            NXBList.DataSource = ds.Tables["NXB_DS"];


            conn.DongKetNoi();

        }

        private void NXBList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             currRow = e.RowIndex;

            if (currRow <= ds.Tables["NXB_DS"].Rows.Count - 1 && currRow>=0)
            {
                DataRow row = ds.Tables["NXB_DS"].Rows[currRow];
                nameTB.Text = row["TenNXB"].ToString();
                addressTB.Text = row["DiaChi"].ToString();
                emailTB.Text = row["Email"].ToString();

                deleteBtn.Enabled = true;
                updateBtn.Enabled = true;
            }
             else
            {
                nameTB.Text = "";
                addressTB.Text = "";
                emailTB.Text = "";

            }

        }

        private void createNXB()
        {
            conn.MoKetNoi();

            DataRow row = ds.Tables["NXB_DS"].NewRow();
            row["MaNXB"] = generateMaNXB();
            row["TenNXB"] = nameTB.Text.Trim();
            row["DiaChi"] = addressTB.Text.Trim();
            row["Email"] = emailTB.Text.Trim();

            ds.Tables["NXB_DS"].Rows.Add(row);

            int res = adapter.Update(ds.Tables["NXB_DS"]);

            if (res > 0)
            {
                MessageBox.Show("Thêm NXB thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm NXb k.o thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            nameTB.Text = "";
            addressTB.Text = "";
            emailTB.Text = "";
            saveBtn.Enabled = false;

            conn.DongKetNoi();
        }

        private string generateMaNXB()
        {
            string newMaNXB;

            conn.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select top 1 MaNXB from NXB Order by MaNXB desc";
            cmd.Connection = conn.slqCon;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string fugue = dr.GetString(0).Substring(3);
                int num = int.Parse(fugue) + 1;
                newMaNXB = "NXB" + num.ToString("D2");

            }
            else
            {
                newMaNXB = "NXB01";

            }

            dr.Close();
            conn.DongKetNoi();
            return newMaNXB;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            flag = 1;
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;

            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            addBtn.Enabled = false;

            NXBList.CellClick -= NXBList_CellClick;

            nameTB.Text = "";
            addressTB.Text = "";
            emailTB.Text = "";
        }


        private void updateNXB()
        {
            conn.MoKetNoi();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin NXB này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataRow row = ds.Tables["NXB_DS"].Rows[currRow];
                row.BeginEdit();
                row["TenNXB"] = nameTB.Text.Trim();
                row["DiaChi"] = addressTB.Text.Trim();
                row["Email"] = emailTB.Text.Trim();
                row.EndEdit();
            
                int res = adapter.Update(ds.Tables["NXB_DS"]);

                if (res > 0)
                {
                    MessageBox.Show("Sửa NXB thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                    nameTB.Text = "";
                    addressTB.Text = "";
                    emailTB.Text = "";

                    saveBtn.Enabled = false;
                    cancelBtn.Enabled = false;
                    updateBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa NXB kh thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            conn.DongKetNoi();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            flag = 2;
            saveBtn.Enabled=true;
            cancelBtn.Enabled=true;

            updateBtn.Enabled=false;
            deleteBtn.Enabled=false;
            addBtn.Enabled=false;

            NXBList.CellClick -= NXBList_CellClick;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            Boolean validate = true;
            if (string.IsNullOrEmpty(nameTB.Text.Trim())) 
            { 
                validate = false;
                errorProvider.SetError(nameTB, "Tên không được để trống");
            }
            else
            {
                errorProvider.SetError(nameTB, null);
            }

            if (string.IsNullOrEmpty(addressTB.Text.Trim())) 
            { 
                validate = false;
                errorProvider.SetError(addressTB, "Địa chỉ không được để trống");

            }
            else
            {
                errorProvider.SetError(addressTB, null);
            }

            if (string.IsNullOrEmpty(emailTB.Text.Trim())) { 
                validate = false;
                errorProvider.SetError(emailTB, "Email không được để trống");
            }
            else if (!isEmail(emailTB.Text.Trim()))
            {
                validate = false;
                errorProvider.SetError(emailTB, "Email không hợp lệ");
            }
            else
            {
                errorProvider.SetError(emailTB,null);
            }



            if (validate)
            {
                if (flag == 1) { createNXB(); }
                if (flag == 2) { updateNXB(); }
                cancelBtn.Enabled = false;
                NXBList.CellClick += NXBList_CellClick;
                addBtn.Enabled = true;
            }

            
           
            
        }

        private bool isEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address.Equals(email);
            }
            catch 
            {
                return false;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (currRow <= ds.Tables["NXB_DS"].Rows.Count - 1 && currRow >= 0)
            {
                DataRow row = ds.Tables["NXB_DS"].Rows[currRow];
                bool nemp = NXBisEmpty(row["MaNXB"].ToString());

                if (nemp)
                {
                    MessageBox.Show("NXB này đang có thông tin trong hệ thống, không thể xóa", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa NXB: '" + row["TenNXB"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        row.Delete();

                        int res = adapter.Update(ds.Tables["NXB_DS"]);
                    }

                    nameTB.Text = "";
                    addressTB.Text = "";
                    emailTB.Text = "";

                    saveBtn.Enabled = false;
                    cancelBtn.Enabled = false;
                    updateBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                }
            }
        }

        private bool NXBisEmpty(string maNXB)
        {
            conn.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(1) FROM Sach WHERE MaNXB=@NXB";
            cmd.Parameters.AddWithValue("@NXB", maNXB);
            cmd.Connection = conn.slqCon;
            int res = (int)cmd.ExecuteScalar();
            conn.DongKetNoi();
            if (res > 0)
            {
                return true;
            }
            else return false;
        }

        private void searchBTn_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            string querry = "select * from NXB where TenNXB like N'%"+searchTB.Text.Trim()+ "%' or MaNXB like N'%"+searchTB.Text.Trim()+"%'";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "NXB_DS");

            NXBList.DataSource = ds.Tables["NXB_DS"];

            conn.DongKetNoi();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            addBtn.Enabled=true;

            nameTB.Text = "";
            addressTB.Text = "";
            emailTB.Text = "";

            int flag = -1;

            NXBList.CellClick += NXBList_CellClick;
            errorProvider.SetError(emailTB, null);
            errorProvider.SetError(addressTB, null);
            errorProvider.SetError(nameTB, null);

        }
    }
}
