using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaConexBDS
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Construtor
        public Conexao()
        {
            con.ConnectionString = "server=127.0.0.1;user id=Cassio;persistsecurityinfo=True;database=cadastro ";
        }
        //Metodo Conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
