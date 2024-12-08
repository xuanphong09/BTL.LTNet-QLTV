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
    public partial class LapPhieuTra : UserControl
    {
        public LapPhieuTra()
        {
            InitializeComponent();
        }

        private string MaNV;

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int index = -1;

        public void SetMaNV(string maNV)
        {
            this.MaNV = maNV;
        }


        private void LapPhieuTra_Load(object sender, EventArgs e)
        {
            HienThiDSPM();
            btnLPTra.Enabled = false;
        }

        private void HienThiDSPM()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            dbConn.MoKetNoi();

            string query = "select PhieuMuon.SoPM, PhieuMuon.MaDG, DocGia.HoTen, NgayMuon, HanTra, PhieuMuon.GhiChu  from PhieuMuon inner join DocGia on PhieuMuon.MaDG = DocGia.MaDG where SoPM='"+txtTimKiem.Text.Trim()+ "' or PhieuMuon.MaDG ='"+txtTimKiem.Text.Trim()+ "' or HoTen like N'%"+txtTimKiem.Text.Trim()+"%'";
            adapter = new SqlDataAdapter(query, dbConn.slqCon);

            ds = new DataSet();
            adapter.Fill(ds, "DSPhieuMuon");

            dgvDSPM.DataSource = ds.Tables["DSPhieuMuon"];
            dbConn.DongKetNoi();
        }

        private void dgvDSPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnLPTra.Enabled = true;
            }

        }

        private void btnLPTra_Click(object sender, EventArgs e)
        {
            QuanLyPhieuMuon quanLyPhieuMuon = this.ParentForm as QuanLyPhieuMuon;
            quanLyPhieuMuon.panelContent.Controls.Clear();
            LapCTPhieuTra lapCTPTra = new LapCTPhieuTra();

            //lay so phieu muon
            DataRow row = ds.Tables["DSPhieuMuon"].Rows[index];
            lapCTPTra.SetSoPM(row["SoPM"].ToString());
            lapCTPTra.SetMaNV(this.MaNV);
            lapCTPTra.Dock = DockStyle.Fill;

            quanLyPhieuMuon.panelContent.Controls.Add(lapCTPTra);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDSPM();
        }
    }
}
