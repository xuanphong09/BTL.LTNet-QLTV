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
        public string manv;

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
            searchCB.SelectedIndex = 0; 
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setMaNV(string manv)
        {
            this.manv = manv;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            PhieuPhat pp=new PhieuPhat();
            pp.set_flag(1); 
            pp.set_manv(manv);
            pp.set_spp(generateMa());
            pp.ShowDialog();

            if (pp.get_flag()==1)
            {
                conn.MoKetNoi();

                DataRow row = ds.Tables["PP_list"].NewRow();

                row["SoPhieuPhat"] = pp.get_Spp();
                row["MaDG"] = pp.get_madg();
                row["MaNV"] = pp.get_manv();
                row["LyDoPhat"] = pp.get_lydo();
                row["HinhThucXL"] = pp.get_hinhthuc();
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

        private void PPGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currRow = e.RowIndex;
        }

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void viewBtn_Click(object sender, EventArgs e)
        {
            PhieuPhat ph = new PhieuPhat();

            if (currRow <= ds.Tables["PP_list"].Rows.Count - 1 && currRow >= 0)
            {
                DataRow row = ds.Tables["PP_list"].Rows[currRow];
                ph.set_madg(row["MaDG"].ToString());
                ph.set_lydo(row["LyDoPhat"].ToString());
                ph.set_manv(row["MaNV"].ToString());
                ph.set_hinhthuc(row["HinhThucXL"].ToString());
                ph.set_spp(row["SoPhieuPhat"].ToString());
                ph.set_ngayphat(row["ngayPhat"].ToString());
                ph.set_flag(0);

                ph.ShowDialog();

                if (ph.get_flag() == 2)
                {
                    conn.MoKetNoi();
                    row.BeginEdit();
                    row["MaDG"] = ph.get_madg();
                    row["LyDoPhat"] = ph.get_lydo();
                    row["HinhThucXL"] = ph.get_hinhthuc();
                    row.EndEdit();

                    int res = adapter.Update(ds.Tables["PP_list"]);

                    if (res > 0)
                    {
                        MessageBox.Show("Sửa phiếu phạt thành công!", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Hộp thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.DongKetNoi();
                }
            }
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

        private void searchMaNV()
        {

            conn.MoKetNoi();
            string querry = "select * from PhieuPhat where MaNV like N'%" + searchTB.Text.Trim() + "%'";

            adapter = new SqlDataAdapter(querry, conn.slqCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "PP_List");

            PPGrid.DataSource = ds.Tables["PP_List"];

            conn.DongKetNoi();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            if (currRow < ds.Tables["PP_List"].Rows.Count && currRow >= 0)
            {
                DataRow row = ds.Tables["PP_List"].Rows[currRow];

            
                {
                    DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa phiếu phạt: '" + row["SoPhieuPhat"] + "' không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {

                        row.Delete();

                        int res = adapter.Update(ds.Tables["PP_List"]);
                    }
                }
            }
            conn.DongKetNoi();
        }
    }
}
