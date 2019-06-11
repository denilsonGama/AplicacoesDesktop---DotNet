﻿using System;
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
    public partial class FormCidades : Form
    {
        public FormCidades()
        {
            InitializeComponent();
        }

        private void cidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            if (MessageBox.Show("Deseja salvar as alterações?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.cidadesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);
                MessageBox.Show("Alterações registradas com sucesso", "DataSetTipado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Close();
            }
         }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.FillByNome (this.dSEstadosECidades.Estados);
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.FillByNomeUF(this.dSEstadosECidades.Cidades);

        }
    }
}
