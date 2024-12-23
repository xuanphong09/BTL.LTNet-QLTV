namespace home
{
    partial class frmSach
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
            this.components = new System.ComponentModel.Container();
            //this.qLTVDataSet = new home.QLTVDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.sachTableAdapter = new home.QLTVDataSetTableAdapters.SachTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.plTTCT = new System.Windows.Forms.Panel();
            this.grbThôngTinCT = new System.Windows.Forms.GroupBox();
            this.cboMaNXB = new System.Windows.Forms.ComboBox();
            this.cboMaTG = new System.Windows.Forms.ComboBox();
            this.cboMaTL = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDaMuon = new System.Windows.Forms.TextBox();
            this.tbldm = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.tlbsl = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            //((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.plTTCT.SuspendLayout();
            this.grbThôngTinCT.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLTVDataSet
            // 
            //this.qLTVDataSet.DataSetName = "QLTVDataSet";
            //this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            //this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // sachTableAdapter
            // 
            //this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 384);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbChucNang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1178, 88);
            this.panel5.TabIndex = 1;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChucNang.Location = new System.Drawing.Point(0, 0);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(1178, 88);
            this.grbChucNang.TabIndex = 0;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(45, 119);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(228, 34);
            this.txtTK.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(1017, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(627, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(139, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(237, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "T&hêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(93, 163);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 35);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // plTTCT
            // 
            this.plTTCT.Controls.Add(this.grbThôngTinCT);
            this.plTTCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.plTTCT.Enabled = false;
            this.plTTCT.Location = new System.Drawing.Point(0, 0);
            this.plTTCT.Name = "plTTCT";
            this.plTTCT.Size = new System.Drawing.Size(840, 296);
            this.plTTCT.TabIndex = 0;
            // 
            // grbThôngTinCT
            // 
            this.grbThôngTinCT.Controls.Add(this.cboMaNXB);
            this.grbThôngTinCT.Controls.Add(this.cboMaTG);
            this.grbThôngTinCT.Controls.Add(this.cboMaTL);
            this.grbThôngTinCT.Controls.Add(this.txtGhiChu);
            this.grbThôngTinCT.Controls.Add(this.label10);
            this.grbThôngTinCT.Controls.Add(this.label6);
            this.grbThôngTinCT.Controls.Add(this.label7);
            this.grbThôngTinCT.Controls.Add(this.label8);
            this.grbThôngTinCT.Controls.Add(this.txtNamXB);
            this.grbThôngTinCT.Controls.Add(this.label9);
            this.grbThôngTinCT.Controls.Add(this.txtDaMuon);
            this.grbThôngTinCT.Controls.Add(this.tbldm);
            this.grbThôngTinCT.Controls.Add(this.txtSoLuong);
            this.grbThôngTinCT.Controls.Add(this.tlbsl);
            this.grbThôngTinCT.Controls.Add(this.txtTenSach);
            this.grbThôngTinCT.Controls.Add(this.label3);
            this.grbThôngTinCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThôngTinCT.Location = new System.Drawing.Point(0, 0);
            this.grbThôngTinCT.Name = "grbThôngTinCT";
            this.grbThôngTinCT.Size = new System.Drawing.Size(840, 296);
            this.grbThôngTinCT.TabIndex = 0;
            this.grbThôngTinCT.TabStop = false;
            this.grbThôngTinCT.Text = "Thông tin chi tiết";
            // 
            // cboMaNXB
            // 
            this.cboMaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNXB.FormattingEnabled = true;
            this.cboMaNXB.Location = new System.Drawing.Point(225, 191);
            this.cboMaNXB.Name = "cboMaNXB";
            this.cboMaNXB.Size = new System.Drawing.Size(138, 33);
            this.cboMaNXB.TabIndex = 7;
            // 
            // cboMaTG
            // 
            this.cboMaTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTG.FormattingEnabled = true;
            this.cboMaTG.Location = new System.Drawing.Point(512, 138);
            this.cboMaTG.Name = "cboMaTG";
            this.cboMaTG.Size = new System.Drawing.Size(138, 33);
            this.cboMaTG.TabIndex = 13;
            // 
            // cboMaTL
            // 
            this.cboMaTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTL.FormattingEnabled = true;
            this.cboMaTL.Location = new System.Drawing.Point(225, 132);
            this.cboMaTL.Name = "cboMaTL";
            this.cboMaTL.Size = new System.Drawing.Size(138, 33);
            this.cboMaTL.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(512, 188);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(283, 75);
            this.txtGhiChu.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ghi Chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã NXB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã TG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã TL:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(512, 81);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(138, 30);
            this.txtNamXB.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Năm XB:";
            // 
            // txtDaMuon
            // 
            this.txtDaMuon.Location = new System.Drawing.Point(225, 80);
            this.txtDaMuon.Name = "txtDaMuon";
            this.txtDaMuon.Size = new System.Drawing.Size(138, 30);
            this.txtDaMuon.TabIndex = 5;
            // 
            // tbldm
            // 
            this.tbldm.AutoSize = true;
            this.tbldm.Location = new System.Drawing.Point(106, 83);
            this.tbldm.Name = "tbldm";
            this.tbldm.Size = new System.Drawing.Size(98, 25);
            this.tbldm.TabIndex = 4;
            this.tbldm.Text = "Đã Mượn:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(512, 30);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(138, 30);
            this.txtSoLuong.TabIndex = 3;
            // 
            // tlbsl
            // 
            this.tlbsl.AutoSize = true;
            this.tlbsl.Location = new System.Drawing.Point(393, 33);
            this.tlbsl.Name = "tlbsl";
            this.tlbsl.Size = new System.Drawing.Size(103, 25);
            this.tlbsl.TabIndex = 2;
            this.tlbsl.Text = "Số Lượng:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(225, 30);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(138, 30);
            this.txtTenSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Sách:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 243);
            this.panel3.TabIndex = 2;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoGenerateColumns = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.DaMuon,
            this.NamXB,
            this.MaTL,
            this.MaTG,
            this.MaNXB,
            this.GhiChu});
            this.dgvSach.DataSource = this.sachBindingSource;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1178, 243);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập thông tin cần tìm:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(432, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 45);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(822, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(139, 45);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DaMuon
            // 
            this.DaMuon.DataPropertyName = "DaMuon";
            this.DaMuon.HeaderText = "Đã Mượn";
            this.DaMuon.MinimumWidth = 6;
            this.DaMuon.Name = "DaMuon";
            this.DaMuon.ReadOnly = true;
            this.DaMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm XB";
            this.NamXB.MinimumWidth = 6;
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            this.NamXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã TL";
            this.MaTL.MinimumWidth = 6;
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            this.MaTL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã TG";
            this.MaTG.MinimumWidth = 6;
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            this.MaTG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 6;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTK);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnTimKiem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(840, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 296);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.plTTCT);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1178, 296);
            this.panel7.TabIndex = 0;
            // 
            // frmSach
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1178, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            //((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.plTTCT.ResumeLayout(false);
            this.grbThôngTinCT.ResumeLayout(false);
            this.grbThôngTinCT.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        //private QLTVDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel plTTCT;
        private System.Windows.Forms.GroupBox grbThôngTinCT;
        private System.Windows.Forms.TextBox txtDaMuon;
        private System.Windows.Forms.Label tbldm;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label tlbsl;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cboMaTL;
        private System.Windows.Forms.ComboBox cboMaNXB;
        private System.Windows.Forms.ComboBox cboMaTG;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}