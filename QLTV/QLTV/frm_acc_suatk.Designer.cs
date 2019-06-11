namespace QLTV
{
    partial class frm_acc_suatk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_acc_suatk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_acc_s = new System.Windows.Forms.Button();
            this.txb_acc_pass = new System.Windows.Forms.TextBox();
            this.txb_acc_repass = new System.Windows.Forms.TextBox();
            this.txb_acc_use = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_acc_s);
            this.panel1.Controls.Add(this.txb_acc_pass);
            this.panel1.Controls.Add(this.txb_acc_repass);
            this.panel1.Controls.Add(this.txb_acc_use);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 426);
            this.panel1.TabIndex = 1;
            // 
            // btn_acc_s
            // 
            this.btn_acc_s.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_acc_s.Image = ((System.Drawing.Image)(resources.GetObject("btn_acc_s.Image")));
            this.btn_acc_s.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acc_s.Location = new System.Drawing.Point(451, 303);
            this.btn_acc_s.Name = "btn_acc_s";
            this.btn_acc_s.Size = new System.Drawing.Size(125, 67);
            this.btn_acc_s.TabIndex = 5;
            this.btn_acc_s.Text = "         Sửa thông tin";
            this.btn_acc_s.UseVisualStyleBackColor = false;
            this.btn_acc_s.Click += new System.EventHandler(this.btn_acc_t_Click);
            // 
            // txb_acc_pass
            // 
            this.txb_acc_pass.Location = new System.Drawing.Point(244, 189);
            this.txb_acc_pass.Name = "txb_acc_pass";
            this.txb_acc_pass.Size = new System.Drawing.Size(342, 20);
            this.txb_acc_pass.TabIndex = 2;
            this.txb_acc_pass.UseSystemPasswordChar = true;
            // 
            // txb_acc_repass
            // 
            this.txb_acc_repass.Location = new System.Drawing.Point(244, 244);
            this.txb_acc_repass.Name = "txb_acc_repass";
            this.txb_acc_repass.Size = new System.Drawing.Size(342, 20);
            this.txb_acc_repass.TabIndex = 3;
            this.txb_acc_repass.UseSystemPasswordChar = true;
            // 
            // txb_acc_use
            // 
            this.txb_acc_use.Location = new System.Drawing.Point(244, 138);
            this.txb_acc_use.Name = "txb_acc_use";
            this.txb_acc_use.Size = new System.Drawing.Size(342, 20);
            this.txb_acc_use.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA THÔNG TIN TÀI KHOẢN";
            // 
            // frm_acc_suatk
            // 
            this.AcceptButton = this.btn_acc_s;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_acc_suatk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_acc_suatk";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_acc_s;
        private System.Windows.Forms.TextBox txb_acc_pass;
        private System.Windows.Forms.TextBox txb_acc_repass;
        private System.Windows.Forms.TextBox txb_acc_use;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}