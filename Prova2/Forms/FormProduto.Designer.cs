namespace Prova2.Forms
{
    partial class FormProduto
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gridProduto = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProduto).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 4;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 137);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 4;
            label2.Text = "Preço :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 202);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 4;
            label3.Text = "Quantidade :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 270);
            label4.Name = "label4";
            label4.Size = new Size(122, 19);
            label4.TabIndex = 4;
            label4.Text = "Código de barras :";
            // 
            // gridProduto
            // 
            gridProduto.BackgroundColor = Color.FromArgb(203, 218, 213);
            gridProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProduto.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            gridProduto.Location = new Point(346, 96);
            gridProduto.Name = "gridProduto";
            gridProduto.Size = new Size(442, 219);
            gridProduto.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Preço";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantidade";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Código de Barras";
            Column4.Name = "Column4";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(52, 52, 78);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = SystemColors.ControlLight;
            btnSalvar.Location = new Point(106, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(gridProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormProduto";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)gridProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView gridProduto;
        private Button btnSalvar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}