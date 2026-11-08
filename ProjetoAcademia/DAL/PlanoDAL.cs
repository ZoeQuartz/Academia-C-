using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient; //essa é a biblioteca do mySQL

namespace ProjetoAcademia.DAL
{
    internal class PlanoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.plano plano)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = @"INSERT INTO plano (nome, valor, duracao)
                                VALUES(@NOME, @VALOR, @DURACAO)";

            cmd.Parameters.AddWithValue("@NOME", plano.Nome);
            cmd.Parameters.AddWithValue("@VALOR", plano.Valor);
            cmd.Parameters.AddWithValue("@DURACAO", plano.Duracao);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public void Atualizar(BLL.plano plano)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = @"UPDATE plano SET nome = @NOME,
                                                valor = @VALOR,
                                                duracao = @DURACAO
                                                WHERE idPlano = @IDPLANO";

            cmd.Parameters.AddWithValue("IDPLANO", plano.Id_plano);
            cmd.Parameters.AddWithValue("@NOME", plano.Nome);
            cmd.Parameters.AddWithValue("@VALOR", plano.Valor);
            cmd.Parameters.AddWithValue("@DURACAO", plano.Duracao);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public void Excluir(BLL.plano plano)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = @"DELETE FROM plano where idPlano = @IDPLANO";

            cmd.Parameters.AddWithValue("@IDPLANO", plano.Id_plano);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
