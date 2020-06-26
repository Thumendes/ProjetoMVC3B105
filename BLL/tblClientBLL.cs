using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ProjetoMVC3B105.DAL;

namespace ProjetoMVC3B105.BLL
{
    public class tblClientBLL
    {
        private ConnectionDAL database = new ConnectionDAL();

        public Boolean Auth(string email, string senha)
        {
            string consult = string.Format($@"select * from tbl_clienteB05 where email = '{email}' and senha = '{senha}'");
            DataTable dt = database.executeConsult(consult);
            if(dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}