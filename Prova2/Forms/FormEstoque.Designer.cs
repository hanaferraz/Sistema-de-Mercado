namespace Prova2.Forms
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtProcurar = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            gridEstoque = new DataGridView();
            btnAumentar = new Guna.UI2.WinForms.Guna2Button();
            btnDiminuir = new Guna.UI2.WinForms.Guna2Button();
            btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)gridEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtProcurar
            // 
            txtProcurar.BorderRadius = 20;
            txtProcurar.CustomizableEdges = customizableEdges1;
            txtProcurar.DefaultText = "";
            txtProcurar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProcurar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProcurar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProcurar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProcurar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProcurar.Font = new Font("Segoe UI", 9F);
            txtProcurar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProcurar.Location = new Point(12, 68);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.PasswordChar = '\0';
            txtProcurar.PlaceholderText = "";
            txtProcurar.SelectedText = "";
            txtProcurar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtProcurar.Size = new Size(776, 36);
            txtProcurar.TabIndex = 0;
            txtProcurar.TextChanged += txtProcurar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 1;
            label1.Text = "Buscar :";
            // 
            // gridEstoque
            // 
            gridEstoque.BackgroundColor = Color.FromArgb(203, 218, 213);
            gridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEstoque.Location = new Point(12, 187);
            gridEstoque.Name = "gridEstoque";
            gridEstoque.Size = new Size(776, 236);
            gridEstoque.TabIndex = 2;
            gridEstoque.CellContentClick += gridEstoque_CellContentClick;
            // 
            // btnAumentar
            // 
            btnAumentar.CustomizableEdges = customizableEdges3;
            btnAumentar.DisabledState.BorderColor = Color.DarkGray;
            btnAumentar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAumentar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAumentar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAumentar.FillColor = Color.FromArgb(52, 52, 78);
            btnAumentar.Font = new Font("Segoe UI", 9F);
            btnAumentar.ForeColor = Color.White;
            btnAumentar.Image = (Image)resources.GetObject("btnAumentar.Image");
            btnAumentar.Location = new Point(116, 147);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAumentar.Size = new Size(87, 34);
            btnAumentar.TabIndex = 3;
            btnAumentar.Text = "Aumentar";
            btnAumentar.Click += btnAumentar_Click;
            // 
            // btnDiminuir
            // 
            btnDiminuir.BackColor = SystemColors.ControlLight;
            btnDiminuir.CustomizableEdges = customizableEdges5;
            btnDiminuir.DisabledState.BorderColor = Color.DarkGray;
            btnDiminuir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDiminuir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDiminuir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDiminuir.FillColor = Color.FromArgb(52, 52, 78);
            btnDiminuir.Font = new Font("Segoe UI", 9F);
            btnDiminuir.ForeColor = Color.White;
            btnDiminuir.Image = (Image)resources.GetObject("btnDiminuir.Image");
            btnDiminuir.Location = new Point(224, 147);
            btnDiminuir.Name = "btnDiminuir";
            btnDiminuir.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDiminuir.Size = new Size(87, 34);
            btnDiminuir.TabIndex = 3;
            btnDiminuir.Text = "Diminuir";
            btnDiminuir.Click += btnDiminuir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.CustomizableEdges = customizableEdges7;
            btnBuscar.DisabledState.BorderColor = Color.DarkGray;
            btnBuscar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscar.FillColor = Color.FromArgb(52, 52, 78);
            btnBuscar.Font = new Font("Segoe UI", 9F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(12, 147);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBuscar.Size = new Size(87, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Procurar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiminuir);
            Controls.Add(btnBuscar);
            Controls.Add(btnAumentar);
            Controls.Add(gridEstoque);
            Controls.Add(label1);
            Controls.Add(txtProcurar);
            Name = "FormEstoque";
            Text = "FormEstoque";
            ((System.ComponentModel.ISupportInitialize)gridEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtProcurar;
        private Label label1;
        private DataGridView gridEstoque;
        private Guna.UI2.WinForms.Guna2Button btnAumentar;
        private Guna.UI2.WinForms.Guna2Button btnDiminuir;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
    }
}