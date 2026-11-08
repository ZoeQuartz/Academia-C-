using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    internal class plano
    {
        //Uso o private pra definir 
        private int id_plano;
        private string nome;
        private double valor;
        private string duracao;

        public int Id_plano { get => id_plano; set => id_plano = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Duracao { get => duracao; set => duracao = value; }
    }
}
