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
            this.MenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountExit = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachTG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAccount,
            this.thểLoạiToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem16,
            this.toolStripMenuItem21,
            this.toolStripMenuItem26,
            this.toolStripMenuItem31});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemAccount
            // 
            this.MenuItemAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAccountView,
            this.MenuItemAccountEdit,
            this.MenuItemAccountChangePass,
            this.MenuItemAccountLogout,
            this.MenuItemAccountExit});
            this.MenuItemAccount.Name = "MenuItemAccount";
            this.MenuItemAccount.Size = new System.Drawing.Size(104, 25);
            this.MenuItemAccount.Text = "Tài khoản";
            // 
            // MenuItemAccountView
            // 
            this.MenuItemAccountView.Name = "MenuItemAccountView";
            this.MenuItemAccountView.Size = new System.Drawing.Size(251, 26);
            this.MenuItemAccountView.Text = "Xem danh sách";
            this.MenuItemAccountView.Click += new System.EventHandler(this.MenuItemAccountView_Click);
            // 
            // MenuItemAccountEdit
            // 
            this.MenuItemAccountEdit.Name = "MenuItemAccountEdit";
            this.MenuItemAccountEdit.Size = new System.Drawing.Size(251, 26);
            this.MenuItemAccountEdit.Text = "Chỉnh sửa thông tin";
            this.MenuItemAccountEdit.Click += new System.EventHandler(this.MenuItemAccountEdit_Click);
            // 
            // MenuItemAccountChangePass
            // 
            this.MenuItemAccountChangePass.Name = "MenuItemAccountChangePass";
            this.MenuItemAccountChangePass.Size = new System.Drawing.Size(251, 26);
            this.MenuItemAccountChangePass.Text = "Đổi mật khẩu";
            this.MenuItemAccountChangePass.Click += new System.EventHandler(this.MenuItemAccountChangePass_Click);
            // 
            // MenuItemAccountLogout
            // 
            this.MenuItemAccountLogout.Name = "MenuItemAccountLogout";
            this.MenuItemAccountLogout.Size = new System.Drawing.Size(251, 26);
            this.MenuItemAccountLogout.Text = "Đăng Xuất";
            this.MenuItemAccountLogout.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // MenuItemAccountExit
            // 
            this.MenuItemAccountExit.Name = "MenuItemAccountExit";
            this.MenuItemAccountExit.Size = new System.Drawing.Size(251, 26);
            this.MenuItemAccountExit.Text = "Thoát";
            this.MenuItemAccountExit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem1
            // 
            this.thểLoạiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchToolStripMenuItem,
            this.thêmThểLoạiToolStripMenuItem,
            this.sửaThểLoạiToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.thểLoạiToolStripMenuItem1.Name = "thểLoạiToolStripMenuItem1";
            this.thểLoạiToolStripMenuItem1.Size = new System.Drawing.Size(89, 25);
            this.thểLoạiToolStripMenuItem1.Text = "Thể loại";
            // 
            // xemDanhSáchToolStripMenuItem
            // 
            this.xemDanhSáchToolStripMenuItem.Name = "xemDanhSáchToolStripMenuItem";
            this.xemDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.xemDanhSáchToolStripMenuItem.Text = "Xem danh sách";
            // 
            // thêmThểLoạiToolStripMenuItem
            // 
            this.thêmThểLoạiToolStripMenuItem.Name = "thêmThểLoạiToolStripMenuItem";
            this.thêmThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.thêmThểLoạiToolStripMenuItem.Text = "Thêm";
            // 
            // sửaThểLoạiToolStripMenuItem
            // 
            this.sửaThểLoạiToolStripMenuItem.Name = "sửaThểLoạiToolStripMenuItem";
            this.sửaThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sửaThểLoạiToolStripMenuItem.Text = "Sửa";
            this.sửaThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.sửaThểLoạiToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 25);
            this.toolStripMenuItem1.Text = "Nhà Xuất bản";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem2.Text = "Xem danh sách";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem3.Text = "Thêm";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem4.Text = "Sửa";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem5.Text = "Xóa";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(85, 25);
            this.toolStripMenuItem6.Text = "Đọc giả";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem7.Text = "Xem danh sách";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem8.Text = "Thêm";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem9.Text = "Sửa";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem10.Text = "Xóa";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20});
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(65, 25);
            this.toolStripMenuItem16.Text = "Sách";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem17.Text = "Xem danh sách";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem18.Text = "Thêm";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem19.Text = "Sửa";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem20.Text = "Xóa";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhSachTG,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25});
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(84, 25);
            this.toolStripMenuItem21.Text = "Tác giả";
            // 
            // tsmiDanhSachTG
            // 
            this.tsmiDanhSachTG.Name = "tsmiDanhSachTG";
            this.tsmiDanhSachTG.Size = new System.Drawing.Size(224, 26);
            this.tsmiDanhSachTG.Text = "Xem danh sách";
            this.tsmiDanhSachTG.Click += new System.EventHandler(this.tsmiDanhSachTG_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem23.Text = "Thêm";
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem24.Text = "Sửa";
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem25.Text = "Xóa";
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem27,
            this.toolStripMenuItem28,
            this.toolStripMenuItem29,
            this.toolStripMenuItem30});
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(123, 25);
            this.toolStripMenuItem26.Text = "Phiếu mượn";
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem27.Text = "Xem danh sách";
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem28.Text = "Thêm";
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem29.Text = "Sửa";
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem30.Text = "Xóa";
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.toolStripMenuItem35});
            this.toolStripMenuItem31.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(96, 25);
            this.toolStripMenuItem31.Text = "Phiếu trả";
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem32.Text = "Xem danh sách";
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem33.Text = "Thêm";
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem34.Text = "Sửa";
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem35.Text = "Xóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 633);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountEdit;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachTG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountChangePass;
    }
}

