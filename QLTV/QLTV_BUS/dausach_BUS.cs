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
    public class dausach_BUS
    {
        dausach_DAL ds_dal = new dausach_DAL();
        public DataTable thongke_tacgia(string tg)
        {
            return ds_dal.thongke_tacgia(tg);
        }
        public DataTable thongke_nxb(string nxb)
        {
            return ds_dal.thongke_nxb(nxb);
        }
        public DataTable get_tacgia()
        {
            return ds_dal.load_tacgia();
        }
        public DataTable get_NXB()
        {
            return ds_dal.load_nxb();
        }
        public DataTable getlist()
        {
            return ds_dal.loaddausach();
        }
        public int them(dausach_DTO ds)
        {
            if (string.IsNullOrEmpty(ds.mads) || string.IsNullOrEmpty(ds.tends)||string.IsNullOrEmpty(ds.linhvuc)||string.IsNullOrEmpty(ds.nxb)||string.IsNullOrEmpty(ds.tg)||string.IsNullOrEmpty(ds.ngxb))
                return 0;
            if (ds_dal.themds(ds)==false)
                return -1;
            return 1;
        }
        public int sua(dausach_DTO ds)
        {
            if (string.IsNullOrEmpty(ds.mads) || string.IsNullOrEmpty(ds.tends) || string.IsNullOrEmpty(ds.linhvuc) || string.IsNullOrEmpty(ds.nxb) || string.IsNullOrEmpty(ds.tg) || string.IsNullOrEmpty(ds.ngxb))
                return 0;
            if (ds_dal.suads(ds) == false)
                return -1;
            return 1;
        }
        public int xoa(dausach_DTO ds)
        {
            if (string.IsNullOrEmpty(ds.mads))
                return 0;
            if (ds_dal.xoads(ds) == false)
                return -1;
            return 1;
        }
        public DataTable timkiem_ma(string tk)
        {
            return ds_dal.timkiem_mds(tk);
        }
        public DataTable timkiem_ten(string tk)
        {
            return ds_dal.timkiem_tds(tk);
        }
    }
}
