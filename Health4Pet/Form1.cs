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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }



        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado == true)
            {
                MessageBox.Show("Você já esta logado");
                return;
            }
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lb_acesso.Text = "0";
            //lb_nomeUsuario.Text = "---";
            //pb_ledLogado.Image = Properties.Resources.botao_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void cadastroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    // Procedimentos da Janela
                    F_CadastroUsuario f_CadastroUsuario = new F_CadastroUsuario();
                    f_CadastroUsuario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado!!");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    // Procedimentos da Janela
                    F_GestaoUsuario f_GestaoUsuario = new F_GestaoUsuario();
                    f_GestaoUsuario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado!!");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void cadastroDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    // Procedimentos da Janela
                    F_CadastroClientes f_CadastroClientes = new F_CadastroClientes();
                    f_CadastroClientes.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado!!");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void cadastroDeAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    // Procedimentos da Janela
                    F_CadastroAnimal f_CadastroAnimal = new F_CadastroAnimal();
                    f_CadastroAnimal.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado!!");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void gestãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoClientes f_GestaoClientes = new F_GestaoClientes();
            f_GestaoClientes.ShowDialog();
        }

        private void gestãoDeAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_gestaoAnimal f_gestaoAnimal = new F_gestaoAnimal();
            f_gestaoAnimal.ShowDialog();
        }

        private void prontuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Prontuario f_Prontuario = new F_Prontuario();
            f_Prontuario.ShowDialog();
        }

        private void consultaProntuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ConsultaProntuario f_ConsultaProntuario = new F_ConsultaProntuario();
            f_ConsultaProntuario.ShowDialog(); 
        }
    }
}
