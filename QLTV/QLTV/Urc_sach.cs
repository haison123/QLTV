using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_BUS;
using QLTV_DTO;

namespace QLTV
{
    public partial class Urc_sach : UserControl
    {
        sach_BUS s_bus = new sach_BUS();
        public Urc_sach()
        {
            InitializeComponent();
        }

        private void Urc_sach_Load(object sender, EventArgs e)
        {
            dtgw_s.DataSource = s_bus.getlist();
        }

        private void btn_s_t_Click(object sender, EventArgs e)
        {
            sach_DTO s = new sach_DTO();
            s.mads = txb_s_mds.Text;
            s.mas = txb_s_ms.Text;
            s.tinhtrang = txb_s_tt.Text;
            int check = s_bus.them(s);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check==2)
                {
                    MessageBox.Show("Mã đầu sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_sach_Load(sender,e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_s_mds.Text = "";
            txb_s_ms.Text = "";
            txb_s_tt.Text = "";
        }

        private void btn_s_s_Click(object sender, EventArgs e)
        {
            sach_DTO s = new sach_DTO();
            s.mads = txb_s_mds.Text;
            s.mas = txb_s_ms.Text;
            s.tinhtrang = txb_s_tt.Text;
            int check = s_bus.them(s);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 2)
                {
                    MessageBox.Show("Mã đầu sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_sach_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_s_mds.Text = "";
            txb_s_ms.Text = "";
            txb_s_tt.Text = "";
        }

        private void btn_s_x_Click(object sender, EventArgs e)
        {
            sach_DTO s = new sach_DTO();
            s.mas = txb_s_ms.Text;
            int check = s_bus.xoa(s);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập mã sách muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_sach_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_s_tkm_Click(object sender, EventArgs e)
        {
            string tk = txb_s_tk.Text;

            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_s.DataSource = s_bus.timkiem_ma(tk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_s_tk.Text = "";
        }

        private void btn_s_tkt_Click(object sender, EventArgs e)
        {
            string tk = txb_s_tk.Text;
            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_s.DataSource = s_bus.timkiem_ten(tk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_s_tk.Text = "";
        }
    }
}
