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

        

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProdutos().ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormClientes().ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult close = new DialogResult();
            close = MessageBox.Show("Deseja sair do sistema?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (close == DialogResult.Yes)
                
            {
                e.Cancel = false;
                MessageBox.Show("Obrigado por utilizar nossos serviços", "DataSetTipado" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (close == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void estadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormNotaDeEntrada().ShowDialog();
        }

        private void endereçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormTpEndereco().ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormGrupos().ShowDialog();
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormNotaDeSaida().ShowDialog();
        }
    }
}
