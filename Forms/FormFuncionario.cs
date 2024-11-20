using System;
using System.Collections.Generic;
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

            // Configuração da ComboBox de Cargo
            bxCargo.DropDownStyle = ComboBoxStyle.DropDownList; // Impede a edição direta da ComboBox
            bxCargo.Items.AddRange(new string[] { "Caixa", "Estoquista", "Gerente" });
            bxCargo.SelectedIndex = 0;

            // Configuração da DataGridView
            gridFuncionario.ColumnCount = 3;
            gridFuncionario.Columns[0].Name = "Nome";
            gridFuncionario.Columns[1].Name = "Cargo";
            gridFuncionario.Columns[2].Name = "Salário";
            gridFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("Insira um valor válido e positivo para o salário.");
                return;
            }

            if (indexSelecionado < 0) // Novo cadastro
            {
                Funcionario funcionario = new Funcionario(nome, cargo, salario);
                funcionarios.Add(funcionario);

                gridFuncionario.Rows.Add(funcionario.Nome, funcionario.Cargo, funcionario.Salario.ToString("C"));
            }
            else // Edição de cadastro existente
            {
                funcionarios[indexSelecionado].Nome = nome;
                funcionarios[indexSelecionado].Cargo = cargo;
                funcionarios[indexSelecionado].Salario = salario;

                var row = gridFuncionario.Rows[indexSelecionado];
                row.Cells[0].Value = nome;
                row.Cells[1].Value = cargo;
                row.Cells[2].Value = salario.ToString("C");

                indexSelecionado = -1;
                btnSalvarFuncionario.Text = "Salvar";
            }

            LimparCampos();
        }

        // Evento de clique para o botão "Editar"
        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            if (gridFuncionario.SelectedRows.Count > 0)
            {
                var selectedRow = gridFuncionario.SelectedRows[0];
                indexSelecionado = selectedRow.Index;

                // Carrega dados selecionados nos campos de entrada
                txtNomeFunc.Text = selectedRow.Cells[0].Value.ToString();
                bxCargo.SelectedItem = selectedRow.Cells[1].Value.ToString();
                txtSalario.Text = selectedRow.Cells[2].Value.ToString().Replace("R$", "").Trim();

                btnSalvarFuncionario.Text = "Atualizar";
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.");
            }
        }

        // Método para limpar os campos após o cadastro/edição
        private void LimparCampos()
        {
            txtNomeFunc.Clear();
            bxCargo.SelectedIndex = 0;
            txtSalario.Clear();
        }

        // Classe Funcionario para armazenar as informações do funcionário
        public class Funcionario
        {
            public string Nome { get; set; }
            public string Cargo { get; set; }
            public decimal Salario { get; set; }

            public Funcionario(string nome, string cargo, decimal salario)
            {
                Nome = nome;
                Cargo = cargo;
                Salario = salario;
            }
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
    }
}
