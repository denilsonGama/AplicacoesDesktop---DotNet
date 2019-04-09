using ADO_NETProject01;
using DALProject;
using ModelProject;
using System;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormNotasEntradaCRUD : Form {
        private DAL_NotaEntrada dalNotaEntrada = new DAL_NotaEntrada();
        private DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
        private DAL_Produto dalProduto = new DAL_Produto();
        private DAL_ProdutoNotaDeEntrada dalProdutoNotaDeEntrada = new DAL_ProdutoNotaDeEntrada();
        private NotaEntrada notaAtual;
        private ProdutoNotaEntrada produtoAtual;

        public FormNotasEntradaCRUD()
        {
            InitializeComponent();
            InicializaComboBoxs();
            GetAllNotas();
            GetAllProdutos();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach (Fornecedor fornecedor in this.dalFornecedor.GetAllAsIList()) {
                cbxFornecedor.Items.Add(fornecedor);
            }
            foreach (Produto produto in this.dalProduto.GetAllAsIList())
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
            cbxFornecedor.DroppedDown = true;


        }

        private void BtnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }
        
        private void btnGravarNota_Click(object sender, System.EventArgs e)
        {
            dalNotaEntrada.Save(new NotaEntrada()
            {
                Id = string.IsNullOrEmpty(txtIDNotaEntrada.Text) ? (long?)null : Convert.ToInt64(txtIDNotaEntrada.Text),
                Numero = txtNumero.Text,
                DataEmissao = Convert.ToDateTime(dtpEmissao.Value),
                DataEntrada = Convert.ToDateTime(dtpEntrada.Value),
                FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
        }

        private void ClearControls()
        {
            txtIDNotaEntrada.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            GetAllNotas();
            cbxFornecedor.Focus();
            this.notaAtual = null;
        }

        private void GetAllNotas()
        {
            dgvNotasEntrada.DataSource = dalNotaEntrada.GetAllAsDataTable();
        }

        private void GetAllProdutos()
        {
            dgvProdutos.DataSource = dalProdutoNotaDeEntrada.GetAllAsDataTable();
        }

        private void dgvNotasEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.notaAtual = dalNotaEntrada.GetById(Convert.ToInt64(dgvNotasEntrada.Rows[e.RowIndex].Cells[0].Value));
            txtIDNotaEntrada.Text = notaAtual.Id.ToString();
            txtNumero.Text = notaAtual.Numero;
            dtpEmissao.Value = notaAtual.DataEmissao;
            dtpEntrada.Value = notaAtual.DataEntrada;
            cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;

         }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.produtoAtual = dalProdutoNotaDeEntrada.GetById(Convert.ToInt64(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));
            txtIDProduto.Text = produtoAtual.Id.ToString();
            txtCusto.Text = produtoAtual.PrecoCustoCompra.ToString();
            txtQuantidade.Text = produtoAtual.QuantidadeCompra.ToString();
            cbxProduto.SelectedItem = produtoAtual.ProdutoCompra;
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

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá inserção de produtos, no GRID");
            }
            else
            {
                ChangeStatusOfControls(true);
            }
        }

        private void ClearControlsProduto()
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            GetAllProdutos();
            cbxProduto.Focus();
            this.produtoAtual = null;
        }

        private void BtnGravarProduto_Click(object sender, EventArgs e)
        {
            dalProdutoNotaDeEntrada.SaveProduto(notaAtual, new ProdutoNotaEntrada()
            {
                Id = string.IsNullOrEmpty(txtIDProduto.Text) ? (long?)null : Convert.ToInt64(txtIDProduto.Text),
                ProdutoCompra = (Produto)cbxProduto.SelectedItem,
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                QuantidadeCompra = Convert.ToDouble(txtQuantidade.Text)
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControlsProduto();
        }
    }
}
