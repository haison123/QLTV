using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_BUS;
using QLTV_DTO;
using System.Data;

namespace QLTV
{
    public partial class frm_add_pm : Form
    {
        dausach_BUS ds_bus = new dausach_BUS();
        sach_BUS s_BUS = new sach_BUS();
        phieumuon_BUS pm_bus = new phieumuon_BUS();
        ctpm_BUS ct_bus = new ctpm_BUS();
        docgia_BUS dg_bus = new docgia_BUS();
        thuthu_BUS tt_bus = new thuthu_BUS();
        public frm_add_pm()
        {
            InitializeComponent();
        }

        private void frm_add_pm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ds_bus.getlist();
            comboBox1.DisplayMember = "TenDS";
            comboBox1.ValueMember = "TenDS";

            cbb_dg.DataSource = dg_bus.getlist();
            cbb_dg.DisplayMember = "TenDg";
            cbb_dg.ValueMember = "MaDg";

            cbb_tt.DataSource = tt_bus.getlist();
            cbb_tt.DisplayMember = "TenTT";
            cbb_tt.ValueMember = "MaTT";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pm_insert_Click(object sender, EventArgs e)
        {
            phieumuon_DTO pm = new phieumuon_DTO();
            pm.mapm = txb_pm_mpm.Text;
            pm.matt = cbb_tt.SelectedValue.ToString();
            pm.ngaymuon = txb_pm_nm.Text;
            pm.madg = cbb_dg.SelectedValue.ToString();

            int check = pm_bus.them(pm, pm.matt, pm.madg);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Mã phiếu mượn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -2)
                {
                    MessageBox.Show("Mã thủ thư không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -3)
                {
                    MessageBox.Show("Mã độc giả không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == 1)
                {
                    ctpm_DTO ct = new ctpm_DTO();
                    for ( int i=0; i< listBox2.Items.Count; i++)
                    {
                        ct.mapm = txb_pm_mpm.Text;
                        ct.mas = listBox2.Items[i].ToString();
                        ct_bus.themctpm(ct);
                        s_BUS.sua_trangthai(listBox2.Items[i].ToString());

                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txb_pm_mpm.Text = "";
            txb_pm_nm.Text = "";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           for ( int i = 0; i < s_BUS.getlist_DS(comboBox1.SelectedValue.ToString()).Rows.Count ; i++)
            {
                listBox1.Items.Add(s_BUS.getlist_DS(comboBox1.SelectedValue.ToString()).Rows[i][0].ToString());
            }
           for ( int i = 0; i< listBox1.Items.Count; i++)
            {
                for ( int j = 0; j< listBox2.Items.Count; j++)
                {
                    if (listBox1.Items[i].ToString() == listBox2.Items[j].ToString())
                        listBox1.Items.Remove(listBox1.Items[i]);
                }
            }

        }

        private void btn_pm_ch_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_pm_re_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txb_pm_nm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_pm_mdg_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
