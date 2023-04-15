using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health4Pet
{
    public partial class F_CadastroAnimal : Form
    {
        public F_CadastroAnimal()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nomeAnimal.Clear();
            tb_raca.Clear();
            tb_especie.Clear();
            tb_observacoes.Clear();
            mtb_dataCadastro.Clear();
            mtb_dataNascimento.Clear();
            n_idade.Value = 0;
            cb_porte.Text = "";
            cb_castrado.Text = "";
            cb_sexo.Text = "";
            cb_dono.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_nomeAnimal.Text == "")
            {
                MessageBox.Show("Informe o nome do Animal");
                tb_nomeAnimal.Focus();
                return;
            }
            else
            {

            }
            Animal animal = new Animal();
            animal.nome = tb_nomeAnimal.Text;
            animal.dataCadastro = mtb_dataCadastro.Text;
            animal.dataNascimento = mtb_dataNascimento.Text;
            animal.idade = Convert.ToInt32(Math.Round(n_idade.Value, 0)) ;
            animal.raca = tb_raca.Text;
            animal.especie = tb_especie.Text;
            animal.porte = cb_porte.Text;
            animal.castrado = cb_castrado.Text;
            animal.sexo = cb_castrado.Text;
            animal.observacoes = tb_observacoes.Text;
            animal.idCliente = Int32.Parse(cb_dono.Text);

            Banco.NovoAnimal(animal);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
