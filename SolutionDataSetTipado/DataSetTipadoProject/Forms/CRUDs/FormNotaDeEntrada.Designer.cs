namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormNotaDeEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdNotaDeEntrada;
            System.Windows.Forms.Label lblIdFornecedor;
            System.Windows.Forms.Label nrNotaLabel;
            System.Windows.Forms.Label dtEmissaoLabel;
            System.Windows.Forms.Label dtEntradaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaDeEntrada));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.notasDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasDeEntradaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.NotasDeEntradaTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.notasDeEntradaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notasDeEntradaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdNotaDeEntrada = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNrNota = new System.Windows.Forms.TextBox();
            this.dtEmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fornecedoresTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter();
            this.gpxDetalhesNotaEntrada = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeEntradaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter();
            this.produtosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            lblIdNotaDeEntrada = new System.Windows.Forms.Label();
            lblIdFornecedor = new System.Windows.Forms.Label();
            nrNotaLabel = new System.Windows.Forms.Label();
            dtEmissaoLabel = new System.Windows.Forms.Label();
            dtEntradaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingNavigator)).BeginInit();
            this.notasDeEntradaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.gpxDetalhesNotaEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdNotaDeEntrada
            // 
            lblIdNotaDeEntrada.AutoSize = true;
            lblIdNotaDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdNotaDeEntrada.Location = new System.Drawing.Point(27, 54);
            lblIdNotaDeEntrada.Name = "lblIdNotaDeEntrada";
            lblIdNotaDeEntrada.Size = new System.Drawing.Size(76, 18);
            lblIdNotaDeEntrada.TabIndex = 1;
            lblIdNotaDeEntrada.Text = "Cód Nota:";
            // 
            // lblIdFornecedor
            // 
            lblIdFornecedor.AutoSize = true;
            lblIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdFornecedor.Location = new System.Drawing.Point(27, 97);
            lblIdFornecedor.Name = "lblIdFornecedor";
            lblIdFornecedor.Size = new System.Drawing.Size(89, 18);
            lblIdFornecedor.TabIndex = 3;
            lblIdFornecedor.Text = "Fornecedor:";
            // 
            // nrNotaLabel
            // 
            nrNotaLabel.AutoSize = true;
            nrNotaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nrNotaLabel.Location = new System.Drawing.Point(390, 57);
            nrNotaLabel.Name = "nrNotaLabel";
            nrNotaLabel.Size = new System.Drawing.Size(64, 18);
            nrNotaLabel.TabIndex = 5;
            nrNotaLabel.Text = "Nr Nota:";
            // 
            // dtEmissaoLabel
            // 
            dtEmissaoLabel.AutoSize = true;
            dtEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtEmissaoLabel.Location = new System.Drawing.Point(27, 139);
            dtEmissaoLabel.Name = "dtEmissaoLabel";
            dtEmissaoLabel.Size = new System.Drawing.Size(126, 18);
            dtEmissaoLabel.TabIndex = 7;
            dtEmissaoLabel.Text = "Data de Emissao:";
            // 
            // dtEntradaLabel
            // 
            dtEntradaLabel.AutoSize = true;
            dtEntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtEntradaLabel.Location = new System.Drawing.Point(335, 134);
            dtEntradaLabel.Name = "dtEntradaLabel";
            dtEntradaLabel.Size = new System.Drawing.Size(118, 18);
            dtEntradaLabel.TabIndex = 9;
            dtEntradaLabel.Text = "Data de Entrada:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasDeEntradaBindingSource
            // 
            this.notasDeEntradaBindingSource.DataMember = "NotasDeEntrada";
            this.notasDeEntradaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // notasDeEntradaTableAdapter
            // 
            this.notasDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EnderecosTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotasDeEntradaTableAdapter = this.notasDeEntradaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = this.produtosNotaDeEntradaTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notasDeEntradaBindingNavigator
            // 
            this.notasDeEntradaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasDeEntradaBindingNavigator.BindingSource = this.notasDeEntradaBindingSource;
            this.notasDeEntradaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeEntradaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasDeEntradaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notasDeEntradaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.notasDeEntradaBindingNavigatorSaveItem});
            this.notasDeEntradaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeEntradaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasDeEntradaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasDeEntradaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasDeEntradaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasDeEntradaBindingNavigator.Name = "notasDeEntradaBindingNavigator";
            this.notasDeEntradaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasDeEntradaBindingNavigator.Size = new System.Drawing.Size(646, 27);
            this.notasDeEntradaBindingNavigator.TabIndex = 0;
            this.notasDeEntradaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // notasDeEntradaBindingNavigatorSaveItem
            // 
            this.notasDeEntradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasDeEntradaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasDeEntradaBindingNavigatorSaveItem.Image")));
            this.notasDeEntradaBindingNavigatorSaveItem.Name = "notasDeEntradaBindingNavigatorSaveItem";
            this.notasDeEntradaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.notasDeEntradaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasDeEntradaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasDeEntradaBindingNavigatorSaveItem_Click_1);
            // 
            // txtIdNotaDeEntrada
            // 
            this.txtIdNotaDeEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeEntradaBindingSource, "IdNotaDeEntrada", true));
            this.txtIdNotaDeEntrada.Location = new System.Drawing.Point(170, 54);
            this.txtIdNotaDeEntrada.Name = "txtIdNotaDeEntrada";
            this.txtIdNotaDeEntrada.Size = new System.Drawing.Size(113, 23);
            this.txtIdNotaDeEntrada.TabIndex = 2;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeEntradaBindingSource, "IdFornecedor", true));
            this.cbxFornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbxFornecedor.DisplayMember = "Nome";
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(170, 90);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(438, 24);
            this.cbxFornecedor.TabIndex = 4;
            this.cbxFornecedor.ValueMember = "IdFornecedor";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // txtNrNota
            // 
            this.txtNrNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeEntradaBindingSource, "NrNota", true));
            this.txtNrNota.Location = new System.Drawing.Point(484, 54);
            this.txtNrNota.Name = "txtNrNota";
            this.txtNrNota.Size = new System.Drawing.Size(124, 22);
            this.txtNrNota.TabIndex = 6;
            // 
            // dtEmissaoDateTimePicker
            // 
            this.dtEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeEntradaBindingSource, "DtEmissao", true));
            this.dtEmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissaoDateTimePicker.Location = new System.Drawing.Point(170, 134);
            this.dtEmissaoDateTimePicker.Name = "dtEmissaoDateTimePicker";
            this.dtEmissaoDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.dtEmissaoDateTimePicker.TabIndex = 8;
            // 
            // dtEntradaDateTimePicker
            // 
            this.dtEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeEntradaBindingSource, "DtEntrada", true));
            this.dtEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntradaDateTimePicker.Location = new System.Drawing.Point(484, 134);
            this.dtEntradaDateTimePicker.Name = "dtEntradaDateTimePicker";
            this.dtEntradaDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.dtEntradaDateTimePicker.TabIndex = 10;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // gpxDetalhesNotaEntrada
            // 
            this.gpxDetalhesNotaEntrada.Controls.Add(this.dgvProdutos);
            this.gpxDetalhesNotaEntrada.Controls.Add(this.bindingNavigator1);
            this.gpxDetalhesNotaEntrada.Location = new System.Drawing.Point(35, 180);
            this.gpxDetalhesNotaEntrada.Name = "gpxDetalhesNotaEntrada";
            this.gpxDetalhesNotaEntrada.Size = new System.Drawing.Size(568, 291);
            this.gpxDetalhesNotaEntrada.TabIndex = 11;
            this.gpxDetalhesNotaEntrada.TabStop = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvProdutos.DataSource = this.produtosNotaDeEntradaBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 45);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(562, 243);
            this.dgvProdutos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoCusto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Custo:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantidadeCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // produtosNotaDeEntradaBindingSource
            // 
            this.produtosNotaDeEntradaBindingSource.DataMember = "FK_ProdutosNotaDeEntrada_NotasDeEntrada";
            this.produtosNotaDeEntradaBindingSource.DataSource = this.notasDeEntradaBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.produtosNotaDeEntradaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(562, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem1.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem1.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProdutosNotaDeEntrada";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProdutosNotaDeEntrada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdNotaDeEntrada";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdNotaDeEntrada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // produtosNotaDeEntradaTableAdapter
            // 
            this.produtosNotaDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FormNotaDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.gpxDetalhesNotaEntrada);
            this.Controls.Add(lblIdNotaDeEntrada);
            this.Controls.Add(this.txtIdNotaDeEntrada);
            this.Controls.Add(lblIdFornecedor);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(nrNotaLabel);
            this.Controls.Add(this.txtNrNota);
            this.Controls.Add(dtEmissaoLabel);
            this.Controls.Add(this.dtEmissaoDateTimePicker);
            this.Controls.Add(dtEntradaLabel);
            this.Controls.Add(this.dtEntradaDateTimePicker);
            this.Controls.Add(this.notasDeEntradaBindingNavigator);
            this.Name = "FormNotaDeEntrada";
            this.Text = "Cadastro de Nota de Entrada - Estoque";
            this.Load += new System.EventHandler(this.FormNotaDeEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingNavigator)).EndInit();
            this.notasDeEntradaBindingNavigator.ResumeLayout(false);
            this.notasDeEntradaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.gpxDetalhesNotaEntrada.ResumeLayout(false);
            this.gpxDetalhesNotaEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeEntradaTableAdapter notasDeEntradaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeEntradaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notasDeEntradaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label txtIdNotaDeEntrada;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.TextBox txtNrNota;
        private System.Windows.Forms.DateTimePicker dtEmissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dtEntradaDateTimePicker;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.GroupBox gpxDetalhesNotaEntrada;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource produtosNotaDeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter produtosNotaDeEntradaTableAdapter;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
    }
}