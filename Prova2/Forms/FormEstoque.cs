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
                // Consulta SQL para buscar todos os produtos ativos
                string query = "SELECT Id, Nome, Quantidade, Preco FROM Estoque WHERE Ativo = 1";

                // Executa a consulta e retorna os resultados
                DataTable dtProdutos = Conexao.ExecuteQuery(query);

                // Limpa a grid antes de recarregar
                gridEstoque.Rows.Clear();
                gridEstoque.Columns.Clear();

                // Configura as colunas da grid (usando nomes internos específicos)
                gridEstoque.Columns.Add("Id", "ID"); // Nome interno: "Id"
                gridEstoque.Columns.Add("Nome", "Nome"); // Nome interno: "Nome"
                gridEstoque.Columns.Add("Quantidade", "Quantidade"); // Nome interno: "Quantidade"
                gridEstoque.Columns.Add("Preco", "Preço"); // Nome interno: "Preco"

                // Preenche a grid com os dados do banco
                foreach (DataRow row in dtProdutos.Rows)
                {
                    gridEstoque.Rows.Add(
                        row["Id"].ToString(),
                        row["Nome"].ToString(),
                        row["Quantidade"].ToString(),
                        Convert.ToDecimal(row["Preco"]).ToString("C")
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
            AlterarQuantidade(1); // Aumenta a quantidade em 1
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            AlterarQuantidade(-1); // Diminui a quantidade em 1
        }
        private void AlterarQuantidade(int incremento)
        {
            try
            {
                // Verifica se há uma linha selecionada na grid
                if (gridEstoque.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione um produto na grid antes de aumentar ou diminuir a quantidade.");
                    return;
                }

                // Obtém a linha selecionada
                DataGridViewRow row = gridEstoque.SelectedRows[0];

                // Obtém o ID do produto
                if (!int.TryParse(row.Cells["Id"].Value?.ToString(), out int produtoId))
                {
                    MessageBox.Show("Erro: o ID do produto não é válido.");
                    return;
                }

                // Obtém a quantidade atual
                if (!int.TryParse(row.Cells["QuantidadeEmEstoque"].Value?.ToString(), out int quantidadeAtual))
                {
                    MessageBox.Show("Erro: a quantidade atual não é válida.");
                    return;
                }

                // Calcula a nova quantidade
                int novaQuantidade = quantidadeAtual + incremento;

                // Verifica se a nova quantidade é válida
                if (novaQuantidade < 0)
                {
                    MessageBox.Show("A quantidade não pode ser negativa.");
                    return;
                }

                // Atualiza no banco de dados
                string query = "UPDATE Produtos SET QuantidadeEmEstoque = @QuantidadeEmEstoque WHERE Id = @Id";
                SqlParameter[] parameters = {
            new SqlParameter("@QuantidadeEmEstoque", SqlDbType.Int) { Value = novaQuantidade },
            new SqlParameter("@Id", SqlDbType.Int) { Value = produtoId }
        };

                Conexao.ExecuteNonQuery(query, parameters);

                // Atualiza a célula da grid
                row.Cells["QuantidadeEmEstoque"].Value = novaQuantidade;

                MessageBox.Show("Quantidade atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a quantidade: " + ex.Message);
            }
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
