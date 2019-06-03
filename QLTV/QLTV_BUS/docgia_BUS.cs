using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class docgia_BUS
    {
        docgia_DAL dg_dal = new docgia_DAL();
        public DataTable getlist()
        {
            return dg_dal.loaddocgia();
        }
        public int them(docgia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.madg) || string.IsNullOrEmpty(dg.tendg) || string.IsNullOrEmpty(dg.gt) || string.IsNullOrEmpty(dg.diachi) || string.IsNullOrEmpty(dg.sdt) )
                return 0;
            if (dg_dal.themdg(dg) == false)
                return -1;
            return 1;
        }
        public int sua(docgia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.madg) || string.IsNullOrEmpty(dg.tendg) || string.IsNullOrEmpty(dg.gt) || string.IsNullOrEmpty(dg.diachi) || string.IsNullOrEmpty(dg.sdt))
                return 0;
            if (dg_dal.suadg(dg) == false)
                return -1;
            return 1;
        }
        public int xoa(docgia_DTO dg)
        {
            if (string.IsNullOrEmpty(dg.madg))
                return 0;
            if (dg_dal.xoadg(dg) == false)
                return -1;
            return 1;
        }
        public DataTable timkiem_ma(string tk)
        {
            return dg_dal.timkiem_mdg(tk);
        }
        public DataTable timkiem_ten(string tk)
        {
            return dg_dal.timkiem_tdg(tk);
        }
    }
}
