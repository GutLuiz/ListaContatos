using Contatos.infraestrutura;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Contatos
{
    public partial class Form1 : Form
    {
        // Lista para armazenar os dados
        public List<Formulario> Formularios { get; private set; } = new List<Formulario>();
        public Form1()
        {
            InitializeComponent();
            CustomizeDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObterDados();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtBoxNome_TextChanged(object sender, EventArgs e) { }

        private void txtCofixo2_Click(object sender, EventArgs e) { }

        private void txtBoxName_Click(object sender, EventArgs e) { }

        private void texBoxCelular1_TextChanged(object sender, EventArgs e) { }

        private void textBoxCelular2_TextChanged(object sender, EventArgs e) { }

        private void txtfixo1_Click(object sender, EventArgs e) { }

        private void bntPesquisar_Click(object sender, EventArgs e) { }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtBoxNome.Text;
                var empresa = txtBoxEmpresa.Text;
                var numero1 = textBoxCelular1.Text;
                var numero2 = textBoxCelular2.Text;
                var fixo1 = textBoxCofixo1.Text;
                var fixo2 = textBoxCofixo2.Text;

                // Verificar duplicação
                foreach (var item in Formularios)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " Já está cadastrado no sistema");
                        return;
                    }
                }

                // Adicionar à lista
                var lista = new Formulario(nome, empresa, numero1, numero2, fixo1, fixo2);
                Formularios.Add(lista);

                var repository = new ContatoRepositorio();
                repository.Add(lista);

                // Adicionar ao DataGridView
                dataGridView1.Rows.Add(nome, empresa, numero1, numero2, fixo1, fixo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObterDados()
        {
            try
            {
                var repository = new ContatoRepositorio();
                Formularios = repository.Get();

                dataGridView1.Rows.Clear(); // Limpa o DataGridView antes de adicionar novos itens

                foreach (var item in Formularios)
                {
                    dataGridView1.Rows.Add(item.Nome, item.Empresa, item.Numero1, item.Numero2, item.Fixo1, item.Fixo2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter dados: {ex.Message}");
            }
        }

        private void txtBoxEmpresa_TextChanged(object sender, EventArgs e) { }

        private void txtCelular2_Click(object sender, EventArgs e) { }

        private void lv_Contatos_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtCelular1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var nome = txtBoxNome.Text;
                var empresa = txtBoxEmpresa.Text;
                var numero1 = textBoxCelular1.Text;

                var repository = new ContatoRepositorio();
                bool existe = repository.ExisteFormulario(nome, empresa, numero1);

                if (!existe)
                {
                    MessageBox.Show("Esse dado não está cadastrado no sistema");
                }
                else
                {
                    foreach (var item in Formularios)
                    {
                        dataGridView1.Rows.Add(item.Nome, item.Empresa, item.Numero1, item.Numero2, item.Fixo1, item.Fixo2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void CustomizeDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Empresa", "Empresa");
            dataGridView1.Columns.Add("Celular1", "Celular 1");
            dataGridView1.Columns.Add("Celular2", "Celular 2");
            dataGridView1.Columns.Add("Fixo1", "Fixo 1");
            dataGridView1.Columns.Add("Fixo2", "Fixo 2");
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selecionada = dataGridView1.SelectedRows[0];
                var nome = selecionada.Cells["Nome"].Value.ToString();

                var repository = new ContatoRepositorio();
                repository.Remover(nome);

                dataGridView1.Rows.Remove(selecionada);

                Formularios.RemoveAll(f => f.Nome == nome);

                // No need to reset DataSource and set it again.
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir");
            }
        }
        private int lastSelectedRowIndex = -1;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                if (lastSelectedRowIndex == e.RowIndex)
                {
                    dataGridView1.ClearSelection();
                    lastSelectedRowIndex = -1;
                }
                else
                {
                    lastSelectedRowIndex = e.RowIndex;
                }
            }
        }
        }
}
