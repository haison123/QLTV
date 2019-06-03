using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV_BUS;
using QLTV_DTO;
using System.Data.SqlTypes;


namespace QLTV
{
    public partial class Urc_dausach : UserControl
    {
        dausach_BUS ds_bus = new dausach_BUS();
        public Urc_dausach()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtgw_ds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_ds2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Urc_dausach_Load(object sender, EventArgs e)
        {
            dtgw_ds.DataSource = ds_bus.getlist();

        }

        private void btn_ds_t_Click(object sender, EventArgs e)
        {
            dausach_DTO ds = new dausach_DTO();
            ds.mads = txb_ds_mds.Text;
            ds.tends = txb_ds_tds.Text;
            ds.linhvuc = txb_ds_lv.Text;
            ds.nxb = txb_ds_nxb.Text;
            ds.tg = txb_ds_tg.Text;
            ds.ngxb = txb_ds_ngxb.Text ;
            int check = ds_bus.them(ds);
           try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã đầu sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_dausach_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_ds_mds.Text = "";
            txb_ds_tds.Text = "";
            txb_ds_lv.Text = "";
            txb_ds_tg.Text = "";
            txb_ds_nxb.Text = "";
            txb_ds_ngxb.Text = "";
        }

        private void btn_ds_x_Click(object sender, EventArgs e)
        {
            dausach_DTO ds = new dausach_DTO();
            ds.mads = txb_ds_mds.Text;
            int check = ds_bus.xoa(ds);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập mã đầu sách muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã đầu sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_dausach_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ds_s_Click(object sender, EventArgs e)
        {
            dausach_DTO ds = new dausach_DTO();
            ds.mads = txb_ds_mds.Text;
            ds.tends = txb_ds_tds.Text;
            ds.linhvuc = txb_ds_lv.Text;
            ds.nxb = txb_ds_nxb.Text;
            ds.tg = txb_ds_tg.Text;
            ds.ngxb = txb_ds_ngxb.Text;
            int check = ds_bus.sua(ds);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã đầu sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    Urc_dausach_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_ds_mds.Text = "";
            txb_ds_tds.Text = "";
            txb_ds_lv.Text = "";
            txb_ds_tg.Text = "";
            txb_ds_nxb.Text = "";
            txb_ds_ngxb.Text = "";
        }

        private void btn_ds_tkm_Click(object sender, EventArgs e)
        {
            string tk = txb_ds_tk.Text;
        
            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_ds.DataSource = ds_bus.timkiem_ma(tk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_ds_tk.Text = "";
        }

        private void btn_ds_tkt_Click(object sender, EventArgs e)
        {
            string tk = txb_ds_tk.Text;
            try
            {
                if (string.IsNullOrEmpty(tk))
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtgw_ds.DataSource = ds_bus.timkiem_ten(tk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_ds_tk.Text = "";
        }
    }
}
