namespace Prova2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnEstoque = new Button();
            btnCadFuncio = new Button();
            btnProduto = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(58, 65, 90);
            panelMenu.Controls.Add(btnEstoque);
            panelMenu.Controls.Add(btnCadFuncio);
            panelMenu.Controls.Add(btnProduto);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 512);
            panelMenu.TabIndex = 0;
            // 
            // btnEstoque
            // 
            btnEstoque.Dock = DockStyle.Top;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.ForeColor = SystemColors.ControlLight;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 220);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(220, 60);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "  Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnCadFuncio
            // 
            btnCadFuncio.Dock = DockStyle.Top;
            btnCadFuncio.FlatAppearance.BorderSize = 0;
            btnCadFuncio.FlatStyle = FlatStyle.Flat;
            btnCadFuncio.ForeColor = SystemColors.ControlLight;
            btnCadFuncio.Image = (Image)resources.GetObject("btnCadFuncio.Image");
            btnCadFuncio.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadFuncio.Location = new Point(0, 160);
            btnCadFuncio.Name = "btnCadFuncio";
            btnCadFuncio.Size = new Size(220, 60);
            btnCadFuncio.TabIndex = 2;
            btnCadFuncio.Text = "  Cadastrar Funcionario";
            btnCadFuncio.TextAlign = ContentAlignment.MiddleLeft;
            btnCadFuncio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadFuncio.UseVisualStyleBackColor = true;
            btnCadFuncio.Click += btnCadFuncio_Click;
            // 
            // btnProduto
            // 
            btnProduto.Dock = DockStyle.Top;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.ForeColor = SystemColors.ControlLight;
            btnProduto.Image = (Image)resources.GetObject("btnProduto.Image");
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(0, 100);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(220, 60);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "  Cadastrar Produto";
            btnProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(52, 52, 78);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "MENU DE OPÇÕES";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(137, 167, 177);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(728, 100);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLight;
            lblTitle.Location = new Point(329, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 100);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(728, 412);
            panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 512);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProduto;
        private Button btnEstoque;
        private Button btnCadFuncio;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
    }
}
