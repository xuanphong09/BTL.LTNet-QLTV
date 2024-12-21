namespace home
{
    partial class InPhieuMuonTra
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
            this.rvPhieuMuonTra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvPhieuMuonTra
            // 
            this.rvPhieuMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPhieuMuonTra.Location = new System.Drawing.Point(0, 0);
            this.rvPhieuMuonTra.Name = "rvPhieuMuonTra";
            this.rvPhieuMuonTra.ServerReport.BearerToken = null;
            this.rvPhieuMuonTra.Size = new System.Drawing.Size(875, 665);
            this.rvPhieuMuonTra.TabIndex = 0;
            // 
            // InPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 665);
            this.Controls.Add(this.rvPhieuMuonTra);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "InPhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Phiếu mượn trả";
            this.Load += new System.EventHandler(this.InPhieuMuonTra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPhieuMuonTra;
    }
}