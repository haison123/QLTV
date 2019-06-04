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
    public class dausach_DAL : connect_DAL
    {

        public DataTable thongke_tacgia(string tg)
        {
            string sql = @" SELECT TacGia,TenDS,MaDS,LinhVuc,NXB,NgayXB FROM dbo.Dau_Sach  WHERE TacGia = N'"+tg+"'";
            return getdata(sql);
        }
        public DataTable thongke_nxb(string nxb)
        {
            string sql = @" SELECT NXB,TenDS,MaDS,LinhVuc,TacGia,NgayXB FROM dbo.Dau_Sach  WHERE NXB = N'" + nxb + "'";
            return getdata(sql);
        }

        public DataTable load_tacgia()
        {
            string sql = @"SELECT TacGia FROM dbo.Dau_Sach GROUP BY TacGia";
            return getdata(sql);
        }
        public DataTable load_nxb()
        {
            string sql = @"SELECT NXB FROM dbo.Dau_Sach GROUP BY NXB";
            return getdata(sql);
        }
        public DataTable loaddausach()
        {
            string sqlstring= @"select * from Dau_Sach";
            return getdata(sqlstring);
        }
        public bool themds(dausach_DTO ds)
        {
            if (getdata("select * from Dau_Sach where MaDS=N'" + ds.mads + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("dbo.insert_dausach N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'", ds.mads, ds.tends, ds.linhvuc, ds.nxb, ds.tg, ds.ngxb);
            Execute(sql);
            return true;
        }
        public bool suads( dausach_DTO ds)
        {
            if (getdata("select * from Dau_Sach where MaDS=N'" + ds.mads + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.update_dausach N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'",ds.mads, ds.tends, ds.linhvuc, ds.nxb, ds.tg, ds.ngxb);
            Execute(sql);
            return true;
        }
        public bool xoads(dausach_DTO ds)
        {
            if (getdata("select * from Dau_Sach where MaDS=N'" + ds.mads + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.delete_dausach N'{0}'" , ds.mads );
            Execute(sql);
            return true;
        }
        public DataTable timkiem_mds (string tk)
        {
            string sql = string.Format("select * from Dau_Sach where MaDS like N'%{0}%'",tk);
            return getdata(sql);
        }
        public DataTable timkiem_tds (string tk)
        {
            string sql = string.Format("select * from Dau_Sach where TenDS like N'%{0}%'", tk);
            return getdata(sql);
        }
    }   
}
