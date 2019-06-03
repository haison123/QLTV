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
    public class thuthu_BUS
    {
        thuthu_DAL tt_dal = new thuthu_DAL();
        public DataTable getlist()
        {
            return tt_dal.loadthuthu();
        }
        public int them(thuthu_DTO tt)
        {
            if (string.IsNullOrEmpty(tt.matt) || string.IsNullOrEmpty(tt.tentt) || string.IsNullOrEmpty(tt.diachi) || string.IsNullOrEmpty(tt.gt) || string.IsNullOrEmpty(tt.sdt))
                return 0;
            if (tt_dal.themtt(tt) == false)
                return -1;
            return 1;
        }
        public int sua(thuthu_DTO tt)
        {
            if (string.IsNullOrEmpty(tt.matt) || string.IsNullOrEmpty(tt.tentt) || string.IsNullOrEmpty(tt.diachi) || string.IsNullOrEmpty(tt.gt) || string.IsNullOrEmpty(tt.sdt))
                return 0;
            if (tt_dal.suatt(tt) == false)
                return -1;
            return 1;
        }
        public int xoa(thuthu_DTO tt)
        {
            if (string.IsNullOrEmpty(tt.matt))
                return 0;
            if (tt_dal.xoatt(tt) == false)
                return -1;
            return 1;
        }
        public DataTable timkiem_ma(string tk)
        {
            return tt_dal.timkiem_mtt(tk);
        }
        public DataTable timkiem_ten(string tk)
        {
            return tt_dal.timkiem_ttt(tk);
        }
    }
}
