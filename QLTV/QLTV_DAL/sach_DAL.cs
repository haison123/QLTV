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
    public class sach_DAL: connect_DAL
    {
        public DataTable load_top5()
        {
            string sqlstring = @"SELECT TOP 5 WITH TIES ds.TenDS,s.MaSach,ds.TacGia,ds.LinhVuc,ds.NXB,ds.NgayXB,s.SoLuotMuon FROM dbo.Sach s,dbo.Dau_Sach ds WHERE s.MaDS = ds.MaDS ORDER BY s.SoLuotMuon DESC";
            return getdata(sqlstring);

        }
        public DataTable loadsachtheoPM(string pm)
        {
            string sqlstring = @"SELECT s.MaDS , ds.TenDS , s.MaSach , s.TinhTrang , s.TrangThai FROM dbo.CTPM ct,dbo.Sach s, dbo.Dau_Sach ds , dbo.Phieu_Muon pm WHERE ct.MaPM = pm.MaPM AND ct.MaSach = s.MaSach AND s.MaDS =ds.MaDS AND pm.MaPM = N'" + pm + "'";
            return getdata(sqlstring);

        }
        public DataTable loadsachtheods(string ds)
        {
            string sql = @"SELECT s.MaSach FROM Sach s , Dau_Sach ds where s.MaDS = ds.MaDS and TrangThai = N'Chưa mượn' and ds.TenDS =N'"+ds+"'";
            return getdata(sql);
        }
        public DataTable loadsach()
        {
            string sqlstring = @"SELECT s.MaDS , ds.TenDS , s.MaSach , s.TinhTrang , s.TrangThai FROM dbo.Sach s, dbo.Dau_Sach ds WHERE s.MaDS = ds.MaDS";
            return getdata(sqlstring);
        }
        public bool themsach(sach_DTO s)
        {
            if (getdata("select * from Sach where MaSach=N'" + s.mas + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("dbo.insert_sach N'{0}',N'{1}',N'{2}'", s.mas,s.mads,s.tinhtrang);
            Execute(sql);
            return true;
        }
        public bool suasach(sach_DTO s)
        {
            if (getdata("select * from Sach where MaSach=N'" + s.mas + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.update_sach N'{0}',N'{1}',N'{2}'", s.mas, s.mads, s.tinhtrang);
            Execute(sql);
            return true;
        }
        public bool xoasach(sach_DTO s)
        {
            if (getdata("select * from Sach where MaSach=N'" + s.mas + "'").Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.delete_sach N'{0}'", s.mas);
            Execute(sql);
            return true;
        }
        public DataTable timkiem_ms(string tk)
        {
            string sql = string.Format("SELECT s.MaDS , ds.TenDS , s.MaSach , s.TinhTrang , s.TrangThai FROM dbo.Sach s, dbo.Dau_Sach ds WHERE s.MaDS = ds.MaDS and s.MaSach like N'%{0}%'", tk);
            return getdata(sql);
        }
        public DataTable timkiem_tds(string tk)
        {
            string sql = string.Format("SELECT s.MaDS , ds.TenDS , s.MaSach , s.TinhTrang , s.TrangThai FROM dbo.Sach s, dbo.Dau_Sach ds WHERE s.MaDS = ds.MaDS and ds.TenDS like N'%{0}%'", tk);
            return getdata(sql);
        }
        public bool checkDS(sach_DTO s)
        {
            string sql = "select * from Dau_Sach where MaDS = '" + s.mads +"'";
            if(getdata(sql).Rows.Count==0)
            return false;
            return true;
        }
        public void suasach_trangthai(string s)
        {
            string sql = string.Format("dbo.update_sach_trangthai N'{0}'", s);
            Execute(sql);
        }
        public void suasach_trangthai2(string s)
        {
            string sql = string.Format("dbo.update_sach_trangthai2 N'{0}'", s);
            Execute(sql);
        }
    }
}
