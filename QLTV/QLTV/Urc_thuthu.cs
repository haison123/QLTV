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
    public partial class Urc_thuthu : UserControl
    {
        thuthu_BUS tt_bus = new thuthu_BUS();
        public Urc_thuthu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_tt_t_Click(object sender, EventArgs e)
        {
            thuthu_DTO tt = new thuthu_DTO();
            tt.matt = txb_tt_mtt.Text;
            tt.tentt = txb_tt_ttt.Text;
            tt.diachi = txb_tt_dc.Text;
            tt.gt = txb_tt_gt.Text;
            tt.sdt = txb_tt_sdt.Text;

            int check = tt_bus.them(tt);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã thủ thư đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_thuthu_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_tt_mtt.Text = "";
            txb_tt_ttt.Text = "";
            txb_tt_dc.Text = "";
            txb_tt_gt.Text = "";
            txb_tt_sdt.Text = "";

        }

        private void Urc_thuthu_Load(object sender, EventArgs e)
        {
            dtgw_tt.DataSource = tt_bus.getlist();

        }

        private void btn_tt_s_Click(object sender, EventArgs e)
        {
            thuthu_DTO tt = new thuthu_DTO();
            tt.matt = txb_tt_mtt.Text;
            tt.tentt = txb_tt_ttt.Text;
            tt.diachi = txb_tt_dc.Text;
            tt.gt = txb_tt_gt.Text;
            tt.sdt = txb_tt_sdt.Text;

            int check = tt_bus.sua(tt);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã thủ thư không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_thuthu_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_tt_mtt.Text = "";
            txb_tt_ttt.Text = "";
            txb_tt_dc.Text = "";
            txb_tt_gt.Text = "";
            txb_tt_sdt.Text = "";
        }

        private void btn_tt_x_Click(object sender, EventArgs e)
        {
            thuthu_DTO tt = new thuthu_DTO();
            tt.matt = txb_tt_mtt.Text;
            tt.tentt = txb_tt_ttt.Text;
            tt.diachi = txb_tt_dc.Text;
            tt.gt = txb_tt_gt.Text;
            tt.sdt = txb_tt_sdt.Text;

            int check = tt_bus.xoa(tt);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập mã thủ thư muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã thủ thư không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_thuthu_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_tt_mtt.Text = "";
        }

        private void btn_tt_tkm_Click(object sender, EventArgs e)
        {
            string tk = txb_tt_tk.Text;

            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_tt.DataSource = tt_bus.timkiem_ma(tk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_tt_tk.Text = "";
        }

        private void btn_tt_tkt_Click(object sender, EventArgs e)
        {
            string tk = txb_tt_tk.Text;
            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_tt.DataSource = tt_bus.timkiem_ten(tk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_tt_tk.Text = "";
        }
    }
}