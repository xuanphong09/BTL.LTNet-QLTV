namespace home
{
    partial class DoiMatKhauUser
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
            this.ptbCFPass = new System.Windows.Forms.PictureBox();
            this.ptbNewPass = new System.Windows.Forms.PictureBox();
            this.ptbOldPass = new System.Windows.Forms.PictureBox();
            this.txtCFPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCFPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOldPass)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbCFPass);
            this.panel2.Controls.Add(this.ptbNewPass);
            this.panel2.Controls.Add(this.ptbOldPass);
            this.panel2.Controls.Add(this.txtCFPass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNewPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOldPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 191);
            this.panel2.TabIndex = 1;
            // 
            // ptbCFPass
            // 
            this.ptbCFPass.Image = global::home.Properties.Resources.eye_slash_fill;
            this.ptbCFPass.Location = new System.Drawing.Point(389, 112);
            this.ptbCFPass.Name = "ptbCFPass";
            this.ptbCFPass.Size = new System.Drawing.Size(23, 20);
            this.ptbCFPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCFPass.TabIndex = 7;
            this.ptbCFPass.TabStop = false;
            this.ptbCFPass.Click += new System.EventHandler(this.ptbCFPass_Click);
            // 
            // ptbNewPass
            // 
            this.ptbNewPass.Image = global::home.Properties.Resources.eye_slash_fill;
            this.ptbNewPass.Location = new System.Drawing.Point(389, 76);
            this.ptbNewPass.Name = "ptbNewPass";
            this.ptbNewPass.Size = new System.Drawing.Size(23, 20);
            this.ptbNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNewPass.TabIndex = 6;
            this.ptbNewPass.TabStop = false;
            this.ptbNewPass.Click += new System.EventHandler(this.ptbNewPass_Click);
            // 
            // ptbOldPass
            // 
            this.ptbOldPass.Image = global::home.Properties.Resources.eye_slash_fill;
            this.ptbOldPass.Location = new System.Drawing.Point(389, 38);
            this.ptbOldPass.Name = "ptbOldPass";
            this.ptbOldPass.Size = new System.Drawing.Size(23, 20);
            this.ptbOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbOldPass.TabIndex = 1;
            this.ptbOldPass.TabStop = false;
            this.ptbOldPass.Click += new System.EventHandler(this.ptbOldPass_Click);
            // 
            // txtCFPass
            // 
            this.txtCFPass.Location = new System.Drawing.Point(193, 107);
            this.txtCFPass.Name = "txtCFPass";
            this.txtCFPass.Size = new System.Drawing.Size(173, 30);
            this.txtCFPass.TabIndex = 5;
            this.txtCFPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu:  ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(193, 71);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(173, 30);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới: ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(193, 33);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(173, 30);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 292);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14F);
            this.btnCancel.Image = global::home.Properties.Resources.icons8_clear_32;
            this.btnCancel.Location = new System.Drawing.Point(251, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F);
            this.btnSave.Image = global::home.Properties.Resources.icons8_save_32;
            this.btnSave.Location = new System.Drawing.Point(65, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // DoiMatKhauUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoiMatKhauUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCFPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOldPass)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCFPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbOldPass;
        private System.Windows.Forms.PictureBox ptbCFPass;
        private System.Windows.Forms.PictureBox ptbNewPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider err;
    }
}