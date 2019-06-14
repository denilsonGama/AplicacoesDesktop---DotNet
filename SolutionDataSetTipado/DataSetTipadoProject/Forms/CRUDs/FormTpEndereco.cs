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
    public partial class FormTpEndereco : Form
    {
        public FormTpEndereco()
        {
            InitializeComponent();
        }

        private void tP_ENDERECOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tp_EnderecoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void tp_EnderecoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tp_EnderecoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
            }
            catch (Exception)
            {

                MessageBox.Show("Algo saiu errado! Verifique os dados digitados e tente novamente", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void FormTpEndereco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Tp_Endereco'. Você pode movê-la ou removê-la conforme necessário.
            this.tp_EnderecoTableAdapter.Fill(this.dSEstadosECidades.Tp_Endereco);

        }
    }
}
