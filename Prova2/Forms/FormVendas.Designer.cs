namespace Prova2.Forms
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            bxRelatorioVendas = new ListBox();
            label1 = new Label();
            txtPesquisarProduto = new TextBox();
            gridVendas = new DataGridView();
            lblQuantidadeCompra = new Label();
            txtQtdProduto = new TextBox();
            btnComprar = new Button();
            btnProcurar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVendas).BeginInit();
            SuspendLayout();
            // 
            // bxRelatorioVendas
            // 
            bxRelatorioVendas.BackColor = Color.FromArgb(137, 167, 177);
            bxRelatorioVendas.FormattingEnabled = true;
            bxRelatorioVendas.ItemHeight = 15;
            bxRelatorioVendas.Location = new Point(508, 60);
            bxRelatorioVendas.Name = "bxRelatorioVendas";
            bxRelatorioVendas.Size = new Size(297, 259);
            bxRelatorioVendas.TabIndex = 0;
            bxRelatorioVendas.SelectedIndexChanged += bxRelatorioVendas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 48);
            label1.Name = "label1";
            label1.Size = new Size(282, 26);
            label1.TabIndex = 1;
            label1.Text = "Qual Produto Deseja Comprar ?";
            // 
            // txtPesquisarProduto
            // 
            txtPesquisarProduto.Location = new Point(77, 102);
            txtPesquisarProduto.Name = "txtPesquisarProduto";
            txtPesquisarProduto.Size = new Size(303, 23);
            txtPesquisarProduto.TabIndex = 2;
            txtPesquisarProduto.TextChanged += txtPesquisarProduto_TextChanged;
            // 
            // gridVendas
            // 
            gridVendas.BackgroundColor = Color.FromArgb(137, 167, 177);
            gridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVendas.Location = new Point(77, 140);
            gridVendas.Name = "gridVendas";
            gridVendas.Size = new Size(408, 116);
            gridVendas.TabIndex = 3;
            gridVendas.CellContentClick += gridVendas_CellContentClick;
            // 
            // lblQuantidadeCompra
            // 
            lblQuantidadeCompra.AutoSize = true;
            lblQuantidadeCompra.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidadeCompra.Location = new Point(77, 277);
            lblQuantidadeCompra.Name = "lblQuantidadeCompra";
            lblQuantidadeCompra.Size = new Size(224, 26);
            lblQuantidadeCompra.TabIndex = 4;
            lblQuantidadeCompra.Text = "Selecione a Quantidade :";
            // 
            // txtQtdProduto
            // 
            txtQtdProduto.Location = new Point(77, 318);
            txtQtdProduto.Name = "txtQtdProduto";
            txtQtdProduto.Size = new Size(303, 23);
            txtQtdProduto.TabIndex = 5;
            txtQtdProduto.TextChanged += txtQtdProduto_TextChanged;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(52, 52, 78);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = SystemColors.ControlLightLight;
            btnComprar.Location = new Point(227, 366);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(118, 38);
            btnComprar.TabIndex = 6;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.FromArgb(52, 52, 78);
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.FlatStyle = FlatStyle.Flat;
            btnProcurar.ForeColor = SystemColors.Window;
            btnProcurar.Image = (Image)resources.GetObject("btnProcurar.Image");
            btnProcurar.Location = new Point(410, 95);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(40, 34);
            btnProcurar.TabIndex = 7;
            btnProcurar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcurar);
            Controls.Add(btnComprar);
            Controls.Add(txtQtdProduto);
            Controls.Add(lblQuantidadeCompra);
            Controls.Add(gridVendas);
            Controls.Add(txtPesquisarProduto);
            Controls.Add(label1);
            Controls.Add(bxRelatorioVendas);
            Name = "FormVendas";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)gridVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox bxRelatorioVendas;
        private Label label1;
        private TextBox txtPesquisarProduto;
        private DataGridView gridVendas;
        private Label lblQuantidadeCompra;
        private TextBox txtQtdProduto;
        private Button btnComprar;
        private Button btnProcurar;
    }
}