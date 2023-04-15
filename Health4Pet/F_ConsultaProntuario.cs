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
    public partial class F_ConsultaProntuario : Form
    {
        public F_ConsultaProntuario()
        {
            InitializeComponent();
        }

        private void F_ConsultaProntuario_Load(object sender, EventArgs e)
        {
            dgv_prontuarios.DataSource = Banco.ObterProntuarioIdNome();
        }

        private void dgv_prontuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosProntuario(vid);
                tb_paciente.Text = dt.Rows[0].Field<string>("T_NOMEANIMAL").ToString();
                tb_dataHora.Text = dt.Rows[0].Field<string>("T_DATAHORA").ToString();
                tb_idade.Text = dt.Rows[0].Field<Int64>("N_IDADE").ToString();
                tb_peso.Text = dt.Rows[0].Field<string>("T_PESO").ToString();
                tb_altura.Text = dt.Rows[0].Field<string>("T_ALTURA").ToString();
                tb_sintomas.Text = dt.Rows[0].Field<string>("T_SINTOMAS").ToString();
                tb_alergias.Text = dt.Rows[0].Field<string>("T_ALERGIAS").ToString();
                tb_observacoes.Text = dt.Rows[0].Field<string>("T_OBSERVACOES").ToString();
            }
        }
    }
}
