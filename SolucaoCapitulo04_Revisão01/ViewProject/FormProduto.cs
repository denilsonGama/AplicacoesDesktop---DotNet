using System.Windows.Forms;
using ControllerProject;
using System;
using ModelProject;

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        private ProdutoController controller;
        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var produto = new Produto()
                {
                    Id = (txtID.Text == string.Empty ?
                    Guid.NewGuid() : new Guid(txtID.Text)),
                    Descricao = txtDescricao.Text,
                    PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                    PrecoDeCusto = Convert.ToDouble(txtPrecoCompra.Text),
                    Estoque = Convert.ToDouble(txtQtdEstoque.Text)
                };

                produto = ((txtID.Text == string.Empty) &&
                            (txtDescricao.Text != string.Empty) &&
                            (txtPrecoVenda.Text != string.Empty) &&
                            (txtPrecoCompra.Text != string.Empty) &&
                            (txtQtdEstoque.Text != string.Empty) ?

                          this.controller.Insert(produto) :
                          this.controller.Update(produto));

                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = this.controller.GetAll();
                ClearControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Os campos: Descrição, Preço e Quantidade não podem ser vazios", "Sistema Cadastro");
                ClearControls();
            }
        }

        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtID.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCompra.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtQtdEstoque.Text = string.Empty;
            txtDescricao.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoCompra.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoVenda.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                txtQtdEstoque.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception)
            {
                if (dgvProdutos.DataSource == null)
                    MessageBox.Show("Não foi possivel remover o PRODUTO. Informe o Administrador");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido no GRID", "Sistema Cadastro");
            }
            else
            {
                this.controller.Remove(new Produto()
                {
                    Id = new Guid(txtID.Text)
                }
                );
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = this.controller.GetAll();
                ClearControls();
                MessageBox.Show("Produto removido com sucesso", "Sistema Cadastro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}