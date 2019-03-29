using ADO_NETProject01;
using DALProject;
using ModelProject;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormProdutosCRUD : Form
    {
        private Produto produtoAtual;
        private DAL_Produto dal = new DAL_Produto();
        public FormProdutosCRUD()
        {
            InitializeComponent();
            GetAllProdutos();
        }

        private void ClearControls()
        {
            txtID.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCompra.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtQtdEstoque.Text = string.Empty;
            GetAllProdutos();
            dgvProdutos.ClearSelection();
            this.produtoAtual = null;
            txtDescricao.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void GetAllProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var adapter = new SqlDataAdapter("select id, descricao, precodecusto, precodevenda, estoque from PRODUTOS", connectionString);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);
            dgvProdutos.DataSource = table;
            connection.Close();
        }

        private Produto GetProdutoById(long id)
        {
            Produto produto = new Produto();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("select id, descricao, precodecusto, precodevenda, estoque from PRODUTOS where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.Id = Convert.ToInt32(reader[0]); //Alterado. Original: reader.GetInt32(0)
                    produto.Descricao = reader.GetString(1);
                    produto.PrecoDeCusto = Convert.ToDouble(reader[2]);
                    produto.PrecoDeVenda = Convert.ToDouble(reader[3]);
                    produto.Estoque = Convert.ToDouble(reader[4]);

                }
            }
            connection.Close();
            return produto;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Produto()
            {
                Id = string.IsNullOrEmpty(txtID.Text) ? (long?)null : Convert.ToInt64(txtID.Text),
                Descricao = txtDescricao.Text,
                PrecoDeCusto = Convert.ToDouble(txtPrecoCompra.Text),
                PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                Estoque = Convert.ToDouble(txtQtdEstoque.Text)
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido no GRID");
            }
            else
            {
                this.dal.RemoveById(this.produtoAtual.Id);
                ClearControls();
                MessageBox.Show("Produto removido com sucesso");
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.produtoAtual = GetProdutoById(Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));
            txtID.Text = this.produtoAtual.Id.ToString();
            txtDescricao.Text = this.produtoAtual.Descricao;
            txtPrecoCompra.Text = this.produtoAtual.PrecoDeCusto.ToString();
            txtPrecoVenda.Text = this.produtoAtual.PrecoDeVenda.ToString();
            txtQtdEstoque.Text = this.produtoAtual.Estoque.ToString();

        }



    }
}