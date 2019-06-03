using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class phieumuon_BUS
    {
        phieumuon_DAL pm_dal = new phieumuon_DAL();
        public DataTable getlist_mpm(string pm)
        {
            return pm_dal.loadpm_mapm(pm);
        }
        public DataTable getlist()
        {
            return pm_dal.loadpm();
        }
        public int them(phieumuon_DTO pm,string mtt,string mdg)
        {
            
            if (string.IsNullOrEmpty(pm.mapm) || string.IsNullOrEmpty(pm.matt) || string.IsNullOrEmpty(pm.ngaymuon) || string.IsNullOrEmpty(pm.madg))
                return 0;
            if (pm_dal.thempm(pm,mtt,mdg) == -1)
                return -1;
            if (pm_dal.thempm(pm, mtt, mdg) == -2)
                return -2;
            if (pm_dal.thempm(pm, mtt, mdg) == -3)
                return -3;
            return 1;
        }
        public void xoa(phieumuon_DTO pm)
        {
            pm_dal.xoapm(pm);
        }
    }
}
