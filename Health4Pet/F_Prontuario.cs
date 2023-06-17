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
    public partial class F_Prontuario : Form
    {
        public F_Prontuario()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_paciente.Clear();
            tb_dataHora.Clear();
            tb_idade.Clear();
            tb_peso.Clear();
            tb_altura.Clear();
            tb_sintomas.Clear();
            tb_alergias.Clear();
            tb_observacoes.Clear();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Prontuario p = new Prontuario();
            p.nome = tb_paciente.Text;
            p.dataHora = tb_dataHora.Text;
            p.idade= Convert.ToInt32(tb_idade.Text);
            p.peso = tb_peso.Text;
            p.altura = tb_altura.Text;
            p.sintomas = tb_sintomas.Text;
            p.alergia = tb_alergias.Text;
            p.observacoes = tb_observacoes.Text;
            Banco.NovoProntuario(p);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
