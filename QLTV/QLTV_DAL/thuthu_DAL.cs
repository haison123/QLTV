using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;
using System.Data;

namespace QLTV_DAL
{
    //Thực hiện truy vấn tới data base
    public class thuthu_DAL:connect_DAL
    {
        public DataTable loadthuthu()
        {
            string sqlstring = @"select * from Thu_Thu";
            return getdata(sqlstring);
        }
        public bool themtt(thuthu_DTO tt)
        {
            if (getdata("select * from Thu_Thu where MaTT=N'" + tt.matt + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("dbo.insert_thuthu N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", tt.matt,tt.tentt,tt.diachi,tt.gt,tt.sdt);
            Execute(sql);
            return true;
        }
        public bool suatt(thuthu_DTO tt)
        {
            if (getdata("select * from Thu_Thu where MaTT=N'" + tt.matt + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.update_thuthu N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'", tt.matt, tt.tentt, tt.diachi, tt.gt, tt.sdt);
            Execute(sql);
            return true;
        }
        public bool xoatt(thuthu_DTO tt)
        {
            if (getdata("select * from Thu_Thu where MaTT=N'" + tt.matt + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.delete_thuthu N'{0}'", tt.matt);
            Execute(sql);
            return true;
        }
        public DataTable timkiem_mtt(string tk)
        {
            string sql = string.Format("select * from Thu_Thu where MaTT like N'%{0}%'", tk);
            return getdata(sql);
        }
        public DataTable timkiem_ttt(string tk)
        {
            string sql = string.Format("select * from Thu_Thu where TenTT like N'%{0}%'", tk);
            return getdata(sql);
        }
    }
}
