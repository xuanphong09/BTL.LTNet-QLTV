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
    public partial class PhieuPhat : Form
    {
        private string spp  ="";
        private string madg="";
        private string manv = "";
        private string lydo = "";
        private string hinhthuc = "";
        private string date= DateTime.Now.Date.ToString();
        private int modeflag = -1;
        private bool closeflag=false;

        DatabaseConnection con = new DatabaseConnection();

        public PhieuPhat()
        {
            InitializeComponent();
        } 

        public void set_spp(string spp)
        {
            this.spp = spp;   
        }

        public string get_Spp() { 
            return this.spp;
        }

        public void set_madg(string madg)
        {
            this.madg = madg;
        }

        public string get_madg()
        {
            return this.madg;
        }

        public void set_manv(string manv)
        {
            this.manv = manv;
        }

        public string get_manv()
        {
            return this.manv;
        }

        public void set_lydo(string lydo)
        {
            this.lydo = lydo;
        }

        public string get_lydo()
        {
            return this.lydo;
        }

        public void set_hinhthuc(string hinhthuc)
        {
            this.hinhthuc = hinhthuc;
        }

        public string get_hinhthuc()
        {
            return this.hinhthuc;
        }

        public void set_ngayphat(string ngayphat)
        {
            this.date = ngayphat;
        }

        public string get_ngayphat()
        {
            return this.date;
        }

        public void set_flag(int modeflag)
        {
            this.modeflag = modeflag;
        }

        public int get_flag() { 
            return this.modeflag;
        }

        private void PhieuPhat_Load(object sender, EventArgs e)
        {

           

            fill_dg(); 
               
            

            
         
            MaNVTB.Text = spp;
            MaDGTB.Text = madg;
            SoPhieuPhatTB.Text = manv;
            LyDoPhatTB.Text = lydo;
            HinhThucXuLyTB.Text = hinhthuc;
            NgayPhatDTB.Text = date;

            LyDoPhatTB.Enabled = false;
            HinhThucXuLyTB.Enabled  = false;
            MaDGTB.Enabled = false;
            OKBtn.Visible = false;

            if (modeflag == 1)
            {
                OKBtn.Visible = true;
                updatebtn.Visible = false;
                LyDoPhatTB.Enabled = true;
                HinhThucXuLyTB.Enabled = true;
                MaDGTB.Enabled = true;
                MaDGTB.Enabled=true;
            }
        }
        private void fill_dg()
        {

            con.MoKetNoi();
            string querry = "Select * from DocGia";
            SqlDataAdapter adapter = new SqlDataAdapter(querry,con.slqCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            MaDGTB.DataSource = dt;
            MaDGTB.ValueMember = "MaDG";
            MaDGTB.AutoCompleteMode = AutoCompleteMode.Suggest;
            MaDGTB.AutoCompleteSource= AutoCompleteSource.ListItems;
            con.DongKetNoi();
        }

        private void OKBtn_Click_1(object sender, EventArgs e)
        {
            if (validate()) {
                if (get_flag() == 1)
                {
                    set_lydo(LyDoPhatTB.Text.Trim());
                    set_hinhthuc(HinhThucXuLyTB.Text.Trim());
                    madg = MaDGTB.Text.Trim();
                    closeflag = true;
                    this.Close();
                }
                else if (get_flag() == 2)
                {
                    lydo = LyDoPhatTB.Text.Trim();
                    hinhthuc = HinhThucXuLyTB.Text.Trim();
                    closeflag = true;
                    this.Close();
                };
            }
            

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            LyDoPhatTB.Enabled = true;
            HinhThucXuLyTB.Enabled = true;
            OKBtn.Visible = true;
            updatebtn.Visible = false;
            set_flag(2);
            
        }

        private bool validate()
        {
            bool temp = true;
            if (string.IsNullOrEmpty(HinhThucXuLyTB.Text))
            {
                errorProvider1.SetError(HinhThucXuLyTB, "hình thức xử lý không được để trống");
                temp = false;
            }
            else
            {
                errorProvider1.SetError(HinhThucXuLyTB, null);
            }

            if (string.IsNullOrEmpty(LyDoPhatTB.Text))
            {
                errorProvider1.SetError(LyDoPhatTB, "lý do phạt không được để trống");
                temp = false;
            }
            else
            {
                errorProvider1.SetError(LyDoPhatTB, null);
            }

            con.MoKetNoi();
            string querry = "select * from DocGia WHERE MaDG='" + MaDGTB.Text.Trim() + "'";

            SqlCommand cmd = new SqlCommand(querry, con.slqCon);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                errorProvider1.SetError(MaDGTB, "Mã Độc Giả không tồn tại");
                reader.Close();
                con.DongKetNoi();
                temp= false;
            }
            else { errorProvider1.SetError(MaDGTB, null); }
            reader.Close();
            con.DongKetNoi();
            return temp;


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void PhieuPhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeflag == false)
            {
                set_flag(0);
            }
        }
    }

    
    
}
