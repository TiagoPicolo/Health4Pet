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
    public partial class F_CadastroUsuario : Form
    {
        public F_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_login.Clear();
            tb_senha.Clear();
            cb_situacao.Text = "";
            n_nivelPermissao.Value = 0;
            tb_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.login= tb_login.Text;
            usuario.senha = tb_senha.Text;
            usuario.situacao= cb_situacao.Text;
            usuario.nivelPermicao= Convert.ToInt32(Math.Round(n_nivelPermissao.Value, 0)); //Usar Math e Convert Por conta do NumberUpDown Ser Decimal

            Banco.NovoUsuario(usuario);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
