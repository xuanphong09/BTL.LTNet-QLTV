using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class QuanLyPhieuMuon : Form
    {
        public QuanLyPhieuMuon(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private string maNV { set; get; } = "";

        //hàm lod form
        private void QuanLyPhieuMuon_Load(object sender, EventArgs e)
        {
            //doi mau nut
            btnDSPM.BackColor = Color.FromArgb(128, 255, 255);
            btnLPM.BackColor = Color.FromArgb(255, 255, 255);
            btnLPT.BackColor = Color.FromArgb(255, 255, 255);

            panelContent.Controls.Clear();
            DanhSachPhieuMuon danhSachPhieuMuon = new DanhSachPhieuMuon();
            danhSachPhieuMuon.Dock = DockStyle.Fill;
            panelContent.Controls.Add(danhSachPhieuMuon);

            btnDSPM.Enabled = false;
            btnLPM.Enabled = true;
            btnLPT.Enabled = true;

        }

        //hàm click nut danh sách phiếu mượn
        private void btnDSPM_Click(object sender, EventArgs e)
        {
            //doi mau nut
            btnDSPM.BackColor = Color.FromArgb(128, 255, 255);
            btnLPM.BackColor = Color.FromArgb(255, 255, 255);
            btnLPT.BackColor = Color.FromArgb(255, 255, 255);

            panelContent.Controls.Clear();
            DanhSachPhieuMuon danhSachPhieuMuon = new DanhSachPhieuMuon();
            danhSachPhieuMuon.Dock = DockStyle.Fill;
            panelContent.Controls.Add(danhSachPhieuMuon);

            btnDSPM.Enabled = false;
            btnLPM.Enabled = true;
            btnLPT.Enabled = true;
        }

        //hàm click nut lập phiếu mượn
        private void btnLPM_Click(object sender, EventArgs e)
        {
            //doi mau nut
            btnDSPM.BackColor = Color.FromArgb(255, 255, 255);
            btnLPM.BackColor = Color.FromArgb(128, 255, 255);
            btnLPT.BackColor = Color.FromArgb(255, 255, 255);

            panelContent.Controls.Clear();
            LapPhieuMuon lapPhieuMuon = new LapPhieuMuon(this.maNV);
            lapPhieuMuon.Dock = DockStyle.Fill;
            panelContent.Controls.Add(lapPhieuMuon);

            btnDSPM.Enabled = true;
            btnLPM.Enabled = false;
            btnLPT.Enabled = true;

        }

        //hàm click nut lập phiếu trả
        private void btnLPT_Click(object sender, EventArgs e)
        {
            //doi mau nut
            btnDSPM.BackColor = Color.FromArgb(255, 255, 255);
            btnLPM.BackColor = Color.FromArgb(255, 255, 255);
            btnLPT.BackColor = Color.FromArgb(128, 255, 255);

            panelContent.Controls.Clear();
            LapPhieuTra lapPhieuTra = new LapPhieuTra();
            lapPhieuTra.SetMaNV(this.maNV);
            lapPhieuTra.Dock = DockStyle.Fill;
            panelContent.Controls.Add(lapPhieuTra);

            btnDSPM.Enabled = true;
            btnLPM.Enabled = true;
            btnLPT.Enabled = false;

        }

        //hàm thoát form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
