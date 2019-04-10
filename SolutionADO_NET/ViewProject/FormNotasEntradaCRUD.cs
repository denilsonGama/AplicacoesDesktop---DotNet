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
            cbxFornecedor.DroppedDown = true;
        }

        private void ClearControlsNota()
        {
            txtIDNotaEntrada.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            GetAllNotas();
            GetAllProdutos();
            this.notaAtual = null;
            
            
        }

        private void BtnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void BtnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
        }

        private void btnGravarNota_Click(object sender, System.EventArgs e)
        {
            try
            {
                dalNotaEntrada.SaveNotaDeEntrada(new NotaEntrada()
                {
                    Id = string.IsNullOrEmpty(txtIDNotaEntrada.Text) ? (long?)null : Convert.ToInt64(txtIDNotaEntrada.Text),
                    Numero = txtNumero.Text,
                    DataEmissao = Convert.ToDateTime(dtpEmissao.Value),
                    DataEntrada = Convert.ToDateTime(dtpEntrada.Value),
                    FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem
                });
                MessageBox.Show("Manutenção realizada com sucesso");


                DialogResult result = MessageBox.Show("Deseja inserir Produtos nesta Nota?", "Atenção!",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    novoProduto();
                }

                else this.Close();
            }
            catch
            {
                MessageBox.Show("Selecione o Item que será atualizado no GRID");
            }
        }

        private void BtnRemoverNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDNotaEntrada.Text == string.Empty)
                {
                    MessageBox.Show("Selecione a NOTA a ser removido no GRID");
                }

                else
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja Excluir esta Nota?", "Atenção!",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        this.dalNotaEntrada.RemoveById(this.notaAtual.Id);
                        ClearControlsNota();
                        MessageBox.Show("Nota removida com sucesso");
                        GetAllNotas();
                        GetAllProdutos();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel executar a operação. Tente novamente");
                this.Close();
            }
        }
        
        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDProduto.Text == string.Empty)
                {
                    MessageBox.Show("Selecione o PRODUTO a ser removido no GRID");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja Excluir este produto?", "Atenção!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        this.dalProdutoNotaDeEntrada.RemoveById(this.produtoAtual.Id);
                        ClearControlsProduto();
                        MessageBox.Show("Produto removido com sucesso");
                        GetAllProdutos();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel executar a operação. Tente novamente");
                this.Close();
            }
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
            ChangeStatusOfControlsProduto(true);
        }

        private void ChangeStatusOfControlsProduto(bool newStatus)
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
            novoProduto();
        }

        
        private void novoProduto()
        {
            ClearControlsProduto();
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá inserção de produtos, no GRID");
            }
            else
            {
                ChangeStatusOfControlsProduto(true);
                cbxProduto.DroppedDown = true;
            }
        }


        private void ClearControlsProduto()
        {
            txtIDProduto.Text = string.Empty;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            dgvProdutos.ClearSelection();
            GetAllProdutos();
            this.produtoAtual = null;
        }

        private void BtnGravarProduto_Click(object sender, EventArgs e) {

            try
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
            catch
            {
                MessageBox.Show("Selecione o Item que será atualizado no GRID");
            }
        }
           
    }
}
