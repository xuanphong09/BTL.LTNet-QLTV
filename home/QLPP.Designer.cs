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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitmBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PPGrid = new System.Windows.Forms.DataGridView();
            this.SoPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu phạt";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.groupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1488, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiêu chí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập thông tin tìm kiếm:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.deleteBtn, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.deleteBtn.Image = global::home.Properties.Resources.icons8_delete_32;
            this.deleteBtn.Location = new System.Drawing.Point(617, 149);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(146, 46);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitmBtn
            // 
            this.exitmBtn.BackColor = System.Drawing.Color.Red;
            this.exitmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitmBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exitmBtn.ForeColor = System.Drawing.Color.White;
            this.exitmBtn.Location = new System.Drawing.Point(838, 149);
            this.exitmBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exitmBtn.Name = "exitmBtn";
            this.exitmBtn.Size = new System.Drawing.Size(146, 46);
            this.exitmBtn.TabIndex = 7;
            this.exitmBtn.Text = "Thoát";
            this.exitmBtn.UseVisualStyleBackColor = false;
            this.exitmBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.viewBtn, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.viewBtn.Image = global::home.Properties.Resources.eye;
            this.viewBtn.Location = new System.Drawing.Point(294, 149);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(225, 46);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "Xem thông tin";
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(2530, 56);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(318, 88);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.addBtn, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.addBtn.Image = global::home.Properties.Resources.icons8_plus_32;
            this.addBtn.Location = new System.Drawing.Point(46, 149);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(162, 46);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Thêm";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.searchBtn, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.searchBtn.Image = global::home.Properties.Resources.icons8_search_32;
            this.searchBtn.Location = new System.Drawing.Point(807, 78);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(177, 46);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchCB
            // 
            this.searchCB.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "Số Phiếu Phạt",
            "Mã Độc Giả",
            "Mã Nhân Viên"});
            this.searchCB.Location = new System.Drawing.Point(533, 84);
            this.searchCB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(230, 33);
            this.searchCB.TabIndex = 1;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchTB.Location = new System.Drawing.Point(46, 84);
            this.searchTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(339, 33);
            this.searchTB.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 220);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PPGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1488, 460);
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
            this.NV,
            this.NgayPhat,
            this.HinhThucXL,
            this.LyDoPhat});
            this.PPGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPGrid.Location = new System.Drawing.Point(0, 0);
            this.PPGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PPGrid.Name = "PPGrid";
            this.PPGrid.ReadOnly = true;
            this.PPGrid.RowHeadersWidth = 62;
            this.PPGrid.RowTemplate.Height = 28;
            this.PPGrid.Size = new System.Drawing.Size(1488, 460);
            this.PPGrid.TabIndex = 4;
            this.PPGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PPGrid_CellClick);
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
            // QLPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1488, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "QLPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phiếu phạt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoPhat;
    }
}