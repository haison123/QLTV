using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV_DTO;

namespace QLTV_DAL
{
    public class docgia_DAL: connect_DAL
    {
        public DataTable loaddocgia()
        {
            string sqlstring = @"select * from Doc_gia";
            return getdata(sqlstring);
        }
        public bool themdg(docgia_DTO dg)
        {
            if (getdata("select * from Doc_gia where MaDg=N'" + dg.madg + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("dbo.insert_docgia N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", dg.madg,dg.tendg,dg.gt,dg.diachi,dg.sdt);
            Execute(sql);
            return true;
        }
        public bool suadg(docgia_DTO dg)
        {
            if (getdata("select * from Doc_gia where MaDg=N'" + dg.madg + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.update_docgia N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'", dg.madg,dg.tendg,dg.gt,dg.diachi,dg.sdt);
            Execute(sql);
            return true;
        }
        public bool xoadg(docgia_DTO dg)
        {
            if (getdata("select * from Doc_gia where MaDg=N'" + dg.madg + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.delete_docgia N'{0}'", dg.madg);
            Execute(sql);
            return true;
        }
        public DataTable timkiem_mdg(string tk)
        {
            string sql = string.Format("select * from Doc_gia where MaDg like N'%{0}%'", tk);
            return getdata(sql);
        }
        public DataTable timkiem_tdg(string tk)
        {
            string sql = string.Format("select * from Doc_gia where TenDg like N'%{0}%'", tk);
            return getdata(sql);
        }
    }
}
