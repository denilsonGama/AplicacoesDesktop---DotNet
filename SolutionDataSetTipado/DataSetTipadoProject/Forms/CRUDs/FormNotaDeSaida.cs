using DataSetTipadoProject.DataSets;
using DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataSetTipadoProject.Forms.CRUDs
{
    public partial class FormNotaDeSaida : Form {
        private bool adding, editing;
        public FormNotaDeSaida()
        {
            InitializeComponent();
            adding = false;
            editing = false;
            VisualizarNotaDeVenda();
            
            
        }

        private void Salvar()
        {
            this.Validate();
            this.notasDeVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
            dgvProdutos.Refresh();


        }

        private void Cancelar()
        {
            this.Validate();
            this.notasDeVendaBindingSource.CancelEdit();
            VisualizarNotaDeVenda();            
            adding = false;
            editing = false;                      
        }
               
        private void bnbFecharNota_Click(object sender, EventArgs e)
        {
            //BaixarNota: Chama o metodo que baixa o estoque e fecha a nota
            BaixarNota();
            
        }
        private void BaixarNota()
        {

            try
            {
                DialogResult SaveBaixaNota = new DialogResult();
                SaveBaixaNota = MessageBox.Show("Deseja fechar esta nota?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (SaveBaixaNota == DialogResult.Yes)
                {

                    //MessageBox.Show("Nota fechada com sucesso!", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BaixarEstoque();
                    //FecharNota();

                }
                else if (SaveBaixaNota == DialogResult.No) ;
                Cancelar();
            }

            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Não foi possivel fazer a leitura do BD!", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void BaixarEstoque()
        {           
            this.produtosTableAdapter.ProdutosAtualiza(decimal.Parse(QuantidadeTextBox.ToString()), long.Parse(IdProduto.ToString()));
        }
        private void FecharNota()
        {            
             this.notasDeVendaTableAdapter.FechaNota(long.Parse(IdNotaDeVenda.Text));           
        }     
        
            private void VisualizarNotaDeVenda()
        {
            try
            {
                this.produtosNotaDeSaidaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeSaida);
                this.clientesTableAdapter.FillByNome(this.dSEstadosECidades.Clientes);
                this.notasDeVendaTableAdapter.Fill(this.dSEstadosECidades.NotasDeVenda);
                this.produtosTableAdapter.FillByDescricao(this.dSEstadosECidades.Produtos);

                ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
                ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.DescricaoColumn.ColumnName;
                ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.IdProdutoColumn.ColumnName;

                if (notasDeVendaBindingSource.Current == null)
                {
                    SetBindingNavigatorButtonsState();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Não foi possivel fazer a leitura do BD!", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
           

        private void notasDeVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult SaveNotasDeVenda = new DialogResult();
                SaveNotasDeVenda = MessageBox.Show("Deseja Cadastrar/Editar esta nota?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (SaveNotasDeVenda == DialogResult.Yes)
                {

                Salvar();
                adding = false;
                editing = false;
                SetBindingNavigatorButtonsState();
                
                }
                else if (SaveNotasDeVenda == DialogResult.No);
                Cancelar();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bnbEdit_Click(object sender, EventArgs e) {
            editing = true;
            SetBindingNavigatorButtonsState();
        }

        private void bnbAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            SetBindingNavigatorButtonsState();
            lblIdNotaFechada.Text = "N"; //Alternativa para inserção automatica no bd
        }

        private void bnbRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DeleteRemove = new DialogResult();
                DeleteRemove = MessageBox.Show("Deseja Excluir esta nota?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DeleteRemove == DialogResult.Yes)
                {

                    MessageBox.Show("Nota Excluida com Sucesso!", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    adding = false;
                    editing = false;
                    Salvar();
                    SetBindingNavigatorButtonsState();

                }
                else if (DeleteRemove == DialogResult.No);
                Cancelar();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        
        private void notasDeVendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)
            notasDeVendaBindingSource.Current;
            if (drv != null)
            {
                DataRow dr = drv.Row;
                if (drv != null && !(dr.RowState == DataRowState.Detached))
                {
                    SetBindingNavigatorButtonsState();
                }
            }
        }

        private void SetBindingNavigatorButtonsState()
        {
            bool podeFecharNota = false;
            if (notasDeVendaBindingSource.Current != null)
            {

                DataRowView drv = (DataRowView)notasDeVendaBindingSource.Current;
                DSEstadosECidades.NotasDeVendaRow nvRow = (DSEstadosECidades.NotasDeVendaRow)drv.Row;
                podeFecharNota = nvRow.NotaFechada.Equals("N");
            }

            bnbFirst.Enabled = !adding && !editing;
            bnbPrior.Enabled = bnbFirst.Enabled;
            bindingNavigatorCountItem.Enabled = bnbFirst.Enabled;
            bnbNext.Enabled = bnbFirst.Enabled;
            bnbLast.Enabled = bnbFirst.Enabled;

            bnbAdd.Enabled = bnbFirst.Enabled;
            bnbEdit.Enabled = bnbFirst.Enabled && podeFecharNota;
            bnbRemove.Enabled = !editing && podeFecharNota;
            bnbSave.Enabled = adding || editing;
            bnbFecharNota.Enabled = podeFecharNota && (!adding && !editing);
            
            gbxDadosDaNota.Enabled = adding || editing;
            gbxProdutosDaNota.Enabled = editing;
        }

        
    }
}

