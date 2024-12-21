namespace home
{
    partial class LapCTPhieuTra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPM = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInPhieuMuon = new System.Windows.Forms.Button();
            this.btnLapPhieuPhat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbTTCTPM = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSLTra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSLMuon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPM)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbTTCTPM.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSCTPM);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách:";
            // 
            // dgvDSCTPM
            // 
            this.dgvDSCTPM.AllowUserToAddRows = false;
            this.dgvDSCTPM.AllowUserToDeleteRows = false;
            this.dgvDSCTPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SLMuon,
            this.SLTra,
            this.TinhTrang,
            this.NgayTra});
            this.dgvDSCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCTPM.Location = new System.Drawing.Point(3, 26);
            this.dgvDSCTPM.Name = "dgvDSCTPM";
            this.dgvDSCTPM.ReadOnly = true;
            this.dgvDSCTPM.RowHeadersWidth = 51;
            this.dgvDSCTPM.RowTemplate.Height = 24;
            this.dgvDSCTPM.Size = new System.Drawing.Size(1129, 193);
            this.dgvDSCTPM.TabIndex = 0;
            this.dgvDSCTPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPM_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SLMuon
            // 
            this.SLMuon.DataPropertyName = "SLMuon";
            this.SLMuon.HeaderText = "Số lượng mượn";
            this.SLMuon.MinimumWidth = 6;
            this.SLMuon.Name = "SLMuon";
            this.SLMuon.ReadOnly = true;
            this.SLMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SLTra
            // 
            this.SLTra.DataPropertyName = "SLTra";
            this.SLTra.HeaderText = "Số lượng trả";
            this.SLTra.MinimumWidth = 6;
            this.SLTra.Name = "SLTra";
            this.SLTra.ReadOnly = true;
            this.SLTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            this.NgayTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Enabled = false;
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(174, 145);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(175, 30);
            this.dtpHanTra.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Enabled = false;
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(174, 100);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(175, 30);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(512, 232);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(163, 30);
            this.txtTenNV.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tên NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(174, 232);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(175, 30);
            this.txtMaNV.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "MaNV:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(512, 186);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(163, 30);
            this.txtTenDG.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên độc giả:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(174, 186);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(175, 30);
            this.txtMaDG.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã độc giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hạn trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày mượn:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(512, 51);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(163, 117);
            this.txtGhiChu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ghi chú:";
            // 
            // txtSoPM
            // 
            this.txtSoPM.Location = new System.Drawing.Point(174, 51);
            this.txtSoPM.Name = "txtSoPM";
            this.txtSoPM.ReadOnly = true;
            this.txtSoPM.Size = new System.Drawing.Size(175, 30);
            this.txtSoPM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu mượn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 222);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInPhieuMuon);
            this.groupBox1.Controls.Add(this.btnLapPhieuPhat);
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.btnHoanThanh);
            this.groupBox1.Controls.Add(this.dtpHanTra);
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTraSach);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoPM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn:";
            // 
            // btnInPhieuMuon
            // 
            this.btnInPhieuMuon.Location = new System.Drawing.Point(444, 299);
            this.btnInPhieuMuon.Name = "btnInPhieuMuon";
            this.btnInPhieuMuon.Size = new System.Drawing.Size(96, 41);
            this.btnInPhieuMuon.TabIndex = 20;
            this.btnInPhieuMuon.Text = "&In phiếu";
            this.btnInPhieuMuon.UseVisualStyleBackColor = true;
            this.btnInPhieuMuon.Click += new System.EventHandler(this.btnInPhieuMuon_Click);
            // 
            // btnLapPhieuPhat
            // 
            this.btnLapPhieuPhat.Location = new System.Drawing.Point(154, 299);
            this.btnLapPhieuPhat.Name = "btnLapPhieuPhat";
            this.btnLapPhieuPhat.Size = new System.Drawing.Size(148, 41);
            this.btnLapPhieuPhat.TabIndex = 17;
            this.btnLapPhieuPhat.Text = "&Lập phiếu phạt";
            this.btnLapPhieuPhat.UseVisualStyleBackColor = true;
            this.btnLapPhieuPhat.Click += new System.EventHandler(this.btnLapPhieuPhat_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(26, 299);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(114, 41);
            this.btnQuayLai.TabIndex = 16;
            this.btnQuayLai.Text = "&Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(554, 299);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(136, 41);
            this.btnHoanThanh.TabIndex = 19;
            this.btnHoanThanh.Text = "&Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(316, 299);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(114, 41);
            this.btnTraSach.TabIndex = 18;
            this.btnTraSach.Text = "&Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 356);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbTTCTPM);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(712, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 356);
            this.panel4.TabIndex = 1;
            // 
            // gbTTCTPM
            // 
            this.gbTTCTPM.Controls.Add(this.cbTinhTrang);
            this.gbTTCTPM.Controls.Add(this.btnHuy);
            this.gbTTCTPM.Controls.Add(this.btnLuu);
            this.gbTTCTPM.Controls.Add(this.txtSLTra);
            this.gbTTCTPM.Controls.Add(this.label14);
            this.gbTTCTPM.Controls.Add(this.dtpNgayTra);
            this.gbTTCTPM.Controls.Add(this.label13);
            this.gbTTCTPM.Controls.Add(this.label3);
            this.gbTTCTPM.Controls.Add(this.txtMaSach);
            this.gbTTCTPM.Controls.Add(this.label10);
            this.gbTTCTPM.Controls.Add(this.label7);
            this.gbTTCTPM.Controls.Add(this.txtTenSach);
            this.gbTTCTPM.Controls.Add(this.txtSLMuon);
            this.gbTTCTPM.Controls.Add(this.label9);
            this.gbTTCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTTCTPM.Location = new System.Drawing.Point(0, 0);
            this.gbTTCTPM.Name = "gbTTCTPM";
            this.gbTTCTPM.Size = new System.Drawing.Size(423, 356);
            this.gbTTCTPM.TabIndex = 0;
            this.gbTTCTPM.TabStop = false;
            this.gbTTCTPM.Text = "Thông tin chi tiết sách:";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(218, 200);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(176, 31);
            this.cbTinhTrang.TabIndex = 9;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(267, 299);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 41);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "H&ủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(98, 299);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 41);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSLTra
            // 
            this.txtSLTra.Location = new System.Drawing.Point(218, 158);
            this.txtSLTra.Name = "txtSLTra";
            this.txtSLTra.Size = new System.Drawing.Size(176, 30);
            this.txtSLTra.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 23);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số lượng trả:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(218, 244);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(176, 30);
            this.dtpNgayTra.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày trả:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(218, 29);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(176, 30);
            this.txtMaSach.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tình trạng:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(218, 72);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(176, 30);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtSLMuon
            // 
            this.txtSLMuon.Location = new System.Drawing.Point(218, 115);
            this.txtSLMuon.Name = "txtSLMuon";
            this.txtSLMuon.ReadOnly = true;
            this.txtSLMuon.Size = new System.Drawing.Size(176, 30);
            this.txtSLMuon.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số lượng mượn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 356);
            this.panel3.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // LapCTPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LapCTPhieuTra";
            this.Size = new System.Drawing.Size(1135, 578);
            this.Load += new System.EventHandler(this.LapCTPhieuTra_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbTTCTPM.ResumeLayout(false);
            this.gbTTCTPM.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSCTPM;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbTTCTPM;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSLMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSLTra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.Button btnLapPhieuPhat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnInPhieuMuon;
    }
}
