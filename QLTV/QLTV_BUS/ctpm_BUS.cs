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
    public class ctpm_BUS
    {
        ctpm_DAL ct_dal = new ctpm_DAL();

        public DataTable getlist_CTPM(string ct)
        {
            return ct_dal.loadctpm(ct);
        }
        public void themctpm(ctpm_DTO ct)
        {
            ct_dal.themctpm(ct);
        }
    }
}
