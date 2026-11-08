using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient; //essa é a biblioteca do mySQL

namespace ProjetoAcademia.DAL
{
    internal class Conexao
    {
        MySqlConnection conexao = new MySqlConnection(@"server=localhost; database=BDAcademia; uid=root; pwd=''"); //o @uso para pular linha //parte usada para conectar no banco

        public MySqlConnection Conectar()
        {
            if(conexao.State != ConnectionState.Open)
            {
                conexao.Open();
            }
            return conexao;
        }
        //metodos do tipo void usado para desconexoes quando nao vai retornar nada
        public void Desconectar()
        {
            if(conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
