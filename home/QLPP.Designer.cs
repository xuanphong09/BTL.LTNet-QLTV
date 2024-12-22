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
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.maDGTB = new System.Windows.Forms.TextBox();
            this.lydoTB = new System.Windows.Forms.RichTextBox();
            this.hinhthucTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PPGrid = new System.Windows.Forms.DataGridView();
            this.SoPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu phạt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchCB);
            this.panel2.Controls.Add(this.searchTB);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 74);
            this.panel2.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(510, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(162, 50);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchCB
            // 
            this.searchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "Số Phiếu Phạt",
            "Mã Độc Giả",
            "Mã Nhân Viên"});
            this.searchCB.Location = new System.Drawing.Point(297, 9);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(196, 37);
            this.searchCB.TabIndex = 4;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(12, 11);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(268, 35);
            this.searchTB.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(995, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 50);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(861, 11);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 50);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(727, 11);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(111, 50);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Thêm";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.maDGTB);
            this.panel3.Controls.Add(this.lydoTB);
            this.panel3.Controls.Add(this.hinhthucTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 440);
            this.panel3.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(939, 378);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 50);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(759, 378);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 50);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // maDGTB
            // 
            this.maDGTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDGTB.Location = new System.Drawing.Point(709, 49);
            this.maDGTB.Name = "maDGTB";
            this.maDGTB.Size = new System.Drawing.Size(243, 39);
            this.maDGTB.TabIndex = 6;
            // 
            // lydoTB
            // 
            this.lydoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lydoTB.Location = new System.Drawing.Point(709, 135);
            this.lydoTB.Name = "lydoTB";
            this.lydoTB.Size = new System.Drawing.Size(350, 69);
            this.lydoTB.TabIndex = 5;
            this.lydoTB.Text = "";
            // 
            // hinhthucTB
            // 
            this.hinhthucTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhthucTB.Location = new System.Drawing.Point(709, 276);
            this.hinhthucTB.Name = "hinhthucTB";
            this.hinhthucTB.Size = new System.Drawing.Size(365, 87);
            this.hinhthucTB.TabIndex = 4;
            this.hinhthucTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hình thức sử phạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lý do phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Độc Giả";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PPGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 440);
            this.panel4.TabIndex = 0;
            // 
            // PPGrid
            // 
            this.PPGrid.AllowUserToAddRows = false;
            this.PPGrid.AllowUserToDeleteRows = false;
            this.PPGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuPhat,
            this.MaDG,
            this.LyDoPhat,
            this.HinhThucXL,
            this.NgayPhat,
            this.MaNV});
            this.PPGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPGrid.Location = new System.Drawing.Point(0, 0);
            this.PPGrid.Name = "PPGrid";
            this.PPGrid.ReadOnly = true;
            this.PPGrid.RowHeadersWidth = 62;
            this.PPGrid.RowTemplate.Height = 28;
            this.PPGrid.Size = new System.Drawing.Size(672, 440);
            this.PPGrid.TabIndex = 0;
            this.PPGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PPGrid_CellClick);
            // 
            // SoPhieuPhat
            // 
            this.SoPhieuPhat.DataPropertyName = "SoPhieuPhat";
            this.SoPhieuPhat.HeaderText = "Số phiếu phạt";
            this.SoPhieuPhat.MinimumWidth = 8;
            this.SoPhieuPhat.Name = "SoPhieuPhat";
            this.SoPhieuPhat.ReadOnly = true;
            this.SoPhieuPhat.Width = 150;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Ma Độc Giả";
            this.MaDG.MinimumWidth = 8;
            this.MaDG.Name = "MaDG";
            this.MaDG.ReadOnly = true;
            this.MaDG.Width = 150;
            // 
            // LyDoPhat
            // 
            this.LyDoPhat.DataPropertyName = "LyDoPhat";
            this.LyDoPhat.HeaderText = "Lý do phạt";
            this.LyDoPhat.MinimumWidth = 8;
            this.LyDoPhat.Name = "LyDoPhat";
            this.LyDoPhat.ReadOnly = true;
            this.LyDoPhat.Width = 150;
            // 
            // HinhThucXL
            // 
            this.HinhThucXL.DataPropertyName = "HinhThucXL";
            this.HinhThucXL.HeaderText = "Hình Thức Xử Lý";
            this.HinhThucXL.MinimumWidth = 8;
            this.HinhThucXL.Name = "HinhThucXL";
            this.HinhThucXL.ReadOnly = true;
            this.HinhThucXL.Width = 150;
            // 
            // NgayPhat
            // 
            this.NgayPhat.DataPropertyName = "NgayPhat";
            this.NgayPhat.HeaderText = "Ngày Phạt";
            this.NgayPhat.MinimumWidth = 8;
            this.NgayPhat.Name = "NgayPhat";
            this.NgayPhat.ReadOnly = true;
            this.NgayPhat.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // QLPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLPP";
            this.Text = "Phiếu phạt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PPGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView PPGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox lydoTB;
        private System.Windows.Forms.RichTextBox hinhthucTB;
        private System.Windows.Forms.TextBox maDGTB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}