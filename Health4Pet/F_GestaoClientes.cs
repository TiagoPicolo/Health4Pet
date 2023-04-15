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
    public partial class F_GestaoClientes : Form
    {
        public F_GestaoClientes()
        {
            InitializeComponent();
        }

        private void F_GestaoClientes_Load(object sender, EventArgs e)
        {
            dgv_clientes.DataSource = Banco.ObterClienteIdNome();
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosCliente(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDCLIENTE").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMECLIENTE").ToString();
                mtb_cpf.Text = dt.Rows[0].Field<string>("T_CPF").ToString();
                mtb_celular.Text = dt.Rows[0].Field<string>("T_CELULAR").ToString();
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE").ToString();
                tb_endereco.Text = dt.Rows[0].Field<string>("T_ENDERECO").ToString();
                tb_complemento.Text = dt.Rows[0].Field<string>("T_COMPLEMENTO").ToString();
                tb_bairro.Text = dt.Rows[0].Field<string>("T_BAIRRO").ToString();
                tb_estado.Text = dt.Rows[0].Field<string>("T_ESTADO").ToString();
                tb_cidade.Text = dt.Rows[0].Field<string>("T_CIDADE").ToString();
                mtb_cep.Text = dt.Rows[0].Field<string>("T_CEP").ToString();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_CadastroClientes f_CadastroClientes = new F_CadastroClientes();
            f_CadastroClientes.ShowDialog();
            dgv_clientes.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_clientes.SelectedRows[0].Index;
            Cliente c = new Cliente();
            c.id = Convert.ToInt32(tb_id.Text);
            c.nome = tb_nome.Text;
            c.cpf = mtb_cpf.Text;
            c.celular = mtb_celular.Text;
            c.telefone = mtb_telefone.Text;
            c.endereco = tb_endereco.Text;
            c.complemento = tb_complemento.Text;
            c.bairro = tb_bairro.Text;
            c.estado = tb_estado.Text;
            c.cidade = tb_cidade.Text;
            c.cep = mtb_cep.Text;
            Banco.AtualizarCliente(c);
            dgv_clientes.DataSource = Banco.ObterClienteIdNome();
            dgv_clientes.CurrentCell = dgv_clientes[1, linha];

            //dgv_clientes[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Banco.DeletarCliente(tb_id.Text);
                dgv_clientes.Rows.Remove(dgv_clientes.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
