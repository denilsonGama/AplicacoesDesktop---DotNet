using System.Windows.Forms;
using ControllerProject;
using ModelProject;
using System;

namespace ViewProject
{
    public partial class FormNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private NotaEntrada notaAtual;
        public FormNotaEntrada(NotaEntradaController controller, FornecedorController fornecedorController, ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializaComboBoxs();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();
            foreach (Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }
            foreach (Produto produto in this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto);
            }
        }

        private void btnNovoNota_Click(object sender, System.EventArgs e)
        {
            ClearControlsNota();
        }
        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();
        }

        private void btnGravarNota_Click(object sender, System.EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIDNotaEntrada.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDNotaEntrada.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };

            notaEntrada = (txtIDNotaEntrada.Text == string.Empty ? this.controller.Insert(notaEntrada) : this.controller.Update(notaEntrada));
            dgvNotasEntrada.DataSource = null;
            dgvNotasEntrada.DataSource = this.controller.GetAll();
            ClearControlsNota();
        }

        private void BtnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void BtnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA a ser removida no GRID"
                );
            }
            else
            {
                this.controller.Remove(new NotaEntrada()
                {
                    Id = new Guid(txtIDNotaEntrada.Text)
                }
                );
                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource = this.controller.GetAll();
                ClearControlsNota();
            }
        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaEntradaById((Guid)dgvNotasEntrada.CurrentRow.Cells[0].Value);
                 txtIDNotaEntrada.Text = notaAtual.Id.ToString();
                txtNumero.Text = notaAtual.Numero;
                cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch (Exception)
            {

                this.notaAtual = new NotaEntrada();
            }
        }

        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.Produtos;
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá " +
                    "inserção de produtos, no GRID");
            }
            else
            {
                ChangeStatusOfControls(true);
            }
        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cbxProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtQuantidade.Enabled = newStatus;
            btnNovoProduto.Enabled = !newStatus;
            btnGravarProduto.Enabled = newStatus;
            btnCancelarProduto.Enabled = newStatus;
            btnRemoverProduto.Enabled = newStatus;
        }

        private void BtnGravarProduto_Click(object sender, EventArgs e)
        {
            var produtoNota = new ProdutoNotaEntrada()
            {
                Id = (txtIDProduto.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDProduto.Text)),
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                ProdutoNota = (Produto)cbxProduto.SelectedItem,
                QuantidadeComprada = Convert.ToDouble(txtQuantidade.Text)
            };
            this.notaAtual.RegistrarProduto(produtoNota);
            this.notaAtual = this.controller.Update(this.notaAtual);
            ChangeStatusOfControls(false);
            UpdateProdutosGrid();
            ClearControlsProduto();
        }

        private void BtnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            this.notaAtual.RemoverProduto(new ProdutoNotaEntrada()
            {
                Id = new Guid(txtIDProduto.Text)
            }
            );
            this.controller.Update(this.notaAtual);
            UpdateProdutosGrid();
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void ClearControlsProduto()
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbxProduto.Focus();
        }

    }
}