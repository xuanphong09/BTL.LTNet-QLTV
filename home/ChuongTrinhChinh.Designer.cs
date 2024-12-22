namespace home
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMIQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMISach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIMuonTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIName = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIChinhSuaThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tSMITacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMINhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMITheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIPhieuPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIQuanLyTaiKhoan,
            this.tSMIQuanLySach,
            this.tsMIMuonTraSach,
            this.tsMIThoat,
            this.tSMIName,
            this.tsMIPhieuPhat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMIQuanLyTaiKhoan
            // 
            this.tSMIQuanLyTaiKhoan.Name = "tSMIQuanLyTaiKhoan";
            this.tSMIQuanLyTaiKhoan.Size = new System.Drawing.Size(200, 30);
            this.tSMIQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.tSMIQuanLyTaiKhoan.Click += new System.EventHandler(this.mIQuanLyTaiKhoan_Click);
            // 
            // tSMIQuanLySach
            // 
            this.tSMIQuanLySach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMISach,
            this.tSMITacGia,
            this.tSMINhaXuatBan,
            this.tsMITheLoai});
            this.tSMIQuanLySach.Name = "tSMIQuanLySach";
            this.tSMIQuanLySach.Size = new System.Drawing.Size(158, 30);
            this.tSMIQuanLySach.Text = "Quản lý sách";
            // 
            // tSMISach
            // 
            this.tSMISach.Name = "tSMISach";
            this.tSMISach.Size = new System.Drawing.Size(231, 30);
            this.tSMISach.Text = "Sách";
            this.tSMISach.Click += new System.EventHandler(this.tSMISach_Click);
            // 
            // tsMIMuonTraSach
            // 
            this.tsMIMuonTraSach.Name = "tsMIMuonTraSach";
            this.tsMIMuonTraSach.Size = new System.Drawing.Size(175, 30);
            this.tsMIMuonTraSach.Text = "Mượn trả sách";
            this.tsMIMuonTraSach.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
            // 
            // tsMIThoat
            // 
            this.tsMIThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsMIThoat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsMIThoat.Image = global::home.Properties.Resources.red_circle_logout_arrow_20586;
            this.tsMIThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsMIThoat.Name = "tsMIThoat";
            this.tsMIThoat.Size = new System.Drawing.Size(34, 30);
            this.tsMIThoat.Click += new System.EventHandler(this.tsMIThoat_Click);
            // 
            // tSMIName
            // 
            this.tSMIName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSMIName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIChinhSuaThongTin,
            this.tSMIDoiMatKhau,
            this.tSMIDangXuat});
            this.tSMIName.Name = "tSMIName";
            this.tSMIName.Size = new System.Drawing.Size(54, 30);
            this.tSMIName.Text = "Hi ";
            // 
            // tSMIChinhSuaThongTin
            // 
            this.tSMIChinhSuaThongTin.Name = "tSMIChinhSuaThongTin";
            this.tSMIChinhSuaThongTin.Size = new System.Drawing.Size(292, 30);
            this.tSMIChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
            this.tSMIChinhSuaThongTin.Click += new System.EventHandler(this.tSMIChinhSuaThongTin_Click);
            // 
            // tSMIDoiMatKhau
            // 
            this.tSMIDoiMatKhau.Name = "tSMIDoiMatKhau";
            this.tSMIDoiMatKhau.Size = new System.Drawing.Size(292, 30);
            this.tSMIDoiMatKhau.Text = "Đổi mật khẩu";
            this.tSMIDoiMatKhau.Click += new System.EventHandler(this.tSMIDoiMatKhau_Click);
            // 
            // tSMIDangXuat
            // 
            this.tSMIDangXuat.Name = "tSMIDangXuat";
            this.tSMIDangXuat.Size = new System.Drawing.Size(292, 30);
            this.tSMIDangXuat.Text = "Đăng xuất";
            this.tSMIDangXuat.Click += new System.EventHandler(this.tSMIDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::home.Properties.Resources.Thu_Vien_Trinity_Col;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 629);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1153, 629);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý thư viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tSMITacGia
            // 
            this.tSMITacGia.Name = "tSMITacGia";
            this.tSMITacGia.Size = new System.Drawing.Size(231, 30);
            this.tSMITacGia.Text = "Tác giả";
            this.tSMITacGia.Click += new System.EventHandler(this.tSMITacGia_Click);
            // 
            // tSMINhaXuatBan
            // 
            this.tSMINhaXuatBan.Name = "tSMINhaXuatBan";
            this.tSMINhaXuatBan.Size = new System.Drawing.Size(231, 30);
            this.tSMINhaXuatBan.Text = "Nhà xuất bản";
            this.tSMINhaXuatBan.Click += new System.EventHandler(this.tSMINhaXuatBan_Click);
            // 
            // tsMITheLoai
            // 
            this.tsMITheLoai.Name = "tsMITheLoai";
            this.tsMITheLoai.Size = new System.Drawing.Size(231, 30);
            this.tsMITheLoai.Text = "Thể loại";
            this.tsMITheLoai.Click += new System.EventHandler(this.tsMITheLoai_Click);
            // 
            // tsMIPhieuPhat
            // 
            this.tsMIPhieuPhat.Name = "tsMIPhieuPhat";
            this.tsMIPhieuPhat.Size = new System.Drawing.Size(132, 30);
            this.tsMIPhieuPhat.Text = "Phiếu phạt";
            this.tsMIPhieuPhat.Click += new System.EventHandler(this.tsMIPhieuPhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mền quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMIQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem tSMIQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tSMISach;
        private System.Windows.Forms.ToolStripMenuItem tsMIMuonTraSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tSMIName;
        private System.Windows.Forms.ToolStripMenuItem tSMIChinhSuaThongTin;
        private System.Windows.Forms.ToolStripMenuItem tSMIDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tSMIDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMIThoat;
        private System.Windows.Forms.ToolStripMenuItem tSMITacGia;
        private System.Windows.Forms.ToolStripMenuItem tSMINhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem tsMITheLoai;
        private System.Windows.Forms.ToolStripMenuItem tsMIPhieuPhat;
    }
}

