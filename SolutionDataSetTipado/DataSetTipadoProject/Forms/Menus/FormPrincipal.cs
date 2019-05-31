using DataSetTipadoProject.Forms.CRUDs;
using System;
using System.Windows.Forms;

namespace DataSetTipadoProject.Forms.Menus
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEstados().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCidades().ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedores().ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGrupos().ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProdutos().ShowDialog();
        }
    }
}
