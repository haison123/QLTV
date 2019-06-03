using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLTV_BUS;
using QLTV_DTO;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_login : Form
    {
        account_BUS acc_bus = new account_BUS();
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            accounts_DTO acc = new accounts_DTO();
            acc.usename = txb_acc_usn.Text;
            acc.pass = txb_acc_pass.Text;
            int check = acc_bus.login(acc);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    frm_main frm = new frm_main();
                    this.Hide();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_acc_usn.Text = "";
            txb_acc_pass.Text = "";
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
