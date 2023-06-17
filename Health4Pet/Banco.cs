using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Health4Pet
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        // FUNÇÕES GENERICAS
        public static DataTable dql(string sql) //DATA QUERRY LANGUAGE (SELECT) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK = null, string msgERRO = null) //DATA MANIPULATION LANGUAGE (INSERT, DELETE, UPDATE)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }


            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObterTodosClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_clientes";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObterTodosAnimais()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_animal";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Inicio - Funções do Form F_Gestao Usuarios

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select N_IDUSUARIO as 'ID Usuario', T_NOMEUSUARIO as 'Nome Usuario' from tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO = '" + u.nome + "', T_LOGIN = '" + u.login + "', T_SENHALOGIN = '" + u.senha + "', T_SITUACAO = '" + u.situacao + "', N_NIVELPERMISSAO = " + u.nivelPermicao + " WHERE N_IDUSUARIO =" + u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Aqui memo");
                //throw ex;
            }

        }

        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Fim - Funções do Form F_Gestao Usuarios

        //Inicio - Funções do Form F_Novo Usuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u) == true)
            {
                MessageBox.Show("Username Já Existe!!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_LOGIN, T_SENHALOGIN, T_SITUACAO, N_NIVELPERMISSAO) VALUES (@nome,@login,@senha,@situacao,@nivelPermissao)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@login", u.login);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@situacao", u.situacao);
                cmd.Parameters.AddWithValue("@nivelPermissao", u.nivelPermicao);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuario Adcionado com Sucesso");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
            }

        }
        //Fim - Funções do Form F_Novo Usuario

        //Inicio - Funções do Form F_Gestao Clientes

        public static DataTable ObterClienteIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select N_IDCLIENTE as 'ID Clientes', T_NOMECLIENTE as 'Nome Clientes' from tb_clientes";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void AtualizarCliente(Cliente c)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "UPDATE tb_clientes SET T_NOMECLIENTE = '" + c.nome + "', T_CPF = '" + c.cpf+ "', T_CELULAR = '" + c.celular + "', T_TELEFONE = '" + c.telefone + "', T_ENDERECO = " + c.endereco + "', T_COMPLEMENTO = " + c.complemento + "', T_BAIRRO = " + c.bairro + "', T_ESTADO = " + c.estado + "', T_CIDADE = " + c.cidade + "', T_CEP = " + c.cep+ " WHERE N_IDCLIENTE =" + c.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                //throw ex;
            }

        }

        public static void DeletarCliente(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM tb_clientes WHERE N_IDCLIENTE =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Fim - Funções do Form F_Gestao Clientes

        //Inicio - Funções do Form F_Novo Cliente

        public static void NovoCliente(Cliente c)
        {
            if (existeCPF(c) == true)
            {
                MessageBox.Show("Cliente com o mesmo CPF ja cadastrado!!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_clientes (T_NOMECLIENTE, T_CPF, T_CELULAR, T_TELEFONE, T_ENDERECO, T_COMPLEMENTO, T_BAIRRO, T_ESTADO, T_CIDADE, T_CEP) VALUES (@nome,@cpf,@celular,@telefone,@endereco,@complemento,@bairro,@estado,@cidade,@cep)";
                cmd.Parameters.AddWithValue("@nome", c.nome);
                cmd.Parameters.AddWithValue("@cpf", c.cpf);
                cmd.Parameters.AddWithValue("@celular", c.celular);
                cmd.Parameters.AddWithValue("@telefone", c.telefone);
                cmd.Parameters.AddWithValue("@endereco", c.endereco);
                cmd.Parameters.AddWithValue("@complemento", c.complemento);
                cmd.Parameters.AddWithValue("@bairro", c.bairro);
                cmd.Parameters.AddWithValue("@estado", c.estado);
                cmd.Parameters.AddWithValue("@cidade", c.cidade);
                cmd.Parameters.AddWithValue("@cep", c.cep);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Cliente Adcionado com Sucesso");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
            }

        }
        //Fim - Funções do Form F_Novo Cliente

        //Inicio - Funções do Form F_Gestao Animais

        public static DataTable ObterAnimaisIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select N_IDANIMAL as 'ID Animal', T_NOMEANIMAL as 'Nome Animal' from tb_animal";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void AtualizarAnimal(Animal a)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "UPDATE tb_animal SET T_NOMEANIMAL = '" + a.nome + "', T_DATACADASTRO = '" + a.dataCadastro + "', T_DATANASCIMENTO = '" + a.dataNascimento + "', N_IDADE = '" + a.idade + "', T_RACA = " + a.raca + "', T_ESPECIE = " + a.especie + "', T_PORTE = " + a.porte + "', T_CASTRADO = " + a.castrado + "', T_SEXO = " + a.sexo + "', N_IDCLIENTES = " + a.idCliente+ " WHERE N_IDANIMAL = " + a.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                //throw ex;
            }

        }

        public static void DeletarAnimal(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM tb_animal WHERE N_IDANIMAL =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Fim - Funções do Form F_Gestao Animais

        //Inicio - Funções do Form F_Novo Animal

        public static void NovoAnimal(Animal a)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_animal (T_NOMEANIMAL, T_DATACADASTRO, T_DATANASCIMENTO, N_IDADE, T_RACA, T_ESPECIE, T_PORTE, T_CASTRADO, T_SEXO, T_OBSERVACOES, N_IDCLIENTES) VALUES (@nome,@dataCadastro,@dataNascimento,@idade,@raca,@especie,@porte,@castrado,@sexo,@observacoes,@idCliente)";
                cmd.Parameters.AddWithValue("@nome", a.nome);
                cmd.Parameters.AddWithValue("@dataCadastro", a.dataCadastro);
                cmd.Parameters.AddWithValue("@dataNascimento", a.dataNascimento);
                cmd.Parameters.AddWithValue("@idade", a.idade);
                cmd.Parameters.AddWithValue("@raca", a.raca);
                cmd.Parameters.AddWithValue("@especie", a.especie);
                cmd.Parameters.AddWithValue("@porte", a.porte);
                cmd.Parameters.AddWithValue("@castrado", a.castrado);
                cmd.Parameters.AddWithValue("@sexo", a.sexo);
                cmd.Parameters.AddWithValue("@observacoes", a.observacoes);
                cmd.Parameters.AddWithValue("@idCliente", a.idCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Animal Adcionado com Sucesso");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
            }

        }
        //Fim - Funções do Form F_Novo Animal

        //Inicio - Funções do Form F_Prontuario
        public static void NovoProntuario(Prontuario p)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_prontuario (T_NOMEANIMAL, N_IDADE, T_PESO, T_ALTURA, T_ALERGIAS, T_SINTOMAS, T_OBSERVACOES,T_DATAHORA) VALUES (@nome,@idade,@peso,@altura,@alergia,@sintomas,@observacoes,@dataHora)";
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@idade", p.idade);
                cmd.Parameters.AddWithValue("@peso", p.peso);
                cmd.Parameters.AddWithValue("@altura", p.altura);
                cmd.Parameters.AddWithValue("@alergia", p.alergia);
                cmd.Parameters.AddWithValue("@sintomas", p.sintomas);
                cmd.Parameters.AddWithValue("@observacoes", p.observacoes);
                cmd.Parameters.AddWithValue("@dataHora", p.dataHora);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Prontuario Adcionado com Sucesso");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo prontuario");
            }

        }

        public static DataTable ObterProntuarioIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select N_IDPRONTUARIO as 'ID', T_NOMEANIMAL as 'Nome Animal', T_DATAHORA as 'Data/Hora' from tb_prontuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObterProntuarioTodos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select N_IDPRONTUARIO as 'ID', T_NOMEANIMAL as 'Nome Animal', N_IDADE as 'Idade', T_PESO as 'Peso', T_ALTURA as 'Altura', T_ALERGIAS as 'Alergias', T_SINTOMAS as 'Sintomas', T_OBSERVACOES as 'Observacoes', T_DATAHORA as 'Data/Hora' from tb_prontuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Fim - Funções do Form F_Prontuario


        //Rotinas Gerais
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_LOGIN FROM tb_usuarios WHERE T_LOGIN ='" + u.login + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Clone();
            return res;
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_usuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool existeCPF(Cliente c)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_CPF FROM tb_clientes WHERE T_CPF ='" + c.cpf + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Clone();
            return res;
        }

        public static DataTable ObterDadosCliente(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_clientes WHERE N_IDCLIENTE = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObterDadosAnimal(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_animal WHERE N_IDANIMAL = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /*public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_usuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }*/

        public static DataTable ObterDadosProntuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "select * from tb_prontuario WHERE N_IDPRONTUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
