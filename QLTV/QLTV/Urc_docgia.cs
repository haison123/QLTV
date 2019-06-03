using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLTV_BUS;
using QLTV_DTO;

namespace QLTV
{
    public partial class Urc_docgia : UserControl
    {
        docgia_BUS dg_bus = new docgia_BUS();
        public Urc_docgia()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dg_t_Click(object sender, EventArgs e)
        {
            docgia_DTO dg = new docgia_DTO();
            dg.madg = txb_dg_mdg.Text;
            dg.tendg = txb_dg_tdg.Text;
            dg.gt = txb_dg_gt.Text;
            dg.diachi = txb_dg_dc.Text;
            dg.sdt = txb_dg_sdt.Text;

            int check = dg_bus.them(dg);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã độc giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_docgia_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_dg_mdg.Text = "";
            txb_dg_tdg.Text = "";
            txb_dg_gt.Text= "";
            txb_dg_dc.Text = "";
            txb_dg_sdt.Text = "";
        }

        private void Urc_docgia_Load(object sender, EventArgs e)
        {
           dtgw_dg.DataSource = dg_bus.getlist();
        }

        private void btn_dg_s_Click(object sender, EventArgs e)
        {
            docgia_DTO dg = new docgia_DTO();
            dg.madg = txb_dg_mdg.Text;
            dg.tendg = txb_dg_tdg.Text;
            dg.gt = txb_dg_gt.Text;
            dg.diachi = txb_dg_dc.Text;
            dg.sdt = txb_dg_sdt.Text;

            int check = dg_bus.sua(dg);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã độc giả không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_docgia_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_dg_mdg.Text = "";
            txb_dg_tdg.Text = "";
            txb_dg_gt.Text = "";
            txb_dg_dc.Text = "";
            txb_dg_sdt.Text = "";
        }

        private void btn_dg_x_Click(object sender, EventArgs e)
        {
            docgia_DTO dg =new docgia_DTO();
            dg.madg = txb_dg_mdg.Text;
            int check = dg_bus.xoa(dg);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập mã độc giả muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã độc giả không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_docgia_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_dg_mdg.Text = "";
        }

        private void btn_dg_tkm_Click(object sender, EventArgs e)
        {
            string tk = txb_dg_tk.Text;

            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_dg.DataSource = dg_bus.timkiem_ma(tk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_dg_tk.Text = "";
        }

        private void btn_dg_tkt_Click(object sender, EventArgs e)
        {
            string tk = txb_dg_tk.Text;
            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_dg.DataSource = dg_bus.timkiem_ten(tk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_dg_tk.Text = "";
        }
    }
}
