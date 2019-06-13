namespace QLTV
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.txb_acc_pass = new System.Windows.Forms.TextBox();
            this.txb_acc_usn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_dang_nhap);
            this.panel1.Controls.Add(this.txb_acc_pass);
            this.panel1.Controls.Add(this.txb_acc_usn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 154);
            this.panel1.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_thoat.Location = new System.Drawing.Point(205, 79);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 53);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dang_nhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_dang_nhap.Image")));
            this.btn_dang_nhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dang_nhap.Location = new System.Drawing.Point(105, 79);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(87, 53);
            this.btn_dang_nhap.TabIndex = 3;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dang_nhap.UseVisualStyleBackColor = false;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // txb_acc_pass
            // 
            this.txb_acc_pass.Location = new System.Drawing.Point(105, 43);
            this.txb_acc_pass.Name = "txb_acc_pass";
            this.txb_acc_pass.Size = new System.Drawing.Size(187, 20);
            this.txb_acc_pass.TabIndex = 2;
            this.txb_acc_pass.UseSystemPasswordChar = true;
            // 
            // txb_acc_usn
            // 
            this.txb_acc_usn.Location = new System.Drawing.Point(105, 13);
            this.txb_acc_usn.Name = "txb_acc_usn";
            this.txb_acc_usn.Size = new System.Drawing.Size(187, 20);
            this.txb_acc_usn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_dang_nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(417, 248);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.TextBox txb_acc_pass;
        private System.Windows.Forms.TextBox txb_acc_usn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}