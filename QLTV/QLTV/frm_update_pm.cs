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
    public partial class frm_update_pm : Form
    {
        dausach_BUS ds_bus = new dausach_BUS();
        sach_BUS s_BUS = new sach_BUS();
        phieumuon_BUS pm_bus = new phieumuon_BUS();
        ctpm_BUS ct_bus = new ctpm_BUS();
        thuthu_BUS tt_bus = new thuthu_BUS();
        docgia_BUS dg_bus = new docgia_BUS();
        string[] sach = new string[100];
        public frm_update_pm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb_pm_mpm_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btn_pm_load_Click(object sender, EventArgs e)
        {
            if( pm_bus.getlist_mpm(cbb_pm.SelectedValue.ToString()).Rows.Count==0)
                MessageBox.Show("Mã phiếu mượn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < ct_bus.getlist_CTPM(cbb_pm.SelectedValue.ToString()).Rows.Count; i++)
                {
                    listBox2.Items.Add(ct_bus.getlist_CTPM(cbb_pm.SelectedValue.ToString()).Rows[i][1].ToString());
                    sach[0]= ct_bus.getlist_CTPM(cbb_pm.SelectedValue.ToString()).Rows[i][1].ToString();
                }
            }
            
        }

        private void frm_update_pm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập mã phiếu mượn cần sửa hoặc trả rồi ấn chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            comboBox1.DataSource = ds_bus.getlist();
            comboBox1.DisplayMember = "TenDS";
            comboBox1.ValueMember = "TenDS";

            cbb_dg.DataSource = dg_bus.getlist();
            cbb_dg.DisplayMember = "TenDg";
            cbb_dg.ValueMember = "MaDg";

            cbb_tt.DataSource = tt_bus.getlist();
            cbb_tt.DisplayMember = "TenTT";
            cbb_tt.ValueMember = "MaTT";

            cbb_pm.DataSource = pm_bus.getlist();
            cbb_pm.DisplayMember = "MaPM";
            cbb_pm.ValueMember = "MaPM";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < s_BUS.getlist_DS(comboBox1.SelectedValue.ToString()).Rows.Count; i++)
            {
                listBox1.Items.Add(s_BUS.getlist_DS(comboBox1.SelectedValue.ToString()).Rows[i][0].ToString());
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
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

        private void btn_pm_update_Click(object sender, EventArgs e)
        {
            phieumuon_DTO pm = new phieumuon_DTO();
            pm.mapm = cbb_pm.SelectedValue.ToString();
            for (int i = 0; i < sach.Length ; i++)
            {
                s_BUS.sua_trangthai2(sach[i]);
            }
            pm_bus.xoa(pm);

            pm.ngaymuon = txb_pm_nm.Text;

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
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        ct.mapm = cbb_pm.SelectedValue.ToString();
                        ct.mas = listBox2.Items[i].ToString();
                        ct_bus.themctpm(ct);
                        s_BUS.sua_trangthai(listBox2.Items[i].ToString());

                    }
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            txb_pm_nm.Text = "";
        }

        private void btn_pm_tra_Click(object sender, EventArgs e)
        {
            phieumuon_DTO pm = new phieumuon_DTO();
            pm.mapm = cbb_pm.SelectedValue.ToString();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                s_BUS.sua_trangthai2(listBox2.Items[i].ToString());
            }
           
            pm_bus.xoa(pm);
            MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        
    }
    
}
