namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormNotaDeSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaDeSaida));
            this.idnotadevendaLabel = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblNrNota = new System.Windows.Forms.Label();
            this.datadavendaLabel = new System.Windows.Forms.Label();
            this.notafechadaLabel = new System.Windows.Forms.Label();
            this.gbxDadosDaNota = new System.Windows.Forms.GroupBox();
            this.notasDeVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.IdNotaDeVenda = new System.Windows.Forms.Label();
            this.cbxNmCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datadavendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblIdNotaFechada = new System.Windows.Forms.Label();
            this.notasDeVendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnbAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnbRemove = new System.Windows.Forms.ToolStripButton();
            this.bnbFirst = new System.Windows.Forms.ToolStripButton();
            this.bnbPrior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnbRecordNo = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnbNext = new System.Windows.Forms.ToolStripButton();
            this.bnbLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnbSave = new System.Windows.Forms.ToolStripButton();
            this.bnbEdit = new System.Windows.Forms.ToolStripButton();
            this.bnbFecharNota = new System.Windows.Forms.ToolStripButton();
            this.bnbPesquisaNota = new System.Windows.Forms.ToolStripButton();
            this.notasDeVendaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter();
            this.produtosNotaDeSaidaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter();
            this.produtosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            this.gbxProdutosDaNota = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.precoDeVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNotaDeVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNrNota = new System.Windows.Forms.TextBox();
            this.gbxDadosDaNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).BeginInit();
            this.notasDeVendaBindingNavigator.SuspendLayout();
            this.gbxProdutosDaNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnotadevendaLabel
            // 
            this.idnotadevendaLabel.AutoSize = true;
            this.idnotadevendaLabel.Location = new System.Drawing.Point(25, 31);
            this.idnotadevendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idnotadevendaLabel.Name = "idnotadevendaLabel";
            this.idnotadevendaLabel.Size = new System.Drawing.Size(92, 17);
            this.idnotadevendaLabel.TabIndex = 0;
            this.idnotadevendaLabel.Text = "Nr da Venda:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(25, 66);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(55, 17);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // lblNrNota
            // 
            this.lblNrNota.AutoSize = true;
            this.lblNrNota.Location = new System.Drawing.Point(25, 100);
            this.lblNrNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNrNota.Name = "lblNrNota";
            this.lblNrNota.Size = new System.Drawing.Size(61, 17);
            this.lblNrNota.TabIndex = 4;
            this.lblNrNota.Text = "Nr Nota:";
            // 
            // datadavendaLabel
            // 
            this.datadavendaLabel.AutoSize = true;
            this.datadavendaLabel.Location = new System.Drawing.Point(25, 133);
            this.datadavendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datadavendaLabel.Name = "datadavendaLabel";
            this.datadavendaLabel.Size = new System.Drawing.Size(107, 17);
            this.datadavendaLabel.TabIndex = 6;
            this.datadavendaLabel.Text = "Data da Venda:";
            // 
            // notafechadaLabel
            // 
            this.notafechadaLabel.AutoSize = true;
            this.notafechadaLabel.Location = new System.Drawing.Point(25, 166);
            this.notafechadaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notafechadaLabel.Name = "notafechadaLabel";
            this.notafechadaLabel.Size = new System.Drawing.Size(105, 17);
            this.notafechadaLabel.TabIndex = 8;
            this.notafechadaLabel.Text = "Nota Fechada?";
            // 
            // gbxDadosDaNota
            // 
            this.gbxDadosDaNota.Controls.Add(this.txtNrNota);
            this.gbxDadosDaNota.Controls.Add(this.IdNotaDeVenda);
            this.gbxDadosDaNota.Controls.Add(this.idnotadevendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.lblNomeCliente);
            this.gbxDadosDaNota.Controls.Add(this.cbxNmCliente);
            this.gbxDadosDaNota.Controls.Add(this.lblNrNota);
            this.gbxDadosDaNota.Controls.Add(this.datadavendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.datadavendaDateTimePicker);
            this.gbxDadosDaNota.Controls.Add(this.notafechadaLabel);
            this.gbxDadosDaNota.Controls.Add(this.lblIdNotaFechada);
            this.gbxDadosDaNota.Enabled = false;
            this.gbxDadosDaNota.Location = new System.Drawing.Point(16, 34);
            this.gbxDadosDaNota.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDadosDaNota.Name = "gbxDadosDaNota";
            this.gbxDadosDaNota.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDadosDaNota.Size = new System.Drawing.Size(523, 208);
            this.gbxDadosDaNota.TabIndex = 0;
            this.gbxDadosDaNota.TabStop = false;
            this.gbxDadosDaNota.Text = "Dados da Nota";
            // 
            // notasDeVendaBindingSource
            // 
            this.notasDeVendaBindingSource.DataMember = "NotasDeVenda";
            this.notasDeVendaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdNotaDeVenda
            // 
            this.IdNotaDeVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "IdNotaDeVenda", true));
            this.IdNotaDeVenda.Location = new System.Drawing.Point(138, 31);
            this.IdNotaDeVenda.Name = "IdNotaDeVenda";
            this.IdNotaDeVenda.Size = new System.Drawing.Size(135, 23);
            this.IdNotaDeVenda.TabIndex = 10;
            this.IdNotaDeVenda.Text = "IdNotaDeVenda";
            // 
            // cbxNmCliente
            // 
            this.cbxNmCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeVendaBindingSource, "idcliente", true));
            this.cbxNmCliente.DataSource = this.clientesBindingSource;
            this.cbxNmCliente.DisplayMember = "nome";
            this.cbxNmCliente.FormattingEnabled = true;
            this.cbxNmCliente.Location = new System.Drawing.Point(141, 63);
            this.cbxNmCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNmCliente.Name = "cbxNmCliente";
            this.cbxNmCliente.Size = new System.Drawing.Size(327, 24);
            this.cbxNmCliente.TabIndex = 3;
            this.cbxNmCliente.ValueMember = "idcliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // datadavendaDateTimePicker
            // 
            this.datadavendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeVendaBindingSource, "datadavenda", true));
            this.datadavendaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datadavendaDateTimePicker.Location = new System.Drawing.Point(141, 128);
            this.datadavendaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datadavendaDateTimePicker.Name = "datadavendaDateTimePicker";
            this.datadavendaDateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.datadavendaDateTimePicker.TabIndex = 7;
            // 
            // lblIdNotaFechada
            // 
            this.lblIdNotaFechada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "notafechada", true));
            this.lblIdNotaFechada.Location = new System.Drawing.Point(141, 166);
            this.lblIdNotaFechada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNotaFechada.Name = "lblIdNotaFechada";
            this.lblIdNotaFechada.Size = new System.Drawing.Size(94, 22);
            this.lblIdNotaFechada.TabIndex = 9;
            this.lblIdNotaFechada.Text = "IdNotaFechada";
            // 
            // notasDeVendaBindingNavigator
            // 
            this.notasDeVendaBindingNavigator.AddNewItem = this.bnbAdd;
            this.notasDeVendaBindingNavigator.BindingSource = this.notasDeVendaBindingSource;
            this.notasDeVendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeVendaBindingNavigator.DeleteItem = this.bnbRemove;
            this.notasDeVendaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notasDeVendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnbFirst,
            this.bnbPrior,
            this.bindingNavigatorSeparator,
            this.bnbRecordNo,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bnbNext,
            this.bnbLast,
            this.bindingNavigatorSeparator2,
            this.bnbAdd,
            this.bnbRemove,
            this.bnbSave,
            this.bnbEdit,
            this.bnbFecharNota,
            this.bnbPesquisaNota});
            this.notasDeVendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeVendaBindingNavigator.MoveFirstItem = this.bnbFirst;
            this.notasDeVendaBindingNavigator.MoveLastItem = this.bnbLast;
            this.notasDeVendaBindingNavigator.MoveNextItem = this.bnbNext;
            this.notasDeVendaBindingNavigator.MovePreviousItem = this.bnbPrior;
            this.notasDeVendaBindingNavigator.Name = "notasDeVendaBindingNavigator";
            this.notasDeVendaBindingNavigator.PositionItem = this.bnbRecordNo;
            this.notasDeVendaBindingNavigator.Size = new System.Drawing.Size(539, 27);
            this.notasDeVendaBindingNavigator.TabIndex = 1;
            this.notasDeVendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bnbAdd
            // 
            this.bnbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnbAdd.Image")));
            this.bnbAdd.Name = "bnbAdd";
            this.bnbAdd.RightToLeftAutoMirrorImage = true;
            this.bnbAdd.Size = new System.Drawing.Size(24, 24);
            this.bnbAdd.Text = "Add new";
            this.bnbAdd.Click += new System.EventHandler(this.bnbAdd_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bnbRemove
            // 
            this.bnbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbRemove.Image = ((System.Drawing.Image)(resources.GetObject("bnbRemove.Image")));
            this.bnbRemove.Name = "bnbRemove";
            this.bnbRemove.RightToLeftAutoMirrorImage = true;
            this.bnbRemove.Size = new System.Drawing.Size(24, 24);
            this.bnbRemove.Text = "Delete";
            this.bnbRemove.Click += new System.EventHandler(this.bnbRemove_Click);
            // 
            // bnbFirst
            // 
            this.bnbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnbFirst.Image")));
            this.bnbFirst.Name = "bnbFirst";
            this.bnbFirst.RightToLeftAutoMirrorImage = true;
            this.bnbFirst.Size = new System.Drawing.Size(24, 24);
            this.bnbFirst.Text = "Move first";
            // 
            // bnbPrior
            // 
            this.bnbPrior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbPrior.Image = ((System.Drawing.Image)(resources.GetObject("bnbPrior.Image")));
            this.bnbPrior.Name = "bnbPrior";
            this.bnbPrior.RightToLeftAutoMirrorImage = true;
            this.bnbPrior.Size = new System.Drawing.Size(24, 24);
            this.bnbPrior.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bnbRecordNo
            // 
            this.bnbRecordNo.AccessibleName = "Position";
            this.bnbRecordNo.AutoSize = false;
            this.bnbRecordNo.Name = "bnbRecordNo";
            this.bnbRecordNo.Size = new System.Drawing.Size(65, 27);
            this.bnbRecordNo.Text = "0";
            this.bnbRecordNo.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bnbNext
            // 
            this.bnbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbNext.Image = ((System.Drawing.Image)(resources.GetObject("bnbNext.Image")));
            this.bnbNext.Name = "bnbNext";
            this.bnbNext.RightToLeftAutoMirrorImage = true;
            this.bnbNext.Size = new System.Drawing.Size(24, 24);
            this.bnbNext.Text = "Move next";
            // 
            // bnbLast
            // 
            this.bnbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbLast.Image = ((System.Drawing.Image)(resources.GetObject("bnbLast.Image")));
            this.bnbLast.Name = "bnbLast";
            this.bnbLast.RightToLeftAutoMirrorImage = true;
            this.bnbLast.Size = new System.Drawing.Size(24, 24);
            this.bnbLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bnbSave
            // 
            this.bnbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbSave.Image = ((System.Drawing.Image)(resources.GetObject("bnbSave.Image")));
            this.bnbSave.Name = "bnbSave";
            this.bnbSave.Size = new System.Drawing.Size(24, 24);
            this.bnbSave.Text = "Save Data";
            this.bnbSave.Click += new System.EventHandler(this.notasDeVendaBindingNavigatorSaveItem_Click);
            // 
            // bnbEdit
            // 
            this.bnbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnbEdit.Image")));
            this.bnbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbEdit.Name = "bnbEdit";
            this.bnbEdit.Size = new System.Drawing.Size(24, 24);
            this.bnbEdit.Text = "Editar";
            this.bnbEdit.Click += new System.EventHandler(this.bnbEdit_Click);
            // 
            // bnbFecharNota
            // 
            this.bnbFecharNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFecharNota.Image = ((System.Drawing.Image)(resources.GetObject("bnbFecharNota.Image")));
            this.bnbFecharNota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbFecharNota.Name = "bnbFecharNota";
            this.bnbFecharNota.Size = new System.Drawing.Size(24, 24);
            this.bnbFecharNota.Text = "Fechar Nota";
            this.bnbFecharNota.Click += new System.EventHandler(this.bnbFecharNota_Click);
            // 
            // bnbPesquisaNota
            // 
            this.bnbPesquisaNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbPesquisaNota.Image = ((System.Drawing.Image)(resources.GetObject("bnbPesquisaNota.Image")));
            this.bnbPesquisaNota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbPesquisaNota.Name = "bnbPesquisaNota";
            this.bnbPesquisaNota.Size = new System.Drawing.Size(24, 24);
            this.bnbPesquisaNota.Text = "toolStripButton1";
            // 
            // notasDeVendaTableAdapter
            // 
            this.notasDeVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.EnderecosTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotasDeEntradaTableAdapter = null;
            this.tableAdapterManager.NotasDeVendaTableAdapter = this.notasDeVendaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosNotaDeSaidaTableAdapter = this.produtosNotaDeSaidaTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.Tp_EnderecoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // produtosNotaDeSaidaTableAdapter
            // 
            this.produtosNotaDeSaidaTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // gbxProdutosDaNota
            // 
            this.gbxProdutosDaNota.Controls.Add(this.dgvProdutos);
            this.gbxProdutosDaNota.Controls.Add(this.bindingNavigator1);
            this.gbxProdutosDaNota.Enabled = false;
            this.gbxProdutosDaNota.Location = new System.Drawing.Point(16, 240);
            this.gbxProdutosDaNota.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProdutosDaNota.Name = "gbxProdutosDaNota";
            this.gbxProdutosDaNota.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProdutosDaNota.Size = new System.Drawing.Size(491, 229);
            this.gbxProdutosDaNota.TabIndex = 2;
            this.gbxProdutosDaNota.TabStop = false;
            this.gbxProdutosDaNota.Text = "Produtos da Nota";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.precoDeVendaDataGridViewTextBoxColumn,
            this.QuantidadeTextBox});
            this.dgvProdutos.DataSource = this.produtosNotaDeSaidaBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(4, 46);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(483, 179);
            this.dgvProdutos.TabIndex = 1;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.HeaderText = "Produto:";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // precoDeVendaDataGridViewTextBoxColumn
            // 
            this.precoDeVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoDeVenda";
            this.precoDeVendaDataGridViewTextBoxColumn.HeaderText = "Preco:";
            this.precoDeVendaDataGridViewTextBoxColumn.Name = "precoDeVendaDataGridViewTextBoxColumn";
            // 
            // QuantidadeTextBox
            // 
            this.QuantidadeTextBox.DataPropertyName = "Quantidade";
            this.QuantidadeTextBox.HeaderText = "Quantidade:";
            this.QuantidadeTextBox.Name = "QuantidadeTextBox";
            // 
            // produtosNotaDeSaidaBindingSource
            // 
            this.produtosNotaDeSaidaBindingSource.DataMember = "FK_ProdutosNotaDeSaida_NotasDeVenda";
            this.produtosNotaDeSaidaBindingSource.DataSource = this.notasDeVendaBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.produtosNotaDeSaidaBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 19);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(483, 27);
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
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // idProdutoNotaDeSaidaDataGridViewTextBoxColumn
            // 
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn.DataPropertyName = "IdProdutoNotaDeSaida";
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn.HeaderText = "IdProdutoNotaDeSaida";
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn.Name = "idProdutoNotaDeSaidaDataGridViewTextBoxColumn";
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoNotaDeSaidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idNotaDeVendaDataGridViewTextBoxColumn
            // 
            this.idNotaDeVendaDataGridViewTextBoxColumn.DataPropertyName = "IdNotaDeVenda";
            this.idNotaDeVendaDataGridViewTextBoxColumn.HeaderText = "IdNotaDeVenda";
            this.idNotaDeVendaDataGridViewTextBoxColumn.Name = "idNotaDeVendaDataGridViewTextBoxColumn";
            this.idNotaDeVendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // txtNrNota
            // 
            this.txtNrNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "NumeroDaNota", true));
            this.txtNrNota.Location = new System.Drawing.Point(141, 94);
            this.txtNrNota.Name = "txtNrNota";
            this.txtNrNota.Size = new System.Drawing.Size(100, 22);
            this.txtNrNota.TabIndex = 11;
            // 
            // FormNotaDeSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 479);
            this.Controls.Add(this.gbxProdutosDaNota);
            this.Controls.Add(this.notasDeVendaBindingNavigator);
            this.Controls.Add(this.gbxDadosDaNota);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNotaDeSaida";
            this.Text = "Cadastro de Vendas";
            this.gbxDadosDaNota.ResumeLayout(false);
            this.gbxDadosDaNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).EndInit();
            this.notasDeVendaBindingNavigator.ResumeLayout(false);
            this.notasDeVendaBindingNavigator.PerformLayout();
            this.gbxProdutosDaNota.ResumeLayout(false);
            this.gbxProdutosDaNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosDaNota;
        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeVendaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter notasDeVendaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeVendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bnbAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bnbFirst;
        private System.Windows.Forms.ToolStripButton bnbPrior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnbRecordNo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnbNext;
        private System.Windows.Forms.ToolStripButton bnbLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnbSave;
        private System.Windows.Forms.ComboBox cbxNmCliente;
        private System.Windows.Forms.DateTimePicker datadavendaDateTimePicker;
        private System.Windows.Forms.Label lblIdNotaFechada;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.GroupBox gbxProdutosDaNota;
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
        private System.Windows.Forms.BindingSource produtosNotaDeSaidaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter produtosNotaDeSaidaTableAdapter;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.ToolStripButton bnbEdit;
        private System.Windows.Forms.ToolStripButton bnbFecharNota;
        private System.Windows.Forms.Label idnotadevendaLabel;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblNrNota;
        private System.Windows.Forms.Label datadavendaLabel;
        private System.Windows.Forms.Label notafechadaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoNotaDeSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNotaDeVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label IdNotaDeVenda;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTextBox;
        private System.Windows.Forms.ToolStripButton bnbRemove;
        private System.Windows.Forms.ToolStripButton bnbPesquisaNota;
        private System.Windows.Forms.TextBox txtNrNota;
    }

}