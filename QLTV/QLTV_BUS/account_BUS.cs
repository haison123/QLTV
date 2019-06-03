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
    public class account_BUS
    {
        account_DAL acc_dal = new account_DAL();
        public int login(accounts_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.usename) || string.IsNullOrEmpty(acc.pass))
                return 0;
            if (acc_dal.checkacc(acc) == false)
                return -1;
            return 1;
        }
        public int them(accounts_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.usename) || string.IsNullOrEmpty(acc.pass) || string.IsNullOrEmpty(acc.tenhienthi))
                return 0;
            if (acc_dal.themacc(acc) == false)
                return -1;

            return 1;
        }
        public int sua(accounts_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.usename) || string.IsNullOrEmpty(acc.pass))
                return 0;
            if (acc_dal.suaacc(acc) == false)
                return -1;

            return 1;
        }
        public int xoa(accounts_DTO acc)
        {
            if (string.IsNullOrEmpty(acc.usename) || string.IsNullOrEmpty(acc.pass))
                return 0;
            if (acc_dal.xoaacc(acc) == false)
                return -1;

            return 1;
        }
    }
}
