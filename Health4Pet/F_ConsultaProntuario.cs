using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Health4Pet
{
    public partial class F_ConsultaProntuario : Form
    {
        string vquerryDGV;
        public F_ConsultaProntuario()
        {
            InitializeComponent();
        }

        private void F_ConsultaProntuario_Load(object sender, EventArgs e)
        {
            dgv_prontuarios.DataSource = Banco.ObterProntuarioTodos();

            vquerryDGV = @"
                SELECT N_IDPRONTUARIO as 'ID',
                       T_NOMEANIMAL as 'Nome',
                       N_IDADE as 'Idade', 
                       T_PESO as 'Peso',
                       T_ALTURA as 'Altura',
                       T_ALERGIAS as 'Alergias',
                       T_SINTOMAS as 'Sintomas', 
                       T_OBSERVACOES as 'Observacoes',
                       T_DATAHORA as 'DataHora'

                FROM tb_prontuario
            ";
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

        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\prontuario.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
            logo.ScaleToFit(100f, 100f);
            logo.Alignment = Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100f, 700f); //X ,-Y

            string dados = "";
            Paragraph titulo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Prontuario Veterinário\n\n");

            Paragraph rodape = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            rodape.Alignment = Element.ALIGN_CENTER;
            rodape.Add("Prontuario Veterinário\n\n");

            PdfPTable tabela = new PdfPTable(dgv_prontuarios.ColumnCount);
            //tabela.DefaultCell.FixedHeight = 20;

            for (int i = 0; i < dgv_prontuarios.Columns.Count; i++)
            {
                tabela.AddCell(dgv_prontuarios.Columns[i].HeaderText);
                tabela.HorizontalAlignment = Element.ALIGN_CENTER;
            }

            DataGridViewRow linhaSelecionada = dgv_prontuarios.SelectedRows[0];
            for (int i = 0;i< linhaSelecionada.Cells.Count;i++)
            {
                PdfPCell info = new PdfPCell(new Phrase(linhaSelecionada.Cells[i].Value.ToString()));
                info.NoWrap = false;
                info.HorizontalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(info);
            }



            /*tabela.AddCell("ID");
            tabela.AddCell("Nome");
            tabela.AddCell("Idade");
            tabela.AddCell("Peso");
            tabela.AddCell("Altura");
            tabela.AddCell("Alergias");
            tabela.AddCell("Sintomas");
            tabela.AddCell("Observacoes");
            tabela.AddCell("DataHora");

            DataTable dtProntuario = Banco.dql(vquerryDGV);
            for (int i = 0; i < dtProntuario.Rows.Count; i++)
            {
                tabela.AddCell(dtProntuario.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Nome"));
                tabela.AddCell(dtProntuario.Rows[i].Field<Int64>("Idade").ToString());
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Peso"));
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Altura"));
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Alergias"));
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Sintomas"));
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("Observacoes"));
                tabela.AddCell(dtProntuario.Rows[i].Field<string>("DataHora"));
            }*/

            doc.Open();
            doc.Add(logo);
            doc.Add(titulo);
            doc.Add(tabela);
            doc.Add(rodape);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o Prontuário?", "Prontuário", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\prontuario.pdf");
            }

        }
    }
}
