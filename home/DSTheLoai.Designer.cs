namespace home
{
    partial class frmDanhSachTheLoai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTKTenTL = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSTheLoai = new System.Windows.Forms.DataGridView();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grbTTCT.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thể Loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 327);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 124);
            this.panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::home.Properties.Resources.icons8_edit_property_32;
            this.btnSua.Location = new System.Drawing.Point(412, 49);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 49);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::home.Properties.Resources.icons8_clear_32;
            this.btnHuy.Location = new System.Drawing.Point(748, 49);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 49);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủ&y";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoat.Location = new System.Drawing.Point(918, 49);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::home.Properties.Resources.icons8_delete_32;
            this.btnXoa.Location = new System.Drawing.Point(239, 49);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 49);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::home.Properties.Resources.icons8_save_32;
            this.btnLuu.Location = new System.Drawing.Point(565, 49);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 49);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "&Lưu ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::home.Properties.Resources.icons8_plus_32;
            this.btnThem.Location = new System.Drawing.Point(44, 49);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "T&hêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 203);
            this.panel4.TabIndex = 0;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.label4);
            this.grbTimKiem.Controls.Add(this.txtTKTenTL);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(405, 203);
            this.grbTimKiem.TabIndex = 1;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập thông tin cần tìm:";
            // 
            // txtTKTenTL
            // 
            this.txtTKTenTL.Location = new System.Drawing.Point(72, 79);
            this.txtTKTenTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKTenTL.Name = "txtTKTenTL";
            this.txtTKTenTL.Size = new System.Drawing.Size(270, 30);
            this.txtTKTenTL.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::home.Properties.Resources.icons8_search_32;
            this.btnTimKiem.Location = new System.Drawing.Point(130, 116);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(163, 49);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "&Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grbTTCT);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(675, 203);
            this.panel6.TabIndex = 0;
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.txtMaTL);
            this.grbTTCT.Controls.Add(this.label3);
            this.grbTTCT.Controls.Add(this.txtTenTL);
            this.grbTTCT.Controls.Add(this.label2);
            this.grbTTCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTCT.Location = new System.Drawing.Point(0, 0);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Size = new System.Drawing.Size(675, 203);
            this.grbTTCT.TabIndex = 0;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(253, 41);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(212, 30);
            this.txtMaTL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thể loại:";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(253, 99);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(222, 30);
            this.txtTenTL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thể loại:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 406);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 234);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSTheLoai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1080, 234);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách";
            // 
            // dgvDSTheLoai
            // 
            this.dgvDSTheLoai.AllowUserToAddRows = false;
            this.dgvDSTheLoai.AllowUserToDeleteRows = false;
            this.dgvDSTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.TenTL});
            this.dgvDSTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTheLoai.Location = new System.Drawing.Point(4, 27);
            this.dgvDSTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSTheLoai.Name = "dgvDSTheLoai";
            this.dgvDSTheLoai.ReadOnly = true;
            this.dgvDSTheLoai.RowHeadersWidth = 51;
            this.dgvDSTheLoai.Size = new System.Drawing.Size(1072, 203);
            this.dgvDSTheLoai.TabIndex = 0;
            this.dgvDSTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTheLoai_CellClick);
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã Thể Loại";
            this.MaTL.MinimumWidth = 6;
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            this.MaTL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Tên Thể Loại";
            this.TenTL.MinimumWidth = 6;
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            this.TenTL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grbTimKiem);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(675, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(405, 203);
            this.panel7.TabIndex = 1;
            // 
            // frmDanhSachTheLoai
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhSachTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thể loại";
            this.Load += new System.EventHandler(this.frmDanhSachTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTKTenTL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSTheLoai;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
    }
}