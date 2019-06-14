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
    public partial class FormNotaDeEntrada : Form
    {
        public FormNotaDeEntrada()
        {
            InitializeComponent();
        }


        private void notasDeEntradaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.notasDeEntradaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              
            }

        }

        private void FormNotaDeEntrada_Load(object sender, EventArgs e)
        {
           

            this.produtosTableAdapter.FillByDescricao(this.dSEstadosECidades.Produtos);
            this.produtosNotaDeEntradaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeEntrada);
            this.fornecedoresTableAdapter.FillByNome(this.dSEstadosECidades.Fornecedores);
            this.notasDeEntradaTableAdapter.Fill(this.dSEstadosECidades.NotasDeEntrada);

            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.DescricaoColumn.ColumnName;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.IdProdutoColumn.ColumnName;


        }
    }
}
