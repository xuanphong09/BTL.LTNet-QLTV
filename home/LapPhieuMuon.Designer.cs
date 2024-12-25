namespace home
{
    partial class LapPhieuMuon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDSPP = new System.Windows.Forms.Panel();
            this.gbDSPP = new System.Windows.Forms.GroupBox();
            this.lvDSPP = new System.Windows.Forms.ListView();
            this.SoPhieuPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LyDoPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HinhThucXL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panelDSPP.SuspendLayout();
            this.gbDSPP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 308);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaDG);
            this.groupBox1.Controls.Add(this.dtpHanTra);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu mượn:";
            // 
            // cbMaDG
            // 
            this.cbMaDG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(364, 59);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(175, 31);
            this.cbMaDG.TabIndex = 1;
            this.cbMaDG.TextChanged += new System.EventHandler(this.cbMaDG_TextChanged);
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(364, 105);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(175, 30);
            this.dtpHanTra.TabIndex = 3;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(702, 58);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(163, 30);
            this.txtTenDG.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên độc giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã độc giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hạn trả:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(702, 105);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(163, 117);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ghi chú:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTiepTuc);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 80);
            this.panel2.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // panelDSPP
            // 
            this.panelDSPP.Controls.Add(this.gbDSPP);
            this.panelDSPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDSPP.Location = new System.Drawing.Point(0, 308);
            this.panelDSPP.Name = "panelDSPP";
            this.panelDSPP.Size = new System.Drawing.Size(1135, 190);
            this.panelDSPP.TabIndex = 39;
            // 
            // gbDSPP
            // 
            this.gbDSPP.Controls.Add(this.lvDSPP);
            this.gbDSPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDSPP.Location = new System.Drawing.Point(0, 0);
            this.gbDSPP.Name = "gbDSPP";
            this.gbDSPP.Size = new System.Drawing.Size(1135, 190);
            this.gbDSPP.TabIndex = 0;
            this.gbDSPP.TabStop = false;
            this.gbDSPP.Text = "Dnah sách phiếu phạt";
            // 
            // lvDSPP
            // 
            this.lvDSPP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoPhieuPhat,
            this.LyDoPhat,
            this.HinhThucXL,
            this.NgayPhat});
            this.lvDSPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSPP.GridLines = true;
            this.lvDSPP.HideSelection = false;
            this.lvDSPP.Location = new System.Drawing.Point(3, 26);
            this.lvDSPP.Name = "lvDSPP";
            this.lvDSPP.Size = new System.Drawing.Size(1129, 161);
            this.lvDSPP.TabIndex = 0;
            this.lvDSPP.UseCompatibleStateImageBehavior = false;
            this.lvDSPP.View = System.Windows.Forms.View.Details;
            // 
            // SoPhieuPhat
            // 
            this.SoPhieuPhat.Text = "Số phiếu phạt";
            this.SoPhieuPhat.Width = 200;
            // 
            // LyDoPhat
            // 
            this.LyDoPhat.Text = "Lý do phạt";
            this.LyDoPhat.Width = 240;
            // 
            // HinhThucXL
            // 
            this.HinhThucXL.Text = "Hình thức xử lý";
            this.HinhThucXL.Width = 438;
            // 
            // NgayPhat
            // 
            this.NgayPhat.Text = "Ngày Phạt";
            this.NgayPhat.Width = 828;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Image = global::home.Properties.Resources.return_right;
            this.btnTiepTuc.Location = new System.Drawing.Point(755, 19);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(134, 39);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "&Tiếp tục";
            this.btnTiepTuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiepTuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::home.Properties.Resources.icons8_clear_32;
            this.btnHuy.Location = new System.Drawing.Point(215, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDSPP);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LapPhieuMuon";
            this.Size = new System.Drawing.Size(1135, 578);
            this.Load += new System.EventHandler(this.LapPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panelDSPP.ResumeLayout(false);
            this.gbDSPP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel panelDSPP;
        private System.Windows.Forms.GroupBox gbDSPP;
        private System.Windows.Forms.ListView lvDSPP;
        private System.Windows.Forms.ColumnHeader SoPhieuPhat;
        private System.Windows.Forms.ColumnHeader LyDoPhat;
        private System.Windows.Forms.ColumnHeader HinhThucXL;
        private System.Windows.Forms.ColumnHeader NgayPhat;
    }
}
