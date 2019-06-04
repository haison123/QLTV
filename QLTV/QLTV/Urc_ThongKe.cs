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


namespace QLTV
{
    public partial class Urc_ThongKe : UserControl
    {
        dausach_BUS ds_bus = new dausach_BUS();
        sach_BUS s_bus = new sach_BUS();
        
        public Urc_ThongKe()
        {
            InitializeComponent();
        }

        private void Urc_ThongKe_Load(object sender, EventArgs e)
        {
            comboBox2.Hide();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Thống kê theo tác giả");
            comboBox1.Items.Add("Thống kê theo nhà xuất bản");
            comboBox1.Items.Add("Top 5 quyển sách được mượn nhiều nhất");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == comboBox1.Items[0])
            {
                comboBox2.Show();
                
                comboBox2.DataSource = ds_bus.get_tacgia();
                comboBox2.DisplayMember = "TacGia";
                comboBox2.ValueMember = "TacGia";
            }
            if (comboBox1.SelectedItem == comboBox1.Items[1])
            {
                comboBox2.Show();

                comboBox2.DataSource = ds_bus.get_NXB();
                comboBox2.DisplayMember = "NXB";
                comboBox2.ValueMember = "NXB";
            }
            if (comboBox1.SelectedItem == comboBox1.Items[2])
            {
                dtgv.DataSource = s_bus.get_top5();
            }

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0])
            {
                dtgv.DataSource= ds_bus.thongke_tacgia(comboBox2.SelectedValue.ToString());
            }
            if (comboBox1.SelectedItem == comboBox1.Items[1])
            {
                dtgv.DataSource = ds_bus.thongke_nxb(comboBox2.SelectedValue.ToString());
            }

        }
    }
}
