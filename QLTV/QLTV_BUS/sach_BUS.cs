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
    public class sach_BUS
    {
        sach_DAL s_dal = new sach_DAL();

        public DataTable get_top5()
        {
            return s_dal.load_top5();
        }
        public DataTable getlist_PM(string pm)
        {
            return s_dal.loadsachtheoPM(pm);
        }
        public DataTable getlist_DS(string ds)
        {
            return s_dal.loadsachtheods(ds);
        }
        public DataTable getlist()
        {
            return s_dal.loadsach();
        }
        public int them(sach_DTO s)
        {
            if (string.IsNullOrEmpty(s.mads) || string.IsNullOrEmpty(s.mas) || string.IsNullOrEmpty(s.tinhtrang) )
                return 0;
            if (s_dal.checkDS(s) == false)
                return 2;
            if (s_dal.themsach(s) == false)
                return -1;
            return 1;
        }
        public int sua(sach_DTO s)
        {
            if (string.IsNullOrEmpty(s.mads) || string.IsNullOrEmpty(s.mas) || string.IsNullOrEmpty(s.tinhtrang))
                return 0;
            if (s_dal.checkDS(s) == false)
                return 2;
            if (s_dal.suasach(s) == false)
                return -1;
            return 1;
        }
        public int xoa(sach_DTO s)
        {
            if (string.IsNullOrEmpty(s.mas))
                return 0;
            if (s_dal.xoasach(s) == false)
                return -1;
            return 1;
        }
        public DataTable timkiem_ma(string tk)
        {
            return s_dal.timkiem_ms(tk);
        }
        public DataTable timkiem_ten(string tk)
        {
            return s_dal.timkiem_tds(tk);
        }
        public void sua_trangthai(string tk)
        {
            s_dal.suasach_trangthai(tk);
        }
        public void sua_trangthai2(string tk)
        {
            s_dal.suasach_trangthai2(tk);
        }
    }
}
