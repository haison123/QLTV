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
    public class ctpm_DAL:connect_DAL
    {
        
        public DataTable loadctpm(string ct)
        {
            string sqlstring = @"select * from CTPM where MaPM = N'"+ct+"'";
            return getdata(sqlstring);
        }
        
        public void themctpm(ctpm_DTO ct)
        {
            string sql = string.Format("dbo.insert_ctpm N'{0}',N'{1}'", ct.mapm,ct.mas);
            Execute(sql);
        }
    }
}
