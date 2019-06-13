namespace QLTV
{
    partial class Urc_phieumuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urc_phieumuon));
            this.panel_pm1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pm_x = new System.Windows.Forms.Button();
            this.btn_pm_s = new System.Windows.Forms.Button();
            this.label_pm1 = new System.Windows.Forms.Label();
            this.btn_pm_t = new System.Windows.Forms.Button();
            this.pnl_pm2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgw_pm = new System.Windows.Forms.DataGridView();
            this.txb_pm_tk = new System.Windows.Forms.TextBox();
            this.btn_pm_tk = new System.Windows.Forms.Button();
            this.btn_pm_ct = new System.Windows.Forms.Button();
            this.pnl_ds3 = new System.Windows.Forms.Panel();
            this.panel_pm1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_pm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_pm)).BeginInit();
            this.pnl_ds3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pm1
            // 
            this.panel_pm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_pm1.BackgroundImage")));
            this.panel_pm1.Controls.Add(this.panel1);
            this.panel_pm1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_pm1.Location = new System.Drawing.Point(0, 0);
            this.panel_pm1.Name = "panel_pm1";
            this.panel_pm1.Size = new System.Drawing.Size(384, 707);
            this.panel_pm1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_pm_x);
            this.panel1.Controls.Add(this.btn_pm_s);
            this.panel1.Controls.Add(this.label_pm1);
            this.panel1.Controls.Add(this.btn_pm_t);
            this.panel1.Location = new System.Drawing.Point(44, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 527);
            this.panel1.TabIndex = 5;
            // 
            // btn_pm_x
            // 
            this.btn_pm_x.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pm_x.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_x.Image")));
            this.btn_pm_x.Location = new System.Drawing.Point(63, 398);
            this.btn_pm_x.Name = "btn_pm_x";
            this.btn_pm_x.Size = new System.Drawing.Size(169, 81);
            this.btn_pm_x.TabIndex = 4;
            this.btn_pm_x.Text = "Xem chi tiết";
            this.btn_pm_x.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pm_x.UseVisualStyleBackColor = false;
            this.btn_pm_x.Click += new System.EventHandler(this.btn_pm_x_Click);
            // 
            // btn_pm_s
            // 
            this.btn_pm_s.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pm_s.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_s.Image")));
            this.btn_pm_s.Location = new System.Drawing.Point(63, 260);
            this.btn_pm_s.Name = "btn_pm_s";
            this.btn_pm_s.Size = new System.Drawing.Size(169, 81);
            this.btn_pm_s.TabIndex = 3;
            this.btn_pm_s.Text = "Sửa/ Trả sách";
            this.btn_pm_s.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pm_s.UseVisualStyleBackColor = false;
            this.btn_pm_s.Click += new System.EventHandler(this.btn_pm_s_Click);
            // 
            // label_pm1
            // 
            this.label_pm1.AutoSize = true;
            this.label_pm1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pm1.Location = new System.Drawing.Point(8, 68);
            this.label_pm1.Name = "label_pm1";
            this.label_pm1.Size = new System.Drawing.Size(287, 26);
            this.label_pm1.TabIndex = 0;
            this.label_pm1.Text = "QUẢN LÝ PHIẾU MƯỢN";
            // 
            // btn_pm_t
            // 
            this.btn_pm_t.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pm_t.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_t.Image")));
            this.btn_pm_t.Location = new System.Drawing.Point(63, 129);
            this.btn_pm_t.Name = "btn_pm_t";
            this.btn_pm_t.Size = new System.Drawing.Size(169, 81);
            this.btn_pm_t.TabIndex = 2;
            this.btn_pm_t.Text = "Thêm";
            this.btn_pm_t.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pm_t.UseVisualStyleBackColor = false;
            this.btn_pm_t.Click += new System.EventHandler(this.btn_pm_t_Click);
            // 
            // pnl_pm2
            // 
            this.pnl_pm2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnl_pm2.Controls.Add(this.dtgw_pm);
            this.pnl_pm2.Location = new System.Drawing.Point(398, 83);
            this.pnl_pm2.Name = "pnl_pm2";
            this.pnl_pm2.Size = new System.Drawing.Size(917, 624);
            this.pnl_pm2.TabIndex = 2;
            // 
            // dtgw_pm
            // 
            this.dtgw_pm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgw_pm.BackgroundColor = System.Drawing.Color.White;
            this.dtgw_pm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_pm.Location = new System.Drawing.Point(3, 3);
            this.dtgw_pm.Name = "dtgw_pm";
            this.dtgw_pm.Size = new System.Drawing.Size(914, 491);
            this.dtgw_pm.TabIndex = 3;
            // 
            // txb_pm_tk
            // 
            this.txb_pm_tk.Location = new System.Drawing.Point(85, 27);
            this.txb_pm_tk.Name = "txb_pm_tk";
            this.txb_pm_tk.Size = new System.Drawing.Size(364, 20);
            this.txb_pm_tk.TabIndex = 0;
            // 
            // btn_pm_tk
            // 
            this.btn_pm_tk.Location = new System.Drawing.Point(455, 24);
            this.btn_pm_tk.Name = "btn_pm_tk";
            this.btn_pm_tk.Size = new System.Drawing.Size(151, 23);
            this.btn_pm_tk.TabIndex = 10;
            this.btn_pm_tk.Text = "Tìm kiếm theo mã";
            this.btn_pm_tk.UseVisualStyleBackColor = true;
            // 
            // btn_pm_ct
            // 
            this.btn_pm_ct.Location = new System.Drawing.Point(612, 25);
            this.btn_pm_ct.Name = "btn_pm_ct";
            this.btn_pm_ct.Size = new System.Drawing.Size(159, 23);
            this.btn_pm_ct.TabIndex = 1;
            this.btn_pm_ct.Text = "Chi tiết theo mã";
            this.btn_pm_ct.UseVisualStyleBackColor = true;
            // 
            // pnl_ds3
            // 
            this.pnl_ds3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_ds3.Controls.Add(this.btn_pm_ct);
            this.pnl_ds3.Controls.Add(this.btn_pm_tk);
            this.pnl_ds3.Controls.Add(this.txb_pm_tk);
            this.pnl_ds3.Location = new System.Drawing.Point(401, 3);
            this.pnl_ds3.Name = "pnl_ds3";
            this.pnl_ds3.Size = new System.Drawing.Size(911, 74);
            this.pnl_ds3.TabIndex = 3;
            // 
            // Urc_phieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_ds3);
            this.Controls.Add(this.pnl_pm2);
            this.Controls.Add(this.panel_pm1);
            this.Name = "Urc_phieumuon";
            this.Size = new System.Drawing.Size(1315, 707);
            this.Load += new System.EventHandler(this.Urc_phieumuon_Load);
            this.panel_pm1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_pm2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_pm)).EndInit();
            this.pnl_ds3.ResumeLayout(false);
            this.pnl_ds3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pm1;
        private System.Windows.Forms.Button btn_pm_s;
        private System.Windows.Forms.Button btn_pm_x;
        private System.Windows.Forms.Button btn_pm_t;
        private System.Windows.Forms.Label label_pm1;
        private System.Windows.Forms.FlowLayoutPanel pnl_pm2;
        private System.Windows.Forms.DataGridView dtgw_pm;
        private System.Windows.Forms.TextBox txb_pm_tk;
        private System.Windows.Forms.Button btn_pm_tk;
        private System.Windows.Forms.Button btn_pm_ct;
        private System.Windows.Forms.Panel pnl_ds3;
        private System.Windows.Forms.Panel panel1;
    }
}
