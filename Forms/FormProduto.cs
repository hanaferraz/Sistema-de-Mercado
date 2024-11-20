using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prova2.Forms
{
    public partial class FormProduto : Form
    {
        // Lista para armazenar os produtos
        private List<Produto> produtos = new List<Produto>();

        public FormProduto()
        {
            InitializeComponent();

            // Configuração da DataGridView
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Preço";
            dataGridView1.Columns[2].Name = "Quantidade";
            dataGridView1.Columns[3].Name = "Código de Barras";
        }

        // Evento de clique para o botão "Salvar"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            decimal preco;
            int quantidade;
            string codigoBarras = textBox4.Text.Trim();

            // Verificação para evitar campos em branco
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Nenhum campo pode estar em branco.");
                return;
            }

            // Validação do nome
            if (!Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("O nome do produto deve conter apenas letras e espaços.");
                return;
            }

            // Validação do preço
            if (!decimal.TryParse(textBox2.Text, out preco) || preco < 0)
            {
                MessageBox.Show("Insira um valor válido e não-negativo para o preço.");
                return;
            }

            // Validação da quantidade
            if (!int.TryParse(textBox3.Text, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Insira um valor inteiro não-negativo para a quantidade.");
                return;
            }

            // Validação do código de barras
            if (!Regex.IsMatch(codigoBarras, @"^\d+$"))
            {
                MessageBox.Show("O código de barras deve conter apenas números.");
                return;
            }

            // Criação do produto e adição na lista
            Produto produto = new Produto(nome, preco, quantidade, codigoBarras);
            produtos.Add(produto);

            // Adição do produto na DataGridView
            dataGridView1.Rows.Add(produto.Nome, produto.Preco.ToString("C"), produto.Quantidade, produto.CodigoBarras);

            LimparCampos();
        }

        // Método para limpar os campos após o cadastro
        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // Método para bloquear a tecla "Espaço" nos campos de entrada
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Espaços não são permitidos.");
            }
        }

        // Classe Produto para armazenar as informações do produto
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
            public string CodigoBarras { get; set; }

            public Produto(string nome, decimal preco, int quantidade, string codigoBarras)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
                CodigoBarras = codigoBarras;
            }
        }

        // Métodos de manipulação dos TextBoxes
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
    }
}
