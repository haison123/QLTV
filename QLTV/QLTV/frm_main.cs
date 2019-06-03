using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_ds_s_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_ql_ds_Click(object sender, EventArgs e)
        {
            pal_main.Controls.Clear();
            pal_main.Controls.Add(new Urc_dausach());
        }

        private void btn_ql_s_Click(object sender, EventArgs e)
        {
            pal_main.Controls.Clear();
            pal_main.Controls.Add(new Urc_sach());
        }

        private void btn_ql_dg_Click(object sender, EventArgs e)
        {
            pal_main.Controls.Clear();
            pal_main.Controls.Add(new Urc_docgia());
        }

        private void btn_ql_pm_Click(object sender, EventArgs e)
        {
            pal_main.Controls.Clear();
            pal_main.Controls.Add(new Urc_phieumuon());
        }

        private void ribbonBar22_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
        }

        private void btn_tk_dk_Click(object sender, EventArgs e)
        {
            frm_dangky frm = new frm_dangky();
            frm.ShowDialog();
        }

        private void btn_ds_t_Click(object sender, EventArgs e)
        {
            frm_acc_suatk frm = new frm_acc_suatk();
            frm.ShowDialog();
        }

        private void btn_tk_x_Click(object sender, EventArgs e)
        {
            frm_acc_xoatk frm = new frm_acc_xoatk();
            frm.ShowDialog();
        }

        private void btn_ql_tt_Click(object sender, EventArgs e)
        {
            pal_main.Controls.Clear();
            pal_main.Controls.Add(new Urc_thuthu());
        }
    }
}
