using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2.Forms
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }
        private void CarregarProdutos()
        {
            try
            {
                // Consulta SQL para buscar todos os produtos
                string query = "SELECT Id, Nome, Quantidade, Preco, Ativo FROM Estoque WHERE Ativo = 1";

                // Executando a consulta e obtendo os resultados
                DataTable dtProdutos = Conexao.ExecuteQuery(query);

                // Limpando os dados antigos na grid
                gridEstoque.Rows.Clear();

                // Preenchendo a gridEstoque com os dados dos produtos
                foreach (DataRow row in dtProdutos.Rows)
                {
                    gridEstoque.Rows.Add(
                        row["Id"].ToString(),
                        row["Nome"].ToString(),
                        Convert.ToDecimal(row["Preco"]).ToString("C"),
                        row["Quantidade"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // Método para buscar produtos na grid
        private void BuscarProdutos(string nomeProduto)
        {
            try
            {
                // Consulta SQL para buscar produtos que contenham o nome digitado no txtProcurar
                string query = "SELECT Id, Nome, Quantidade, Preco, Ativo FROM Estoque WHERE Nome LIKE @Nome AND Ativo = 1";

                // Adicionando parâmetro para a consulta
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nome", "%" + nomeProduto + "%")  // Faz a busca por nome com LIKE
                };

                // Executando a consulta e obtendo os resultados
                DataTable dtProdutos = Conexao.ExecuteQuery(query, parameters);

                // Limpando os dados antigos na grid
                gridEstoque.Rows.Clear();

                // Preenchendo a gridEstoque com os dados dos produtos
                foreach (DataRow row in dtProdutos.Rows)
                {
                    gridEstoque.Rows.Add(
                        row["Id"].ToString(),
                        row["Nome"].ToString(),
                        Convert.ToDecimal(row["Preco"]).ToString("C"),
                        row["Quantidade"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
            }
        }

        // Evento que será chamado ao carregar o formulário
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos(); // Carrega os produtos na grid quando o formulário for carregado
        }
        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {

        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {

        }

        private void gridEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string nome = txtProcurar.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite o nome do produto para buscar.");
                return;
            }

            string query = "SELECT * FROM Produtos WHERE Nome = @nome";

            try
            {
                SqlParameter[] parameters = {
             new SqlParameter("@nome", nome)
         };

                DataTable resultado = Conexao.ExecuteQuery(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    gridEstoque.DataSource = resultado;

                    // Preenche os campos de texto com os detalhes do produto encontrado
                    DataRow produto = resultado.Rows[0];
                    txtProcurar.Text = produto["Nome"].ToString();
                   

                    MessageBox.Show("Produto encontrado!");
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    gridEstoque.DataSource = null; // Limpa o DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }
    }
}
