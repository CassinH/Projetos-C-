using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaConexBDS
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public Cadastro(String Nome,String CPF)
        {
            //Comanda Sql ---SqlCommand
            cmd.CommandText = "insert into usuario(Nome,CPF) values(@Nome,@CPF)";

            //Parametros
            cmd.Parameters.AddWithValue("@Nome",Nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);


            try
            // conectar banco--Conexao
            {
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException ) 
            {
                this.mensagem = "Erro ao se Conectar com o Banco de Dados";
            }


        }
    }
}
