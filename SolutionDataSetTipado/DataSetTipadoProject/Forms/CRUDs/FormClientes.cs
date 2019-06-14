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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            this.gpxEndereco.Visible = false;
            this.clientesBindingNavigatorSaveItem.Visible = true;
            this.clientesBindingNavigatorSaveEndereco.Visible = false;
        }

        private void Salvar()
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.ClientesTableAdapterManager.UpdateAll(this.dSEstadosECidades);
        }
        private void clientesBindingNavigatorVisualizarEndereco_Click(object sender, EventArgs e)
        {
            this.gpxEndereco.Visible = true;
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult SaveCliente = new DialogResult();
                SaveCliente = MessageBox.Show("Deseja Cadastrar/Editar Endereço?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (SaveCliente == DialogResult.Yes)
                {


                    Salvar();
                    this.gpxEndereco.Visible = true;
                    this.clientesBindingNavigatorSaveItem.Visible = false;
                    this.clientesBindingNavigatorSaveEndereco.Visible = true;

                }
                else if (SaveCliente == DialogResult.No);

                }

            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void clientesBindingNavigatorSaveEndereco_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult SaveEndereco = new DialogResult();
                SaveEndereco = MessageBox.Show("Deseja salvar os dados de endereço?", "DataSetTipado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (SaveEndereco == DialogResult.Yes)
                {


                    Salvar();
                    MessageBox.Show("Dados salvos com sucesso", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (SaveEndereco == DialogResult.No);
            }

            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void FormClientes_Load(object sender, EventArgs e)
        {

            try
            {
                this.cidadesTableAdapter.FillByNomeUF(this.dSEstadosECidades.Cidades);
                this.tp_EnderecoTableAdapter.FillByTipo(this.dSEstadosECidades.Tp_Endereco);
                this.enderecosTableAdapter.Fill(this.dSEstadosECidades.Enderecos);
                this.clientesTableAdapter.Fill(this.dSEstadosECidades.Clientes);

                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).DataSource = this.dSEstadosECidades.Enderecos;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).DisplayMember = this.dSEstadosECidades.Enderecos.NmEnderecoColumn.ColumnName;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).ValueMember = this.dSEstadosECidades.Enderecos.IdEnderecoColumn.ColumnName;

                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).DataSource = this.dSEstadosECidades.Cidades;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).DisplayMember = this.dSEstadosECidades.Cidades.NomeColumn.ColumnName;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[0]).ValueMember = this.dSEstadosECidades.Cidades.IdCidadeColumn.ColumnName;

                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[5]).DataSource = this.dSEstadosECidades.Tp_Endereco;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[5]).DisplayMember = this.dSEstadosECidades.Tp_Endereco.TipoColumn.ColumnName;
                ((DataGridViewComboBoxColumn)dgvEndereco.Columns[5]).ValueMember = this.dSEstadosECidades.Tp_Endereco.IdTpEnderecoColumn.ColumnName;
            }
            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }
    }
}


