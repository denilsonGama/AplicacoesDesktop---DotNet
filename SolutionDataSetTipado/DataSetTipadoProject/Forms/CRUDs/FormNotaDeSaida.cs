using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetTipadoProject.Forms.CRUDs
{
    public partial class FormNotaDeSaida : Form
    {
        public FormNotaDeSaida()
        {
            InitializeComponent();
        }

        private void notasDeVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasDeVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormNotaDeSaida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.ProdutosNotaDeEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosNotaDeEntradaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeEntrada);

            this.produtosTableAdapter.FillByDescricao(this.dSEstadosECidades.Produtos);
            this.produtosNotaDeSaidaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeSaida);
            this.clientesTableAdapter.FillByNome(this.dSEstadosECidades.Clientes);
            this.notasDeVendaTableAdapter.Fill(this.dSEstadosECidades.NotasDeVenda);

            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.DescricaoColumn.ColumnName;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.IdProdutoColumn.ColumnName;

        }
    }
}
