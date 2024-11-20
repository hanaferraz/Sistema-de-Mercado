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
            txtProcurar = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            gridEstoque = new DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
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
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(52, 52, 78);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(29, 147);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(87, 34);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Aumentar";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = SystemColors.ControlLight;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(52, 52, 78);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.Location = new Point(122, 147);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(87, 34);
            guna2Button2.TabIndex = 3;
            guna2Button2.Text = "Diminuir";
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}