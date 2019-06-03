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
    public class account_DAL : connect_DAL
    {
        public bool checkacc(accounts_DTO acc)
        {
            if (getdata("select * from Account where usename = N'" + acc.usename + "' and pass = N'" + acc.pass + "'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool themacc(accounts_DTO acc)
        {
            if (getdata("select * from Account where usename = N'" + acc.usename +"'" ).Rows.Count > 0)
                return false;
            string sql = string.Format("dbo.insert_acc N'{0}',N'{1}',N'{2}'", acc.usename,acc.pass,acc.tenhienthi);
            Execute(sql);
            return true;
        }
        public bool suaacc(accounts_DTO acc)
        {
            if (getdata("select * from Account where usename = N'" + acc.usename + "'" ).Rows.Count == 0)
                return false;
            string sql = string.Format("dbo.update_acc N'{0}',N'{1}'", acc.usename,acc.pass);
            Execute(sql);
            return true;
        }
        public bool xoaacc(accounts_DTO acc)
        {
            if (getdata("select * from Account where usename = N'" + acc.usename + "'").Rows.Count == 0)
                return false;
            string sql = "delete from Account where usename =N'" + acc.usename + "'";
            Execute(sql);
            return true;
        }

    }
}
