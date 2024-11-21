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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }
        private void FormVendas_Load(object sender, EventArgs e)
        {
            CarregarProdutos(); // Carrega os produtos na grid quando o formulário é carregado
        }
        private void CarregarProdutos()
        {
            try
            {
                // Consulta SQL para carregar os produtos ativos
                string query = "SELECT Id, Nome, Quantidade, Preco FROM Estoque WHERE Ativo = 1";

                DataTable produtos = Conexao.ExecuteQuery(query);

                gridVendas.Rows.Clear();
                gridVendas.Columns.Clear();

                // Configura as colunas da grid
                gridVendas.Columns.Add("Id", "ID");
                gridVendas.Columns.Add("Nome", "Nome");
                gridVendas.Columns.Add("Quantidade", "Quantidade");
                gridVendas.Columns.Add("Preco", "Preço");

                foreach (DataRow row in produtos.Rows)
                {
                    gridVendas.Rows.Add(
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

        private void BuscarProdutos(string nomeProduto)
        {
            try
            {
                string query = "SELECT Id, Nome, Quantidade, Preco FROM Estoque WHERE Nome LIKE @Nome AND Ativo = 1";
                SqlParameter[] parameters = { new SqlParameter("@Nome", "%" + nomeProduto + "%") };

                DataTable produtos = Conexao.ExecuteQuery(query, parameters);

                gridVendas.Rows.Clear();

                foreach (DataRow row in produtos.Rows)
                {
                    gridVendas.Rows.Add(
                        row["Id"].ToString(),
                        row["Nome"].ToString(),
                        row["Quantidade"].ToString(),
                        Convert.ToDecimal(row["Preco"]).ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
            }
        }
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos(); // Carrega os produtos na grid quando o formulário for carregado
        }
        private void AlterarQuantidade(int incremento)
        {
            try
            {
                // Verifica se há uma linha selecionada na grid
                if (gridVendas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione um produto na grid antes de aumentar ou diminuir a quantidade.");
                    return;
                }

                // Obtém a linha selecionada
                DataGridViewRow row = gridVendas.SelectedRows[0];

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
        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            string nome = txtPesquisarProduto.Text;

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
                    gridVendas.DataSource = resultado;

                    // Preenche os campos de texto com os detalhes do produto encontrado
                    DataRow produto = resultado.Rows[0];
                    txtPesquisarProduto.Text = produto["CodigoBarras"].ToString();
                    

                    MessageBox.Show("Produto encontrado!");
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    gridVendas.DataSource = null; // Limpa o DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }

        private void gridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQtdProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada e uma quantidade válida
            if (gridVendas.SelectedRows.Count == 0 || !int.TryParse(txtQtdProduto.Text, out int quantidadeVendida) || quantidadeVendida <= 0)
            {
                MessageBox.Show("Selecione um produto e insira uma quantidade válida.");
                return;
            }

            // Obtém os dados do produto selecionado na grid
            DataGridViewRow rowSelecionada = gridVendas.SelectedRows[0];
            int produtoId = Convert.ToInt32(rowSelecionada.Cells["Id"].Value); // Obtém o ID do produto
            string produtoNome = rowSelecionada.Cells["Nome"].Value.ToString(); // Nome do produto
            int estoqueAtual = Convert.ToInt32(rowSelecionada.Cells["QuantidadeEmEstoque"].Value); // Quantidade atual em estoque (ajuste aqui)
            decimal precoProduto = Convert.ToDecimal(rowSelecionada.Cells["Preco"].Value.ToString().Replace("R$", "").Trim()); // Preço do produto

            // Verifica se o estoque é suficiente
            if (estoqueAtual < quantidadeVendida)
            {
                MessageBox.Show("Estoque insuficiente para realizar a venda.");
                return;
            }

            try
            {
                // Registrar a venda na tabela Vendas
                string registrarVendaQuery = @"
            INSERT INTO Vendas (Produto, Preco, Quantidade, Data) 
            VALUES (@Produto, @Preco, @Quantidade, @Data)";

                SqlParameter[] registrarParams = {
            new SqlParameter("@Produto", produtoNome),
            new SqlParameter("@Preco", precoProduto),
            new SqlParameter("@Quantidade", quantidadeVendida),
            new SqlParameter("@Data", DateTime.Now)
        };

                Conexao.ExecuteNonQuery(registrarVendaQuery, registrarParams);

                // Atualizar a quantidade no estoque
                string atualizarEstoqueQuery = "UPDATE Produtos SET QuantidadeEmEstoque = QuantidadeEmEstoque - @Quantidade WHERE Id = @Id"; // Ajuste na coluna
                SqlParameter[] atualizarParams = {
            new SqlParameter("@Quantidade", quantidadeVendida),
            new SqlParameter("@Id", produtoId)
        };

                Conexao.ExecuteNonQuery(atualizarEstoqueQuery, atualizarParams);

                // Atualiza a grid para refletir a nova quantidade
                rowSelecionada.Cells["QuantidadeEmEstoque"].Value = estoqueAtual - quantidadeVendida; // Ajuste na coluna

                // Adiciona um registro no relatório de vendas (bxRelatorioVendas)
                decimal totalVenda = precoProduto * quantidadeVendida;
                string relatorio = $"Produto: {produtoNome} | Quantidade: {quantidadeVendida} | Total: {totalVenda:C}";
                bxRelatorioVendas.Items.Add(relatorio);

                MessageBox.Show("Venda realizada e estoque atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar venda: " + ex.Message);
            }
        }
        private void bxRelatorioVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
