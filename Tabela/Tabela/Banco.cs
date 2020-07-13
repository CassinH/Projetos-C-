using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela
{
    public static class Banco
    {
        public static SqlConnection abrir()
        {
            string strcon = @"server=127.0.0.1;user id=Cassio;database=ccsdb";
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            return cn;
        }

    }
  }

