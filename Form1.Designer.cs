namespace Contatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNome = new Label();
            txtEmpresa = new Label();
            txtCelular1 = new Label();
            txtCelular2 = new Label();
            txtfixo2 = new Label();
            txtfixo1 = new Label();
            txtBoxNome = new TextBox();
            txtBoxEmpresa = new TextBox();
            textBoxCelular1 = new TextBox();
            textBoxCelular2 = new TextBox();
            textBoxCofixo1 = new TextBox();
            textBoxCofixo2 = new TextBox();
            bntAdicionar = new Button();
            txtListaDeContato = new Label();
            btnAtualizar = new Button();
            bntExcluir = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnPesquisar = new Button();
            textBoxPesquisar = new TextBox();
            txtFormulario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.BackColor = Color.Transparent;
            txtNome.Font = new Font("Segoe UI", 17F);
            txtNome.Location = new Point(6, 62);
            txtNome.Margin = new Padding(4, 0, 4, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(81, 31);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.AutoSize = true;
            txtEmpresa.Font = new Font("Segoe UI", 17F);
            txtEmpresa.Location = new Point(6, 148);
            txtEmpresa.Margin = new Padding(4, 0, 4, 0);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(107, 31);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.Text = "Empresa:";
            // 
            // txtCelular1
            // 
            txtCelular1.AutoSize = true;
            txtCelular1.Font = new Font("Segoe UI", 17F);
            txtCelular1.Location = new Point(6, 237);
            txtCelular1.Margin = new Padding(4, 0, 4, 0);
            txtCelular1.Name = "txtCelular1";
            txtCelular1.Size = new Size(108, 31);
            txtCelular1.TabIndex = 2;
            txtCelular1.Text = "Celular 1:";
            txtCelular1.Click += txtCelular1_Click;
            // 
            // txtCelular2
            // 
            txtCelular2.AutoSize = true;
            txtCelular2.Font = new Font("Segoe UI", 17F);
            txtCelular2.Location = new Point(6, 325);
            txtCelular2.Margin = new Padding(4, 0, 4, 0);
            txtCelular2.Name = "txtCelular2";
            txtCelular2.Size = new Size(108, 31);
            txtCelular2.TabIndex = 3;
            txtCelular2.Text = "Celular 2:";
            txtCelular2.Click += txtCelular2_Click;
            // 
            // txtfixo2
            // 
            txtfixo2.AutoSize = true;
            txtfixo2.Font = new Font("Segoe UI", 17F);
            txtfixo2.Location = new Point(13, 499);
            txtfixo2.Margin = new Padding(4, 0, 4, 0);
            txtfixo2.Name = "txtfixo2";
            txtfixo2.Size = new Size(74, 31);
            txtfixo2.TabIndex = 4;
            txtfixo2.Text = "fixo 2:";
            txtfixo2.Click += txtCofixo2_Click;
            // 
            // txtfixo1
            // 
            txtfixo1.AutoSize = true;
            txtfixo1.Font = new Font("Segoe UI", 17F);
            txtfixo1.Location = new Point(13, 411);
            txtfixo1.Margin = new Padding(4, 0, 4, 0);
            txtfixo1.Name = "txtfixo1";
            txtfixo1.Size = new Size(74, 31);
            txtfixo1.TabIndex = 5;
            txtfixo1.Text = "fixo 1:";
            txtfixo1.Click += txtfixo1_Click;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Font = new Font("Segoe UI", 17F);
            txtBoxNome.Location = new Point(6, 97);
            txtBoxNome.Margin = new Padding(4);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(313, 38);
            txtBoxNome.TabIndex = 6;
            txtBoxNome.TextChanged += txtBoxNome_TextChanged;
            // 
            // txtBoxEmpresa
            // 
            txtBoxEmpresa.Font = new Font("Segoe UI", 17F);
            txtBoxEmpresa.Location = new Point(6, 183);
            txtBoxEmpresa.Margin = new Padding(4);
            txtBoxEmpresa.Name = "txtBoxEmpresa";
            txtBoxEmpresa.Size = new Size(313, 38);
            txtBoxEmpresa.TabIndex = 7;
            txtBoxEmpresa.TextChanged += txtBoxEmpresa_TextChanged;
            // 
            // textBoxCelular1
            // 
            textBoxCelular1.Font = new Font("Segoe UI", 17F);
            textBoxCelular1.Location = new Point(13, 272);
            textBoxCelular1.Margin = new Padding(4);
            textBoxCelular1.Name = "textBoxCelular1";
            textBoxCelular1.Size = new Size(313, 38);
            textBoxCelular1.TabIndex = 8;
            textBoxCelular1.TextChanged += texBoxCelular1_TextChanged;
            // 
            // textBoxCelular2
            // 
            textBoxCelular2.Font = new Font("Segoe UI", 17F);
            textBoxCelular2.Location = new Point(13, 360);
            textBoxCelular2.Margin = new Padding(4);
            textBoxCelular2.Name = "textBoxCelular2";
            textBoxCelular2.Size = new Size(313, 38);
            textBoxCelular2.TabIndex = 9;
            textBoxCelular2.TextChanged += textBoxCelular2_TextChanged;
            // 
            // textBoxCofixo1
            // 
            textBoxCofixo1.Font = new Font("Segoe UI", 17F);
            textBoxCofixo1.Location = new Point(13, 446);
            textBoxCofixo1.Margin = new Padding(4);
            textBoxCofixo1.Name = "textBoxCofixo1";
            textBoxCofixo1.Size = new Size(313, 38);
            textBoxCofixo1.TabIndex = 10;
            // 
            // textBoxCofixo2
            // 
            textBoxCofixo2.Font = new Font("Segoe UI", 17F);
            textBoxCofixo2.Location = new Point(13, 534);
            textBoxCofixo2.Margin = new Padding(4);
            textBoxCofixo2.Name = "textBoxCofixo2";
            textBoxCofixo2.Size = new Size(313, 38);
            textBoxCofixo2.TabIndex = 11;
            // 
            // bntAdicionar
            // 
            bntAdicionar.Location = new Point(13, 590);
            bntAdicionar.Margin = new Padding(4);
            bntAdicionar.Name = "bntAdicionar";
            bntAdicionar.Size = new Size(85, 30);
            bntAdicionar.TabIndex = 12;
            bntAdicionar.Text = "Adicionar";
            bntAdicionar.UseVisualStyleBackColor = true;
            bntAdicionar.Click += bntAdicionar_Click;
            // 
            // txtListaDeContato
            // 
            txtListaDeContato.AutoSize = true;
            txtListaDeContato.Font = new Font("Segoe UI", 20F);
            txtListaDeContato.Location = new Point(232, 20);
            txtListaDeContato.Margin = new Padding(4, 0, 4, 0);
            txtListaDeContato.Name = "txtListaDeContato";
            txtListaDeContato.Size = new Size(243, 37);
            txtListaDeContato.TabIndex = 13;
            txtListaDeContato.Text = "LISTA DE CONTATO";
            txtListaDeContato.Click += label1_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(118, 590);
            btnAtualizar.Margin = new Padding(4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(85, 30);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // bntExcluir
            // 
            bntExcluir.Location = new Point(220, 590);
            bntExcluir.Margin = new Padding(4);
            bntExcluir.Name = "bntExcluir";
            bntExcluir.Size = new Size(85, 30);
            bntExcluir.TabIndex = 15;
            bntExcluir.Text = "Excluir";
            bntExcluir.UseVisualStyleBackColor = true;
            bntExcluir.Click += bntExcluir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(textBoxPesquisar);
            panel1.Controls.Add(txtListaDeContato);
            panel1.Location = new Point(457, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 632);
            panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(629, 518);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 12F);
            btnPesquisar.Location = new Point(35, 66);
            btnPesquisar.Margin = new Padding(4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(107, 30);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Font = new Font("Segoe UI", 10F);
            textBoxPesquisar.Location = new Point(160, 71);
            textBoxPesquisar.Margin = new Padding(4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(315, 25);
            textBoxPesquisar.TabIndex = 20;
            textBoxPesquisar.TextChanged += textBoxPesquisar_TextChanged;
            // 
            // txtFormulario
            // 
            txtFormulario.AutoSize = true;
            txtFormulario.Font = new Font("Segoe UI", 20F);
            txtFormulario.Location = new Point(150, 9);
            txtFormulario.Margin = new Padding(4, 0, 4, 0);
            txtFormulario.Name = "txtFormulario";
            txtFormulario.Size = new Size(146, 37);
            txtFormulario.TabIndex = 14;
            txtFormulario.Text = "Formulario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 635);
            Controls.Add(txtFormulario);
            Controls.Add(panel1);
            Controls.Add(bntExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(bntAdicionar);
            Controls.Add(textBoxCofixo2);
            Controls.Add(textBoxCofixo1);
            Controls.Add(textBoxCelular2);
            Controls.Add(textBoxCelular1);
            Controls.Add(txtBoxEmpresa);
            Controls.Add(txtBoxNome);
            Controls.Add(txtfixo1);
            Controls.Add(txtfixo2);
            Controls.Add(txtCelular2);
            Controls.Add(txtCelular1);
            Controls.Add(txtEmpresa);
            Controls.Add(txtNome);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNome;
        private Label txtEmpresa;
        private Label txtCelular1;
        private Label txtCelular2;
        private Label txtfixo2;
        private Label txtfixo1;
        private TextBox txtBoxNome;
        private TextBox txtBoxEmpresa;
        private TextBox textBoxCelular1;
        private TextBox textBoxCelular2;
        private TextBox textBoxCofixo1;
        private TextBox textBoxCofixo2;
        private Button bntAdicionar;
        private Label txtListaDeContato;
        private Button btnAtualizar;
        private Button bntExcluir;
        private Panel panel1;
        private Label txtFormulario;
        private TextBox textBoxPesquisar;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
    }
}
