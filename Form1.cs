using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;


        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduto(), sender);
        }

        private void btnCadFuncio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuncionario(), sender);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEstoque(), sender);
        }
    }
}
