using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prova2.Forms
{
    public partial class FormFuncionario : Form
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private int indexSelecionado = -1; // Índice do funcionário selecionado para edição

        public FormFuncionario()
        {
            InitializeComponent();

            bxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            bxCargo.Items.AddRange(new string[] { "Caixa", "Estoquista", "Gerente" });
            bxCargo.SelectedIndex = 0;

            gridFuncionario.ColumnCount = 3;
            gridFuncionario.Columns[0].Name = "Nome";
            gridFuncionario.Columns[1].Name = "Cargo";
            gridFuncionario.Columns[2].Name = "Salário";
            gridFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Inicializa o botão Editar como desabilitado
            btnEditarFunc.Enabled = false;

            // Carregar os funcionários do banco ao abrir o formulário
            CarregarFuncionarios();
        }

        // Método para carregar os funcionários do banco de dados na DataGridView
        private void CarregarFuncionarios()
        {
            try
            {
                // Consulta SQL para buscar todos os funcionários
                string query = "SELECT Nome, Cargo, Salario FROM Funcionarios";

                // Executando a consulta e obtendo os resultados
                DataTable dtFuncionarios = Conexao.ExecuteQuery(query);

                // Limpando os dados antigos na grid
                gridFuncionario.Rows.Clear();

                // Preenchendo a gridFuncionario com os dados dos funcionários
                foreach (DataRow row in dtFuncionarios.Rows)
                {
                    gridFuncionario.Rows.Add(
                        row["Nome"].ToString(),
                        row["Cargo"].ToString(),
                        Convert.ToDecimal(row["Salario"]).ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }


        // Evento de clique para o botão "Salvar"
        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFunc.Text.Trim();
            string cargo = bxCargo.SelectedItem.ToString();
            decimal salario;

            // Validação do nome
            if (string.IsNullOrEmpty(nome) || !Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("O nome do funcionário deve conter apenas letras e não pode estar vazio.");
                return;
            }

            // Validação do salário
            string salarioTexto = txtSalario.Text.Trim();
            salarioTexto = salarioTexto.Replace("R$", "").Replace(" ", "").Replace(",", ".");

            if (!decimal.TryParse(salarioTexto, out salario) || salario < 0)
            {
                MessageBox.Show("Insira um valor válido e positivo para o salário.");
                return;
            }

            if (indexSelecionado < 0) // Novo cadastro
            {
                // Salvar no banco de dados
                string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Nome", nome),
                    new SqlParameter("@Cargo", cargo),
                    new SqlParameter("@Salario", salario)
                };

                // Executar a consulta
                Conexao.ExecuteNonQuery(query, parameters);

                // Atualizar a DataGridView
                gridFuncionario.Rows.Add(nome, cargo, salario.ToString("C"));
            }
            else // Edição de cadastro existente
            {
                // Atualizar no banco de dados
                string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                SqlParameter[] parameters = new SqlParameter[] {
                       new SqlParameter("@Nome", SqlDbType.NVarChar) { Value = nome },
                       new SqlParameter("@Cargo", SqlDbType.NVarChar) { Value = cargo },
                       new SqlParameter("@Salario", SqlDbType.Decimal) { Value = salario }
};
                Conexao.ExecuteNonQuery(query, parameters);

                // Atualizar a DataGridView
                var row = gridFuncionario.Rows[indexSelecionado];
                row.Cells[0].Value = nome;
                row.Cells[1].Value = cargo;
                row.Cells[2].Value = salario.ToString("C");

                indexSelecionado = -1;
                btnSalvarFuncionario.Text = "Salvar";
            }
        }

        // Evento de clique para o botão "Editar"
        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            // Verifica se um funcionário foi selecionado na DataGridView
            if (indexSelecionado < 0) // Se o índice do funcionário selecionado for inválido
            {
                MessageBox.Show("Por favor, selecione um funcionário na grid antes de editar.");
                return;
            }

            // Obtém os dados do funcionário selecionado na DataGridView
            string nome = gridFuncionario.Rows[indexSelecionado].Cells[0].Value.ToString();
            string cargo = gridFuncionario.Rows[indexSelecionado].Cells[1].Value.ToString();
            string salario = gridFuncionario.Rows[indexSelecionado].Cells[2].Value.ToString();

            // Preenche os campos de edição com os dados do funcionário selecionado
            txtNomeFunc.Text = nome;
            bxCargo.SelectedItem = cargo;
            txtSalario.Text = salario.Replace("R$", "").Trim();  // Remover o símbolo "R$" para permitir edição

            // Alterar o texto do botão de salvar para "Salvar Alterações"
            btnSalvarFuncionario.Text = "Salvar Alterações";
        }

        // Método para bloquear a tecla "Espaço" no campo de nome
        private void txtNomeFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && string.IsNullOrWhiteSpace(txtNomeFunc.Text))
            {
                e.Handled = true;
                MessageBox.Show("O nome do funcionário não pode começar com espaço.");
            }
        }

        // Método para bloquear a tecla "Espaço" no campo de salário
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Espaços não são permitidos no campo de salário.");
            }
        }

        // Manipuladores de evento vazios para os TextBoxes e ComboBox, caso deseje implementar lógica adicional
        private void txtNomeFunc_TextChanged(object sender, EventArgs e) { }
        private void bxCargo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtSalario_TextChanged(object sender, EventArgs e) { }

        private void gridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Verifica se o clique foi em uma linha (não no cabeçalho)
                if (e.RowIndex >= 0)
                {
                    // Atualiza o índice do funcionário selecionado
                    indexSelecionado = e.RowIndex;

                    // Habilita o botão de editar quando uma linha é selecionada
                    btnEditarFunc.Enabled = true;
                }
            }
        }
    }
}
