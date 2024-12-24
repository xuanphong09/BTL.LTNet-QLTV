namespace home
{
    partial class QuanLyNXB
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NXBList = new System.Windows.Forms.DataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NXBList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 413);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.exitBtn);
            this.panel5.Controls.Add(this.saveBtn);
            this.panel5.Controls.Add(this.emailTB);
            this.panel5.Controls.Add(this.addressTB);
            this.panel5.Controls.Add(this.nameTB);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(716, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 353);
            this.panel5.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(176, 225);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 32);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Th&oát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(32, 225);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 32);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(108, 163);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(172, 29);
            this.emailTB.TabIndex = 5;
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTB.Location = new System.Drawing.Point(108, 101);
            this.addressTB.Margin = new System.Windows.Forms.Padding(2);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(172, 29);
            this.addressTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(108, 35);
            this.nameTB.Margin = new System.Windows.Forms.Padding(2);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(172, 29);
            this.nameTB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên NXB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label3.AllowDrop = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NXBList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 353);
            this.panel4.TabIndex = 2;
            // 
            // NXBList
            // 
            this.NXBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NXBList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChi,
            this.Email});
            this.NXBList.Dock = System.Windows.Forms.DockStyle.Top;
            this.NXBList.Location = new System.Drawing.Point(0, 0);
            this.NXBList.Margin = new System.Windows.Forms.Padding(2);
            this.NXBList.Name = "NXBList";
            this.NXBList.RowHeadersWidth = 62;
            this.NXBList.RowTemplate.Height = 28;
            this.NXBList.Size = new System.Drawing.Size(716, 325);
            this.NXBList.TabIndex = 1;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "MaNXB";
            this.MaNXB.MinimumWidth = 8;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Width = 150;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.MinimumWidth = 8;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Width = 160;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 180;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.createBtn);
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.updateBtn);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.searchTB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 60);
            this.panel3.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(536, 9);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(124, 40);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "&Thêm";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(884, 9);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(124, 40);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "&Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(710, 9);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(124, 40);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "&Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(362, 9);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 40);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm &Kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBTn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(11, 16);
            this.searchTB.Margin = new System.Windows.Forms.Padding(2);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(301, 26);
            this.searchTB.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 59);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý NXB";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // QuanLyNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNXB";
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.QuanLyNXB_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NXBList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView NXBList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}