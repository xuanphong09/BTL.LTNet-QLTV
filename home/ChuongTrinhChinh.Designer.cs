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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.a = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachDG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachTG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.nXBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuPhạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAccount,
            this.thểLoạiToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.a,
            this.toolStripMenuItem16,
            this.toolStripMenuItem21,
            this.toolStripMenuItem26,
            this.nXBToolStripMenuItem,
            this.phiếuPhạtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 35);
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
            this.MenuItemAccount.Size = new System.Drawing.Size(122, 29);
            this.MenuItemAccount.Text = "Tài khoản";
            // 
            // MenuItemAccountView
            // 
            this.MenuItemAccountView.Name = "MenuItemAccountView";
            this.MenuItemAccountView.Size = new System.Drawing.Size(298, 34);
            this.MenuItemAccountView.Text = "Xem danh sách";
            this.MenuItemAccountView.Click += new System.EventHandler(this.MenuItemAccountView_Click);
            // 
            // MenuItemAccountEdit
            // 
            this.MenuItemAccountEdit.Name = "MenuItemAccountEdit";
            this.MenuItemAccountEdit.Size = new System.Drawing.Size(298, 34);
            this.MenuItemAccountEdit.Text = "Chỉnh sửa thông tin";
            this.MenuItemAccountEdit.Click += new System.EventHandler(this.MenuItemAccountEdit_Click);
            // 
            // MenuItemAccountChangePass
            // 
            this.MenuItemAccountChangePass.Name = "MenuItemAccountChangePass";
            this.MenuItemAccountChangePass.Size = new System.Drawing.Size(298, 34);
            this.MenuItemAccountChangePass.Text = "Đổi mật khẩu";
            this.MenuItemAccountChangePass.Click += new System.EventHandler(this.MenuItemAccountChangePass_Click);
            // 
            // MenuItemAccountLogout
            // 
            this.MenuItemAccountLogout.Name = "MenuItemAccountLogout";
            this.MenuItemAccountLogout.Size = new System.Drawing.Size(298, 34);
            this.MenuItemAccountLogout.Text = "Đăng Xuất";
            this.MenuItemAccountLogout.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // MenuItemAccountExit
            // 
            this.MenuItemAccountExit.Name = "MenuItemAccountExit";
            this.MenuItemAccountExit.Size = new System.Drawing.Size(298, 34);
            this.MenuItemAccountExit.Text = "Thoát";
            this.MenuItemAccountExit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem1
            // 
            this.thểLoạiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchToolStripMenuItem});
            this.thểLoạiToolStripMenuItem1.Name = "thểLoạiToolStripMenuItem1";
            this.thểLoạiToolStripMenuItem1.Size = new System.Drawing.Size(105, 29);
            this.thểLoạiToolStripMenuItem1.Text = "Thể loại";
            // 
            // xemDanhSáchToolStripMenuItem
            // 
            this.xemDanhSáchToolStripMenuItem.Name = "xemDanhSáchToolStripMenuItem";
            this.xemDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.xemDanhSáchToolStripMenuItem.Text = "Xem danh sách";
            this.xemDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchToolStripMenuItem_Click);
            // 
            // thêmThểLoạiToolStripMenuItem
            // 
            this.thêmThểLoạiToolStripMenuItem.Name = "thêmThểLoạiToolStripMenuItem";
            this.thêmThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thêmThểLoạiToolStripMenuItem.Text = "Thêm";
            // 
            // sửaThểLoạiToolStripMenuItem
            // 
            this.sửaThểLoạiToolStripMenuItem.Name = "sửaThểLoạiToolStripMenuItem";
            this.sửaThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sửaThểLoạiToolStripMenuItem.Text = "Sửa";
            this.sửaThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.sửaThểLoạiToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 29);
            this.toolStripMenuItem1.Text = "Nhà Xuất bản";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem2.Text = "Xem danh sách";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem3.Text = "Thêm";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem4.Text = "Sửa";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem5.Text = "Xóa";
            // 
            // a
            // 
            this.a.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhSachDG});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(103, 29);
            this.a.Text = "Đọc giả";
            // 
            // tsmiDanhSachDG
            // 
            this.tsmiDanhSachDG.Name = "tsmiDanhSachDG";
            this.tsmiDanhSachDG.Size = new System.Drawing.Size(270, 34);
            this.tsmiDanhSachDG.Text = "Xem danh sách";
            this.tsmiDanhSachDG.Click += new System.EventHandler(this.tsmiDanhSachDG_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17});
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(77, 29);
            this.toolStripMenuItem16.Text = "Sách";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(262, 34);
            this.toolStripMenuItem17.Text = "Xem danh sách";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(262, 34);
            this.toolStripMenuItem18.Text = "Thêm";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(262, 34);
            this.toolStripMenuItem19.Text = "Sửa";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(262, 34);
            this.toolStripMenuItem20.Text = "Xóa";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhSachTG});
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(100, 29);
            this.toolStripMenuItem21.Text = "Tác giả";
            // 
            // tsmiDanhSachTG
            // 
            this.tsmiDanhSachTG.Name = "tsmiDanhSachTG";
            this.tsmiDanhSachTG.Size = new System.Drawing.Size(262, 34);
            this.tsmiDanhSachTG.Text = "Xem danh sách";
            this.tsmiDanhSachTG.Click += new System.EventHandler(this.tsmiDanhSachTG_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(169, 29);
            this.toolStripMenuItem26.Text = "Mượn trả sách";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
            // 
            // nXBToolStripMenuItem
            // 
            this.nXBToolStripMenuItem.Name = "nXBToolStripMenuItem";
            this.nXBToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.nXBToolStripMenuItem.Text = "NXB";
            this.nXBToolStripMenuItem.Click += new System.EventHandler(this.nXBToolStripMenuItem_Click);
            // 
            // phiếuPhạtToolStripMenuItem
            // 
            this.phiếuPhạtToolStripMenuItem.Name = "phiếuPhạtToolStripMenuItem";
            this.phiếuPhạtToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.phiếuPhạtToolStripMenuItem.Text = "Phiếu Phạt";
            this.phiếuPhạtToolStripMenuItem.Click += new System.EventHandler(this.phiếuPhạtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 665);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountEdit;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem a;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachDG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachTG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountChangePass;
        private System.Windows.Forms.ToolStripMenuItem nXBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuPhạtToolStripMenuItem;
    }
}

