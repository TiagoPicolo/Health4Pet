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
    public partial class F_gestaoAnimal : Form
    {
        public F_gestaoAnimal()
        {
            InitializeComponent();
        }

        private void F_gestaoAnimal_Load(object sender, EventArgs e)
        {
            dgv_animais.DataSource = Banco.ObterAnimaisIdNome();
        }

        private void dgv_animais_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosAnimal(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDANIMAL").ToString();
                tb_nomeAnimal.Text = dt.Rows[0].Field<string>("T_NOMEANIMAL").ToString();
                mtb_dataCadastro.Text = dt.Rows[0].Field<string>("T_DATACADASTRO").ToString();
                mtb_dataNascimento.Text = dt.Rows[0].Field<string>("T_DATANASCIMENTO").ToString();
                n_idade.Text = dt.Rows[0].Field<Int64>("N_IDADE").ToString();
                tb_raca.Text = dt.Rows[0].Field<string>("T_RACA").ToString();
                tb_especie.Text = dt.Rows[0].Field<string>("T_ESPECIE").ToString();
                cb_porte.Text = dt.Rows[0].Field<string>("T_PORTE").ToString();
                cb_castrado.Text = dt.Rows[0].Field<string>("T_CASTRADO").ToString();
                cb_sexo.Text = dt.Rows[0].Field<string>("T_SEXO").ToString();
                cb_dono.Text = dt.Rows[0].Field<Int64>("N_IDCLIENTES").ToString();
                tb_observacoes.Text = dt.Rows[0].Field<string>("T_OBSERVACOES").ToString();

            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_CadastroAnimal f_CadastroAnimal= new F_CadastroAnimal();
            f_CadastroAnimal.ShowDialog();
            dgv_animais.DataSource = Banco.ObterAnimaisIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_animais.SelectedRows[0].Index;
            Animal a = new Animal();
            a.id = Convert.ToInt32(tb_id.Text);
            a.nome = tb_nomeAnimal.Text;
            a.dataCadastro = mtb_dataCadastro.Text;
            a.dataNascimento = mtb_dataNascimento.Text;
            a.idade = Convert.ToInt32(Math.Round(n_idade.Value, 0));
            a.raca = tb_raca.Text;
            a.especie = tb_especie.Text;
            a.porte = cb_porte.Text;
            a.castrado = cb_castrado.Text;
            a.sexo = cb_sexo.Text;
            a.observacoes = tb_observacoes.Text;
            a.idCliente = Int32.Parse(cb_dono.Text);
            Banco.AtualizarAnimal(a);
            dgv_animais.DataSource = Banco.ObterAnimaisIdNome();
            dgv_animais.CurrentCell = dgv_animais[1, linha];
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Banco.DeletarAnimal(tb_id.Text);
                dgv_animais.Rows.Remove(dgv_animais.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
