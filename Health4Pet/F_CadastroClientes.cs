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
    public partial class F_CadastroClientes : Form
    {
        public F_CadastroClientes()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            mtb_cpf.Clear();
            mtb_celular.Clear();
            mtb_telefone.Clear();
            tb_endereco.Clear();
            tb_complemento.Clear();
            tb_bairro.Clear();
            tb_estado.Clear();
            tb_cidade.Clear();
            mtb_cep.Clear();
            tb_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text == "")
            {
                MessageBox.Show("Informe o nome do cliente");
                tb_nome.Focus();
                return;
            }
            else
            {

            }
            Cliente cliente= new Cliente();
            cliente.nome = tb_nome.Text;
            cliente.cpf = mtb_cpf.Text;
            cliente.celular= mtb_celular.Text;
            cliente.telefone= mtb_telefone.Text;
            cliente.endereco= tb_endereco.Text;
            cliente.complemento= tb_complemento.Text;
            cliente.bairro= tb_bairro.Text;
            cliente.estado= tb_estado.Text;
            cliente.cidade= tb_cidade.Text;
            cliente.cep= mtb_cep.Text;

            Banco.NovoCliente(cliente);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
