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
    public partial class frm_show_ctpm : Form
    {
        ctpm_BUS ct_bus = new ctpm_BUS();
        phieumuon_BUS pm_bus = new phieumuon_BUS();
        sach_BUS s_bus = new sach_BUS();
        public frm_show_ctpm()
        {
            InitializeComponent();
        }

        private void frm_show_ctpm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = pm_bus.getlist();
            comboBox1.DisplayMember = "MaPM";
            comboBox1.ValueMember = "MaPM";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtgv_ctpm_show.DataSource = s_bus.getlist_PM(comboBox1.SelectedValue.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
