using Microsoft.Reporting.WinForms;
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
    public partial class InPhieuMuonTra : Form
    {
        public InPhieuMuonTra()
        {
            InitializeComponent();
        }

        string soPM;

        public void SetSoPM(string soPM)
        {
            this.soPM = soPM;
        }

        private void InPhieuMuonTra_Load(object sender, EventArgs e)
        {

            DatabaseConnection db = new DatabaseConnection();
            db.MoKetNoi();

            //lấy thông tin đọc giả
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = db.slqCon;
            sqlCommand.CommandText = "select SoPM, PhieuMuon.MaDG, HoTen, NgayMuon, HanTra from PhieuMuon inner join DocGia on PhieuMuon.MaDG=DocGia.MaDG where SoPM='"+this.soPM+"'";

            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<ReportParameter> list = new List<ReportParameter>();
            if (reader.Read())
            {
                list.Add(new ReportParameter("SoPM", reader["SoPM"].ToString()));
                list.Add(new ReportParameter("MaDG", reader["MaDG"].ToString()));
                list.Add(new ReportParameter("TenDG", reader["HoTen"].ToString()));
                list.Add(new ReportParameter("NgayMuon", reader["NgayMuon"].ToString()));
                list.Add(new ReportParameter("HanTra", reader["HanTra"].ToString()));
            }
            else
            {
                list.Add(new ReportParameter("SoPM", ""));
                list.Add(new ReportParameter("MaDG", ""));
                list.Add(new ReportParameter("TenDG", ""));
                list.Add(new ReportParameter("NgayMuon", ""));
                list.Add(new ReportParameter("HanTra", ""));
            }
            reader.Close();


            //lấy thông tin sách
            string query = "SELECT CTPhieuMuon.*, TenSach FROM CTPhieuMuon inner join Sach on CTPhieuMuon.MaSach = Sach.MaSach where SoPM='" + this.soPM+"'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, db.slqCon);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "CTPhieuMuon");



            this.rvPhieuMuonTra.LocalReport.ReportEmbeddedResource = "home.rptPhieuMuonTra.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["CTPhieuMuon"];
            this.rvPhieuMuonTra.LocalReport.DataSources.Add(rds);
            this.rvPhieuMuonTra.LocalReport.SetParameters(list);
            this.rvPhieuMuonTra.RefreshReport();
        }
    }
}
