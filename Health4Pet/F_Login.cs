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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string senha = tb_senha.Text;

            if (login == "")
            {
                MessageBox.Show("Usuario Invalido");
                tb_login.Focus();
                return;
            }
            else if (senha == "")
            {
                MessageBox.Show("Senha Invalida");
                tb_senha.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_LOGIN ='" + login + "'AND T_SENHALOGIN ='" + senha + "'";
            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                //form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                //form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                //form1.pb_ledLogado.Image = Properties.Resources.botao_verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELPERMISSAO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorretos");
                tb_login.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
