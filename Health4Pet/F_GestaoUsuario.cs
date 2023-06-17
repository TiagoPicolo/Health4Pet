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
    public partial class F_GestaoUsuario : Form
    {
        public F_GestaoUsuario()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuario_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHALOGIN").ToString();
                tb_login.Text = dt.Rows[0].Field<string>("T_LOGIN").ToString();
                cb_situacao.Text = dt.Rows[0].Field<string>("T_SITUACAO").ToString();
                n_nivelPermissao.Value = dt.Rows[0].Field<Int64>("N_NIVELPERMISSAO");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_CadastroUsuario f_CadastroUsuario = new F_CadastroUsuario();
            f_CadastroUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.login= tb_login.Text;
            u.senha = tb_senha.Text;
            u.situacao= cb_situacao.Text;
            u.nivelPermicao = Convert.ToInt32(Math.Round(n_nivelPermissao.Value, 0));
            Banco.AtualizarUsuario(u);
            //dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            //dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
