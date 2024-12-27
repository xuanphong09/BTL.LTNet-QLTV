namespace home
{
    partial class QuanLyPhieuMuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLPT = new System.Windows.Forms.Button();
            this.btnLPM = new System.Windows.Forms.Button();
            this.btnDSPM = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1135, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý mượn trả sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLPT);
            this.panel2.Controls.Add(this.btnLPM);
            this.panel2.Controls.Add(this.btnDSPM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 77);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(947, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "T&hoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLPT
            // 
            this.btnLPT.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLPT.Image = global::home.Properties.Resources.icons8_edit_property_32;
            this.btnLPT.Location = new System.Drawing.Point(702, 20);
            this.btnLPT.Name = "btnLPT";
            this.btnLPT.Size = new System.Drawing.Size(190, 38);
            this.btnLPT.TabIndex = 2;
            this.btnLPT.Text = "Lập phiếu &trả";
            this.btnLPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLPT.UseVisualStyleBackColor = true;
            this.btnLPT.Click += new System.EventHandler(this.btnLPT_Click);
            // 
            // btnLPM
            // 
            this.btnLPM.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLPM.Image = global::home.Properties.Resources.icons8_plus_32;
            this.btnLPM.Location = new System.Drawing.Point(427, 20);
            this.btnLPM.Name = "btnLPM";
            this.btnLPM.Size = new System.Drawing.Size(220, 38);
            this.btnLPM.TabIndex = 1;
            this.btnLPM.Text = "Lập phiếu &mượn";
            this.btnLPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLPM.UseVisualStyleBackColor = true;
            this.btnLPM.Click += new System.EventHandler(this.btnLPM_Click);
            // 
            // btnDSPM
            // 
            this.btnDSPM.BackColor = System.Drawing.Color.White;
            this.btnDSPM.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSPM.Image = global::home.Properties.Resources.Lovepik_com_450094989_Checklist_flat_outline_icon_do_list;
            this.btnDSPM.Location = new System.Drawing.Point(77, 20);
            this.btnDSPM.Name = "btnDSPM";
            this.btnDSPM.Size = new System.Drawing.Size(295, 38);
            this.btnDSPM.TabIndex = 0;
            this.btnDSPM.Text = "&Danh sách phiếu mượn";
            this.btnDSPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSPM.UseVisualStyleBackColor = false;
            this.btnDSPM.Click += new System.EventHandler(this.btnDSPM_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 140);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1135, 578);
            this.panelContent.TabIndex = 1;
            // 
            // QuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1135, 718);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn trả sách";
            this.Load += new System.EventHandler(this.QuanLyPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLPT;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Button btnLPM;
        public System.Windows.Forms.Button btnDSPM;
    }
}