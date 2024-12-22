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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home
{
    public partial class QLPP : Form
    {
        public QLPP()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        DatabaseConnection conn = new DatabaseConnection();
        int currRow;
        int func = -1;
        string manv;

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();

            searchCB.SelectedIndex = 0;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void loadData()
        {
            conn.MoKetNoi();

            string querry = "select * from PhieuPhat";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "PP_list");

            PPGrid.DataSource = ds.Tables["PP_list"];


            conn.DongKetNoi();

        }

        private void PPGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currRow = e.RowIndex;

            if (currRow <= ds.Tables["PP_list"].Rows.Count - 1 && currRow >= 0)
            {
                DataRow row = ds.Tables["PP_list"].Rows[currRow];
                maDGTB.Text = row["MaDG"].ToString();
                lydoTB.Text = row["LyDoPhat"].ToString();
                hinhthucTB.Text = row["HinhThucXL"].ToString();

                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }


        }


        private string generateMa()
        {
            string newMa;

            conn.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select top 1 SoPhieuPhat from PhieuPhat Order by SoPhieuPhat desc";
            cmd.Connection = conn.slqCon;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string fugue = dr.GetString(0).Substring(2);
                int num = int.Parse(fugue) + 1;
                newMa = "PP" + num.ToString("D3");

            }
            else
            {
                newMa = "PP001";

            }

            dr.Close();
            conn.DongKetNoi();
            return newMa;
        }


        private void createPP()
        {
            conn.MoKetNoi();

            DataRow row = ds.Tables["PP_list"].NewRow();
            row["SoPhieuPhat"] = generateMa();
            row["MaDG"] = maDGTB.Text.Trim();
            row["MaNV"] = manv;
            row["LyDoPhat"] = lydoTB.Text.Trim();
            row["HinhThucXL"] = hinhthucTB.Text.Trim();

            row["NgayPhat"] = DateTime.Now.Date;

            ds.Tables["PP_list"].Rows.Add(row);

            int res = adapter.Update(ds.Tables["PP_list"]);

            if (res > 0)
            {
                MessageBox.Show("Thêm phiếu phạt thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm phiếu phạt không thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            conn.DongKetNoi();
        }

        private void updatePP()
        {
            conn.MoKetNoi();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin phiếu phạt này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataRow row = ds.Tables["PP_list"].Rows[currRow];
                row.BeginEdit();
                row["MaDG"] = maDGTB.Text.Trim();
                row["LyDoPhat"] = lydoTB.Text.Trim();
                row["HinhThucXL"] = hinhthucTB.Text.Trim();
                row.EndEdit();

                int res = adapter.Update(ds.Tables["PP_list"]);

                if (res > 0)
                {
                    MessageBox.Show("Sửa phiếu phạt thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                }
                else
                {
                    MessageBox.Show("Sửa phiếu phạt thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            conn.DongKetNoi();
        }

        private void deletePP()
        {
            conn.MoKetNoi();

            DataRow row = ds.Tables["PP_List"].Rows[currRow];
            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa phiếu phạt: '" + row["SoPhieuPhat"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                row.Delete();

                int res = adapter.Update(ds.Tables["PP_List"]);
            }

            conn.DongKetNoi();
        }
        private void searchMaPP()
        {
            conn.MoKetNoi();
            string querry = "select * from PhieuPhat where SoPhieuPhat like N'%" + searchTB.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "PP_List");

            PPGrid.DataSource = ds.Tables["PP_List"];

            conn.DongKetNoi();
        }

        private void searchMaDG()
        {
            conn.MoKetNoi();
            string querry = "select * from PhieuPhat where MaDG like N'%" + searchTB.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "PP_List");

            PPGrid.DataSource = ds.Tables["PP_List"];

            conn.DongKetNoi();
        }

        private void searchMaNV() {

            conn.MoKetNoi();
            string querry = "select * from PhieuPhat where MaNV like N'%" + searchTB.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "PP_List");

            PPGrid.DataSource = ds.Tables["PP_List"];

            conn.DongKetNoi();
        }

        private Boolean validate()
        {
            if(string.IsNullOrEmpty(maDGTB.Text.Trim()))
            {
                errorProvider.SetError(maDGTB, "Mã Độc Giả không được để trống");

                return false;
            }

            if ( string.IsNullOrEmpty(hinhthucTB.Text.Trim()))
            {
                errorProvider.SetError(hinhthucTB, "Hình thức phạt không được để trống");

                return false;
            }

            if ( string.IsNullOrEmpty(lydoTB.Text.Trim()))
            {
                errorProvider.SetError(lydoTB, "Lý do phạt không được để trống");


                return false;
            }

            conn.MoKetNoi();
            string querry = "select * from DocGia WHERE MaDG='" + maDGTB.Text.Trim() + "'";

            SqlCommand cmd = new SqlCommand(querry, conn.slqCon);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                errorProvider.SetError(hinhthucTB, "Mã Độc Giả tồn tại");
                reader.Close();
                conn.DongKetNoi();
                return false;
            }
            reader.Close();
            conn.DongKetNoi();


            return true;
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            func = 1;
            saveBtn.Enabled = true;

            maDGTB.Text = "";
            hinhthucTB.Text = "";
            lydoTB.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            func = 2;
            saveBtn.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deletePP();

            maDGTB.Text = "";
            hinhthucTB.Text = "";
            lydoTB.Text = "";

            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchCB.Text.Equals("Số Phiếu Phạt"))
            {
                searchMaPP();
            }
            if (searchCB.Text.Equals("Mã Độc Giả"))
            {
                searchMaDG();
            }
            if (searchCB.Text.Equals("Mã Nhân Viên"))
            {
                searchMaNV();
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (func == 1)
                {
                    createPP();
                }
                if (func == 2)
                {
                    updatePP();
                }

                maDGTB.Text = "";
                hinhthucTB.Text = "";
                lydoTB.Text = "";


                updateBtn.Enabled = false;
                deleteBtn.Enabled = false;
                saveBtn.Enabled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setMaNV(string manv)
        {
            this.manv = manv;
        }
    }
}
