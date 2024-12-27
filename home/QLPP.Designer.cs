namespace home
{
    partial class QLPP
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PPGrid = new System.Windows.Forms.DataGridView();
            this.exitmBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SoPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu phạt";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 168);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.exitmBtn);
            this.groupBox1.Controls.Add(this.viewBtn);
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchCB);
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1381, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(680, 109);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(5);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(221, 49);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "Xem";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(2180, 50);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(274, 78);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(911, 54);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(221, 49);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(680, 54);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(221, 49);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchCB
            // 
            this.searchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "Số Phiếu Phạt",
            "Mã Độc Giả",
            "Mã Nhân Viên"});
            this.searchCB.Location = new System.Drawing.Point(414, 59);
            this.searchCB.Margin = new System.Windows.Forms.Padding(5);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(242, 40);
            this.searchCB.TabIndex = 1;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(85, 59);
            this.searchTB.Margin = new System.Windows.Forms.Padding(5);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(303, 39);
            this.searchTB.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PPGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1381, 802);
            this.panel3.TabIndex = 5;
            // 
            // PPGrid
            // 
            this.PPGrid.AllowUserToAddRows = false;
            this.PPGrid.AllowUserToDeleteRows = false;
            this.PPGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PPGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuPhat,
            this.MaDG,
            this.HinhThucXL,
            this.LyDoPhat,
            this.NV,
            this.NgayPhat});
            this.PPGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPGrid.Location = new System.Drawing.Point(0, 0);
            this.PPGrid.Margin = new System.Windows.Forms.Padding(5);
            this.PPGrid.Name = "PPGrid";
            this.PPGrid.ReadOnly = true;
            this.PPGrid.RowHeadersWidth = 62;
            this.PPGrid.RowTemplate.Height = 28;
            this.PPGrid.Size = new System.Drawing.Size(1381, 802);
            this.PPGrid.TabIndex = 4;
            this.PPGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PPGrid_CellClick);
            // 
            // exitmBtn
            // 
            this.exitmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitmBtn.Location = new System.Drawing.Point(1142, 54);
            this.exitmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitmBtn.Name = "exitmBtn";
            this.exitmBtn.Size = new System.Drawing.Size(221, 49);
            this.exitmBtn.TabIndex = 7;
            this.exitmBtn.Text = "Thoát";
            this.exitmBtn.UseVisualStyleBackColor = true;
            this.exitmBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(911, 109);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(221, 49);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // SoPhieuPhat
            // 
            this.SoPhieuPhat.DataPropertyName = "SoPhieuPhat";
            this.SoPhieuPhat.HeaderText = "Số Phiếu Phạt";
            this.SoPhieuPhat.MinimumWidth = 8;
            this.SoPhieuPhat.Name = "SoPhieuPhat";
            this.SoPhieuPhat.ReadOnly = true;
            this.SoPhieuPhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.MinimumWidth = 8;
            this.MaDG.Name = "MaDG";
            this.MaDG.ReadOnly = true;
            this.MaDG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HinhThucXL
            // 
            this.HinhThucXL.DataPropertyName = "HinhThucXL";
            this.HinhThucXL.HeaderText = "Hình Thức Xử Lý";
            this.HinhThucXL.MinimumWidth = 8;
            this.HinhThucXL.Name = "HinhThucXL";
            this.HinhThucXL.ReadOnly = true;
            this.HinhThucXL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LyDoPhat
            // 
            this.LyDoPhat.DataPropertyName = "LyDoPhat";
            this.LyDoPhat.HeaderText = "Lý do phạt";
            this.LyDoPhat.MinimumWidth = 8;
            this.LyDoPhat.Name = "LyDoPhat";
            this.LyDoPhat.ReadOnly = true;
            this.LyDoPhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NV
            // 
            this.NV.DataPropertyName = "MaNV";
            this.NV.HeaderText = "Mã nhân viên";
            this.NV.MinimumWidth = 8;
            this.NV.Name = "NV";
            this.NV.ReadOnly = true;
            this.NV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayPhat
            // 
            this.NgayPhat.DataPropertyName = "NgayPhat";
            this.NgayPhat.HeaderText = "Ngày Phạt";
            this.NgayPhat.MinimumWidth = 8;
            this.NgayPhat.Name = "NgayPhat";
            this.NgayPhat.ReadOnly = true;
            this.NgayPhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập thông tin tìm kiếm:";
            // 
            // QLPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QLPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu phạt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PPGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView PPGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button exitmBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhat;
        private System.Windows.Forms.Label label2;
    }
}