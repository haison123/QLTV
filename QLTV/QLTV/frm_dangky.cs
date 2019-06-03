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

namespace QLTV
{
    public partial class frm_dangky : Form
    {
        account_BUS acc_bus = new account_BUS();
        public frm_dangky()
        {
            InitializeComponent();
        }

        

        private void frm_dangky_Load(object sender, EventArgs e)
        {

        }

        private void btn_acc_t_Click(object sender, EventArgs e)
        {
            accounts_DTO acc = new accounts_DTO();
            acc.usename = txb_acc_use.Text;
            acc.pass = txb_acc_pass.Text;
            acc.tenhienthi = txb_acc_tht.Text;

            if (txb_acc_repass.Text != acc.pass)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int check = acc_bus.them(acc);
                try
                {
                    if (check == 0)
                    {
                        MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (check == -1)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            txb_acc_pass.Text = "";
            txb_acc_repass.Text = "";
            txb_acc_tht.Text = "";
            txb_acc_use.Text = "";
        }
    }
}
