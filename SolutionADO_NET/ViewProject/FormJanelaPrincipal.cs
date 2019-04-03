using ADO_NETProject01;
using System;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedoresCRUD().ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProdutosCRUD().ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotasEntradaCRUD().ShowDialog();
        }
    }
}