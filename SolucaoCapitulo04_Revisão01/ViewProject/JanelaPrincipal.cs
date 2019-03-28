using System;
using System.Windows.Forms;
using ControllerProject;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        private NotaEntradaController notaEntradaController = new NotaEntradaController();

        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntrada(notaEntradaController, fornecedorController, produtoController).ShowDialog();
        }
    }
}
