using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLTV_DTO;

namespace QLTV_DAL
{
    public class phieumuon_DAL : connect_DAL
    {
        public DataTable loadpm_mapm(string pm)
        {
            string sqlstring = @"SELECT * from Phieu_Muon where MaPM =N'"+pm+"'";
            return getdata(sqlstring);
        }
        public DataTable loadpm()
        {
            string sqlstring = @"SELECT * from Phieu_Muon";
            return getdata(sqlstring);
        }
        public int thempm(phieumuon_DTO pm,string mtt,string mdg)
        {
            if (getdata("select * from Phieu_Muon where MaPM=N'" + pm.mapm + "'").Rows.Count > 0)
                return -1;
            if (getdata("select * from Thu_thu where MaTT =N'" + mtt + "'").Rows.Count == 0)
                return -2;
            if (getdata("select * from Doc_Gia where MaDG =N'" + mdg + "'").Rows.Count == 0)
                return -3;
            string sql = string.Format("dbo.insert_phieumuon N'{0}',N'{1}',N'{2}',N'{3}'", pm.mapm,pm.matt,pm.madg,pm.ngaymuon);
            Execute(sql);
            return 1;
        }
        public void xoapm(phieumuon_DTO pm)
        {
            string sql = string.Format("dbo.delete_phieumuon N'{0}'", pm.mapm);
            Execute(sql);
        }
    }
}
