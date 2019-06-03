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
    public partial class Urc_phieumuon : UserControl
    {
        phieumuon_BUS pm_bus = new phieumuon_BUS();
        public Urc_phieumuon()
        {
            InitializeComponent();
        }

        private void Urc_phieumuon_Load(object sender, EventArgs e)
        {
            dtgw_pm.DataSource = pm_bus.getlist();
        }

        private void btn_pm_t_Click(object sender, EventArgs e)
        {
            frm_add_pm f = new frm_add_pm();
            f.ShowDialog();
        }

        private void btn_pm_s_Click(object sender, EventArgs e)
        {
            frm_update_pm frm = new frm_update_pm();
            frm.ShowDialog();
        }

        private void btn_pm_x_Click(object sender, EventArgs e)
        {
            frm_show_ctpm frm = new frm_show_ctpm();
            frm.ShowDialog();
        }
    }
}
