namespace home
{
    partial class LapCTPhieuMuon
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbNTTS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLTK = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSLMuon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPM = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbNTTS.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPM)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 490);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbNTTS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(733, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 490);
            this.panel4.TabIndex = 3;
            // 
            // gbNTTS
            // 
            this.gbNTTS.Controls.Add(this.label3);
            this.gbNTTS.Controls.Add(this.txtTenNXB);
            this.gbNTTS.Controls.Add(this.label2);
            this.gbNTTS.Controls.Add(this.txtTenTG);
            this.gbNTTS.Controls.Add(this.label1);
            this.gbNTTS.Controls.Add(this.txtSLTK);
            this.gbNTTS.Controls.Add(this.cbMaSach);
            this.gbNTTS.Controls.Add(this.btnHuy);
            this.gbNTTS.Controls.Add(this.btnLuu);
            this.gbNTTS.Controls.Add(this.label13);
            this.gbNTTS.Controls.Add(this.label10);
            this.gbNTTS.Controls.Add(this.txtTenSach);
            this.gbNTTS.Controls.Add(this.txtSLMuon);
            this.gbNTTS.Controls.Add(this.label9);
            this.gbNTTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNTTS.Location = new System.Drawing.Point(0, 0);
            this.gbNTTS.Name = "gbNTTS";
            this.gbNTTS.Size = new System.Drawing.Size(402, 490);
            this.gbNTTS.TabIndex = 0;
            this.gbNTTS.TabStop = false;
            this.gbNTTS.Text = "Nhập thông tin sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sách:";
            // 
            // txtSLTK
            // 
            this.txtSLTK.Location = new System.Drawing.Point(188, 251);
            this.txtSLTK.Name = "txtSLTK";
            this.txtSLTK.ReadOnly = true;
            this.txtSLTK.Size = new System.Drawing.Size(176, 30);
            this.txtSLTK.TabIndex = 9;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(188, 78);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(176, 31);
            this.cbMaSach.TabIndex = 1;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(226, 430);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 33);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(31, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 33);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "SL trong kho:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(188, 122);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(176, 30);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtSLMuon
            // 
            this.txtSLMuon.Location = new System.Drawing.Point(188, 294);
            this.txtSLMuon.Name = "txtSLMuon";
            this.txtSLMuon.Size = new System.Drawing.Size(176, 30);
            this.txtSLMuon.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số lượng mượn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 490);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSCTPM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mượn sách:";
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
            this.SLMuon});
            this.dgvDSCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCTPM.Location = new System.Drawing.Point(3, 26);
            this.dgvDSCTPM.Name = "dgvDSCTPM";
            this.dgvDSCTPM.ReadOnly = true;
            this.dgvDSCTPM.RowHeadersWidth = 51;
            this.dgvDSCTPM.RowTemplate.Height = 24;
            this.dgvDSCTPM.Size = new System.Drawing.Size(727, 461);
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
            this.TenSach.HeaderText = "Tên Sách";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 88);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXong);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnQuayLai);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1135, 88);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(959, 29);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(108, 33);
            this.btnXong.TabIndex = 4;
            this.btnXong.Text = "X&ong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(737, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(515, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 33);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(293, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 33);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(71, 29);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(108, 33);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "&Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên tác giả:";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(188, 165);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(176, 30);
            this.txtTenTG.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhà xuất bản:";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(188, 208);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(176, 30);
            this.txtTenNXB.TabIndex = 7;
            // 
            // LapCTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LapCTPhieuMuon";
            this.Size = new System.Drawing.Size(1135, 578);
            this.Load += new System.EventHandler(this.LapCTPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbNTTS.ResumeLayout(false);
            this.gbNTTS.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbNTTS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSLMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dgvDSCTPM;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTG;
    }
}
