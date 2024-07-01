using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Contatos.infraestrutura; // Adicionando namespace do repositório

namespace Contatos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           

           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Ação ao carregar o ReportViewer, se necessário
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var dt = Formulario.ObterContatos();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Contatos.RelatorioContatos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }
    }
}
