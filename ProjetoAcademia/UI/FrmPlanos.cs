using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI
{
    public partial class FrmPlanos : Form
    {
        BLL.plano planoBLL = new BLL.plano();
        DAL.PlanoDAL planoDAL = new DAL.PlanoDAL(); 
        public FrmPlanos()
        {
            InitializeComponent();
        }

        private void FrmPlanos_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            planoBLL.Nome = txtNomePlano.Text;
            planoBLL.Duracao = txtDuracaoPlano.Text;
            planoBLL.Valor = float.Parse(txtValorPlano.Text);

            planoDAL.Cadastrar(planoBLL);
            MessageBox.Show("Plano Cadastrado!!!");

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            planoBLL.Nome = txtNomePlano.Text;
            planoBLL.Duracao = txtDuracaoPlano.Text;
            planoBLL.Valor = float.Parse(txtValorPlano.Text);
            planoBLL.Id_plano = int.Parse(txtIDplano.Text);

            planoDAL.Atualizar(planoBLL);
            MessageBox.Show("Plano Atualizado!!!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            planoBLL.Id_plano = int.Parse(txtIDplano.Text);

            planoDAL.Excluir(planoBLL);
            MessageBox.Show("Plano Excluido!!!");
        }
    }
}
