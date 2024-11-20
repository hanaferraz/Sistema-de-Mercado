namespace Prova2.Forms
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNomeFunc = new TextBox();
            txtSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bxCargo = new ComboBox();
            btnSalvarFuncionario = new Guna.UI2.WinForms.Guna2Button();
            btnEditarFunc = new Guna.UI2.WinForms.Guna2Button();
            gridFuncionario = new DataGridView();
            NomeFuncinario = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(88, 126);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(207, 23);
            txtNomeFunc.TabIndex = 0;
            txtNomeFunc.TextChanged += txtNomeFunc_TextChanged;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(89, 287);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(207, 23);
            txtSalario.TabIndex = 0;
            txtSalario.TextChanged += txtSalario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 104);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 5;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 179);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 5;
            label2.Text = "Cargo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 265);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 5;
            label3.Text = "Salário :";
            // 
            // bxCargo
            // 
            bxCargo.FormattingEnabled = true;
            bxCargo.Location = new Point(89, 201);
            bxCargo.Name = "bxCargo";
            bxCargo.Size = new Size(206, 23);
            bxCargo.TabIndex = 7;
            bxCargo.SelectedIndexChanged += bxCargo_SelectedIndexChanged;
            // 
            // btnSalvarFuncionario
            // 
            btnSalvarFuncionario.CustomizableEdges = customizableEdges1;
            btnSalvarFuncionario.DisabledState.BorderColor = Color.DarkGray;
            btnSalvarFuncionario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvarFuncionario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvarFuncionario.DisabledState.ForeColor = Color.Transparent;
            btnSalvarFuncionario.FillColor = Color.FromArgb(52, 52, 78);
            btnSalvarFuncionario.Font = new Font("Segoe UI", 9F);
            btnSalvarFuncionario.ForeColor = SystemColors.ControlLight;
            btnSalvarFuncionario.Location = new Point(88, 344);
            btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            btnSalvarFuncionario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvarFuncionario.Size = new Size(91, 33);
            btnSalvarFuncionario.TabIndex = 8;
            btnSalvarFuncionario.Text = "Salvar";
            btnSalvarFuncionario.Click += btnSalvarFuncionario_Click;
            // 
            // btnEditarFunc
            // 
            btnEditarFunc.CustomizableEdges = customizableEdges3;
            btnEditarFunc.DisabledState.BorderColor = Color.DarkGray;
            btnEditarFunc.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarFunc.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarFunc.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarFunc.FillColor = Color.FromArgb(52, 52, 78);
            btnEditarFunc.Font = new Font("Segoe UI", 9F);
            btnEditarFunc.ForeColor = SystemColors.ControlLight;
            btnEditarFunc.Location = new Point(204, 344);
            btnEditarFunc.Name = "btnEditarFunc";
            btnEditarFunc.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditarFunc.Size = new Size(91, 32);
            btnEditarFunc.TabIndex = 8;
            btnEditarFunc.Text = "Editar";
            btnEditarFunc.Click += btnEditarFunc_Click;
            // 
            // gridFuncionario
            // 
            gridFuncionario.BackgroundColor = Color.FromArgb(203, 218, 213);
            gridFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFuncionario.Columns.AddRange(new DataGridViewColumn[] { NomeFuncinario, Cargo, Salario });
            gridFuncionario.GridColor = SystemColors.ControlDark;
            gridFuncionario.Location = new Point(362, 126);
            gridFuncionario.Name = "gridFuncionario";
            gridFuncionario.Size = new Size(340, 184);
            gridFuncionario.TabIndex = 9;
            gridFuncionario.CellContentClick += gridFuncionario_CellContentClick;
            // 
            // NomeFuncinario
            // 
            NomeFuncinario.HeaderText = "Nome";
            NomeFuncinario.Name = "NomeFuncinario";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Salario
            // 
            Salario.HeaderText = "Salário";
            Salario.Name = "Salario";
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridFuncionario);
            Controls.Add(btnEditarFunc);
            Controls.Add(btnSalvarFuncionario);
            Controls.Add(bxCargo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalario);
            Controls.Add(txtNomeFunc);
            Name = "FormFuncionario";
            Text = "FormFuncionario";
            ((System.ComponentModel.ISupportInitialize)gridFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeFunc;
        private TextBox txtSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox bxCargo;
        private Guna.UI2.WinForms.Guna2Button btnSalvarFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnEditarFunc;
        private DataGridView gridFuncionario;
        private DataGridViewTextBoxColumn NomeFuncinario;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
    }
}