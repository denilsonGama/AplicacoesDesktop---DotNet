﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormDataSetTest : Form
    {
        private DataSet dsEstadosCidades;

        public FormDataSetTest()
        {
            InitializeComponent();
        }

        private DataSet InitializeDataSet()
        {   
            //Cria-se as tabelas
            DataTable dtEstados = new DataTable("Estados");
            dtEstados.Columns.Add("id");
            dtEstados.Columns.Add("uf");
            dtEstados.Columns.Add("nome");

            DataTable dtCidades = new DataTable("Cidades");
            dtCidades.Columns.Add("id");
            dtCidades.Columns.Add("idestado");
            dtCidades.Columns.Add("nome");

            //Cria-se o banco
            DataSet dsEstadosCidades = new DataSet("EstadosCidades");
            dsEstadosCidades.Tables.Add(dtEstados);
            dsEstadosCidades.Tables.Add(dtCidades);
            
            //Cria-se os relacionamentos
            DataRelation drCidadeEstado = new DataRelation("CidadesEstados",
                    dtEstados.Columns["id"],
                    dtCidades.Columns["idestado"]);
            dsEstadosCidades.Relations.Add(drCidadeEstado);

            //Retorna um banco criado pra quem chamou initializeDataSet()
            return dsEstadosCidades;
        }

        private void btnCriarDataSet_Click(object sender, EventArgs e)
        {
            dsEstadosCidades = InitializeDataSet();
            MessageBox.Show("DataSet inicializado com sucesso");
        }

        private void btnInserirDados_Click(object sender, EventArgs e)
        {
            DataTable dtEstados = dsEstadosCidades.
            Tables["Estados"];
            dtEstados.Rows.Add(1, "PR", "Paraná");
            dtEstados.Rows.Add(2, "SP", "São Paulo");
            dtEstados.Rows.Add(3, "SC", "Santa Catarina");
            dtEstados.Rows.Add(4, "RJ", "Rio de Janeiro");

            DataTable dtCidades = dsEstadosCidades.
                Tables["Cidades"];
            dtCidades.Rows.Add(1, 1, "Foz do Iguaçu");
            dtCidades.Rows.Add(2, 1, "Medianeira");
            dtCidades.Rows.Add(3, 1, "Curitiba");
            dtCidades.Rows.Add(4, 2, "São Paulo");
            dtCidades.Rows.Add(5, 2, "Ilha Solteira");
            dtCidades.Rows.Add(6, 3, "Florianópolis");
            dtCidades.Rows.Add(7, 2, "São Bernardo do Campo");
            dtCidades.Rows.Add(8, 2, "São Caetano do Sul");
            dtCidades.Rows.Add(9, 4, "Rio de Janeiro");
            dtCidades.Rows.Add(10, 4, "Petropólis");

            MessageBox.Show("Dados inseridos com sucesso.");
        }

        private void btnVisualizarXML_Click(object sender, EventArgs e)
        {
            tcResultados.SelectedTab = tpgXML;
            txtXML.Text = dsEstadosCidades.GetXml();
        }

        private void btnControlesVisuais_Click(object sender, EventArgs e)
        {
            BindingSource bsMaster = new BindingSource();
            BindingSource bsDetails = new BindingSource();

            bsMaster.DataSource = dsEstadosCidades;
            bsMaster.DataMember = "Estados";
            bsDetails.DataSource = bsMaster;
            bsDetails.DataMember = "CidadesEstados";

            tcResultados.SelectedTab = tpgComboEGrid;
            cbxEstados.DataSource = bsMaster;
            cbxEstados.DisplayMember = "nome";
            cbxEstados.ValueMember = "id";
            dgvCidades.DataSource = bsDetails;
        }
    }
}