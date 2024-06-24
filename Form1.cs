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
        
        // Metodo que é chamado automaticamente quando o formulario é carregado pela primeira vez.
        private void Form1_Load(object sender, EventArgs e)
        {
            // chamando o metodo para quando começar a aplicação tenha ja os dados nas grades
            ObterDados();
            // chamando o metodo que é um controle do dataGrid com o clear que desmarcaa qualquer celularr, linha ou coluna selecionada
            dataGridView1.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtBoxNome_TextChanged(object sender, EventArgs e) { }

        private void txtCofixo2_Click(object sender, EventArgs e) { }

        private void txtBoxName_Click(object sender, EventArgs e) { }

        private void texBoxCelular1_TextChanged(object sender, EventArgs e) { }

        private void textBoxCelular2_TextChanged(object sender, EventArgs e) { }

        private void txtfixo1_Click(object sender, EventArgs e) { }

        private void bntPesquisar_Click(object sender, EventArgs e) { }

        //Botão adicionar:
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

                // Verificando duplicação
                foreach (var item in Formularios)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " Já está cadastrado no sistema");
                        return;
                    }
                }

                // Adicionando à lista
                var lista = new Formulario(nome, empresa, numero1, numero2, fixo1, fixo2);
                Formularios.Add(lista);
                
                // adicionando o metodo e armazenando no banco de dados
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
                // instancia a classe responsavel por acessar os dados dos contatos, o banco de dados
                var repository = new ContatoRepositorio();
                // chama o metodo  'get' do repositorio para obter a lista de formalarios (contatos)
                Formularios = repository.Get();
                // Limpa o DataGridView antes de adicionar novos itens
                dataGridView1.Rows.Clear(); 

                // Itera sobre cada item na lista e adiciona uma nova linha ao "dataGrid" para cada item, preenchendo as colunas com os valores correspondentes
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
            {   // Iteração sobre as linhas do DataGridView sobre cada linha 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Verifica o texto "textBoxPesquisar" corresponde ao valor da celular "Nome". Se essa condição for verdadeira, a linha sera selecionada
                    if (textBoxPesquisar.Text.ToLower() == row.Cells["Nome"].Value.ToString().ToLower())
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum dado encontrado");
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter dados: {ex.Message}");
            }
        } 
        
        private void BuscarDados()
        {
              try
            {   // Iteração sobre as linhas do DataGridView sobre cada linha 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Verifica o texto "textBoxPesquisar" corresponde ao valor da celular "Nome". Se essa condição for verdadeira, a linha sera selecionada
                    if (textBoxPesquisar.Text == row.Cells["Nome"].Value.ToString());
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter dados: {ex.Message}");
            }
        }
          
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        // Metodo para excluir uma linha do "dataGridView"
        private void bntExcluir_Click(object sender, EventArgs e)
        {
            //verifica a seleção de linhas se for maior que 0 entra na condicional
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtem a primeira linha selecionada e o valor da celular "Nome" dessa linha
                var selecionada = dataGridView1.SelectedRows[0];
                var nome = selecionada.Cells["Nome"].Value.ToString();

                // Cria uma instancia e chama o metodo "remover" passado o nome para remover o ontato do repositorio de dados (banco de dados)
                var repository = new ContatoRepositorio();
                repository.Remover(nome);

                //Remove a linha selecionada pelo "DataGridView"
                dataGridView1.Rows.Remove(selecionada);

                //Remove todos os itens da lista 'formularios' cujo 'nome' corresponda ao 'nome' do contato removido
                Formularios.RemoveAll(f => f.Nome == nome);

                // Limpa qualquer seleção restante no "DataGridView"
                dataGridView1.ClearSelection(); 
            }
        }
        //Metodo para atualizar uma linha
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Valores inseridos pelo usuario
            var nome = txtBoxNome.Text;
            var empresa = txtBoxEmpresa.Text;
            var numero1 = textBoxCelular1.Text;
            var numero2 = textBoxCelular2.Text;
            var fixo1 = textBoxCofixo1.Text;
            var fixo2 = textBoxCofixo2.Text;

            //Cria uma nova instancia da classe 'Formulario' e preenche suas propriedades com os valores capturados
            var formularioAtualizado = new Formulario
            {
                Nome = nome,
                Empresa = empresa,
                Numero1 = numero1,
                Numero2 = numero2,
                Fixo1 = fixo1,
                Fixo2 = fixo2
            };

            //Cria uma instancia e chama o metodo atualizar passado o objeto 'FormularioAtualizado'
            var repository = new ContatoRepositorio();
            bool atualizado = repository.Atualizar(formularioAtualizado);

            //Verificação se foi atualizado corretamente
            if (atualizado)
            {
                MessageBox.Show("Informações atualizadas com sucesso");
                ObterDados(); 
            }
            else
            {
                MessageBox.Show("Erro ao atualizar as informações");
            }
        }

        private void CustomizeDataGridView()
        {
            //Estilo da Grade, linha alternadas, Cabeçalho, colunas
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

            //Adição de colunas 
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Empresa", "Empresa");
            dataGridView1.Columns.Add("Celular1", "Celular 1");
            dataGridView1.Columns.Add("Celular2", "Celular 2");
            dataGridView1.Columns.Add("Fixo1", "Fixo 1");
            dataGridView1.Columns.Add("Fixo2", "Fixo 2");
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
