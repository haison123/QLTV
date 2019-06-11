namespace QLTV
{
    partial class frm_add_pm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_pm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pm_ch = new System.Windows.Forms.Button();
            this.btn_pm_re = new System.Windows.Forms.Button();
            this.btn_pm_insert = new System.Windows.Forms.Button();
            this.txb_pm_mpm = new System.Windows.Forms.TextBox();
            this.txb_pm_nm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_dg = new System.Windows.Forms.ComboBox();
            this.cbb_tt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 329);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(505, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(272, 329);
            this.listBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn tên sách";
            // 
            // btn_pm_ch
            // 
            this.btn_pm_ch.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_ch.Image")));
            this.btn_pm_ch.Location = new System.Drawing.Point(334, 56);
            this.btn_pm_ch.Name = "btn_pm_ch";
            this.btn_pm_ch.Size = new System.Drawing.Size(134, 41);
            this.btn_pm_ch.TabIndex = 5;
            this.btn_pm_ch.UseVisualStyleBackColor = true;
            this.btn_pm_ch.Click += new System.EventHandler(this.btn_pm_ch_Click);
            // 
            // btn_pm_re
            // 
            this.btn_pm_re.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_re.Image")));
            this.btn_pm_re.Location = new System.Drawing.Point(334, 103);
            this.btn_pm_re.Name = "btn_pm_re";
            this.btn_pm_re.Size = new System.Drawing.Size(134, 41);
            this.btn_pm_re.TabIndex = 6;
            this.btn_pm_re.UseVisualStyleBackColor = true;
            this.btn_pm_re.Click += new System.EventHandler(this.btn_pm_re_Click);
            // 
            // btn_pm_insert
            // 
            this.btn_pm_insert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pm_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_pm_insert.Image")));
            this.btn_pm_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pm_insert.Location = new System.Drawing.Point(336, 356);
            this.btn_pm_insert.Name = "btn_pm_insert";
            this.btn_pm_insert.Size = new System.Drawing.Size(136, 40);
            this.btn_pm_insert.TabIndex = 5;
            this.btn_pm_insert.Text = "          Ghi nhận";
            this.btn_pm_insert.UseVisualStyleBackColor = false;
            this.btn_pm_insert.Click += new System.EventHandler(this.btn_pm_insert_Click);
            // 
            // txb_pm_mpm
            // 
            this.txb_pm_mpm.Location = new System.Drawing.Point(336, 168);
            this.txb_pm_mpm.Name = "txb_pm_mpm";
            this.txb_pm_mpm.Size = new System.Drawing.Size(132, 20);
            this.txb_pm_mpm.TabIndex = 1;
            this.txb_pm_mpm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_pm_nm
            // 
            this.txb_pm_nm.Location = new System.Drawing.Point(336, 272);
            this.txb_pm_nm.Name = "txb_pm_nm";
            this.txb_pm_nm.Size = new System.Drawing.Size(132, 20);
            this.txb_pm_nm.TabIndex = 3;
            this.txb_pm_nm.TextChanged += new System.EventHandler(this.txb_pm_nm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã phiếu mượn ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã thủ thư";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày mượn  VD:02/11/2015";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã độc giả";
            // 
            // cbb_dg
            // 
            this.cbb_dg.FormattingEnabled = true;
            this.cbb_dg.Location = new System.Drawing.Point(336, 318);
            this.cbb_dg.Name = "cbb_dg";
            this.cbb_dg.Size = new System.Drawing.Size(132, 21);
            this.cbb_dg.TabIndex = 17;
            // 
            // cbb_tt
            // 
            this.cbb_tt.FormattingEnabled = true;
            this.cbb_tt.Location = new System.Drawing.Point(336, 222);
            this.cbb_tt.Name = "cbb_tt";
            this.cbb_tt.Size = new System.Drawing.Size(132, 21);
            this.cbb_tt.TabIndex = 17;
            // 
            // frm_add_pm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_tt);
            this.Controls.Add(this.cbb_dg);
            this.Controls.Add(this.btn_pm_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_pm_nm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_pm_mpm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pm_re);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_pm_ch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "frm_add_pm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_pm";
            this.Load += new System.EventHandler(this.frm_add_pm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pm_ch;
        private System.Windows.Forms.Button btn_pm_re;
        private System.Windows.Forms.Button btn_pm_insert;
        private System.Windows.Forms.TextBox txb_pm_mpm;
        private System.Windows.Forms.TextBox txb_pm_nm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_dg;
        private System.Windows.Forms.ComboBox cbb_tt;
    }
}