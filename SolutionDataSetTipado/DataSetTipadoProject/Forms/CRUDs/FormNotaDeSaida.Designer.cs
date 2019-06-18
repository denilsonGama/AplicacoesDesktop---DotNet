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
            System.Windows.Forms.Label idNotaDeVendaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label numeroDaNotaLabel;
            System.Windows.Forms.Label dataDaVendaLabel;
            System.Windows.Forms.Label notaFechadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaDeSaida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idNotaDeVendaLabel1 = new System.Windows.Forms.Label();
            this.notasDeVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDaNotaTextBox = new System.Windows.Forms.TextBox();
            this.dataDaVendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notaFechadaLabel1 = new System.Windows.Forms.Label();
            this.notasDeVendaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter();
            this.produtosNotaDeSaidaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter();
            this.produtosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            this.notasDeVendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.notasDeVendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.produtosNotaDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosNotaDeEntradaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idNotaDeVendaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            numeroDaNotaLabel = new System.Windows.Forms.Label();
            dataDaVendaLabel = new System.Windows.Forms.Label();
            notaFechadaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).BeginInit();
            this.notasDeVendaBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // idNotaDeVendaLabel
            // 
            idNotaDeVendaLabel.AutoSize = true;
            idNotaDeVendaLabel.Location = new System.Drawing.Point(54, 39);
            idNotaDeVendaLabel.Name = "idNotaDeVendaLabel";
            idNotaDeVendaLabel.Size = new System.Drawing.Size(124, 17);
            idNotaDeVendaLabel.TabIndex = 0;
            idNotaDeVendaLabel.Text = "Id Nota De Venda:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(54, 68);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(70, 17);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // numeroDaNotaLabel
            // 
            numeroDaNotaLabel.AutoSize = true;
            numeroDaNotaLabel.Location = new System.Drawing.Point(54, 99);
            numeroDaNotaLabel.Name = "numeroDaNotaLabel";
            numeroDaNotaLabel.Size = new System.Drawing.Size(118, 17);
            numeroDaNotaLabel.TabIndex = 4;
            numeroDaNotaLabel.Text = "Numero Da Nota:";
            // 
            // dataDaVendaLabel
            // 
            dataDaVendaLabel.AutoSize = true;
            dataDaVendaLabel.Location = new System.Drawing.Point(54, 128);
            dataDaVendaLabel.Name = "dataDaVendaLabel";
            dataDaVendaLabel.Size = new System.Drawing.Size(109, 17);
            dataDaVendaLabel.TabIndex = 6;
            dataDaVendaLabel.Text = "Data Da Venda:";
            // 
            // notaFechadaLabel
            // 
            notaFechadaLabel.AutoSize = true;
            notaFechadaLabel.Location = new System.Drawing.Point(54, 149);
            notaFechadaLabel.Name = "notaFechadaLabel";
            notaFechadaLabel.Size = new System.Drawing.Size(101, 17);
            notaFechadaLabel.TabIndex = 8;
            notaFechadaLabel.Text = "Nota Fechada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idNotaDeVendaLabel);
            this.groupBox1.Controls.Add(this.idNotaDeVendaLabel1);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteComboBox);
            this.groupBox1.Controls.Add(numeroDaNotaLabel);
            this.groupBox1.Controls.Add(this.numeroDaNotaTextBox);
            this.groupBox1.Controls.Add(dataDaVendaLabel);
            this.groupBox1.Controls.Add(this.dataDaVendaDateTimePicker);
            this.groupBox1.Controls.Add(notaFechadaLabel);
            this.groupBox1.Controls.Add(this.notaFechadaLabel1);
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Nota";
            // 
            // idNotaDeVendaLabel1
            // 
            this.idNotaDeVendaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "IdNotaDeVenda", true));
            this.idNotaDeVendaLabel1.Location = new System.Drawing.Point(184, 39);
            this.idNotaDeVendaLabel1.Name = "idNotaDeVendaLabel1";
            this.idNotaDeVendaLabel1.Size = new System.Drawing.Size(480, 23);
            this.idNotaDeVendaLabel1.TabIndex = 1;
            this.idNotaDeVendaLabel1.Text = "label1";
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
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeVendaBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "Nome";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(184, 65);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(480, 24);
            this.idClienteComboBox.TabIndex = 3;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // numeroDaNotaTextBox
            // 
            this.numeroDaNotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "NumeroDaNota", true));
            this.numeroDaNotaTextBox.Location = new System.Drawing.Point(184, 96);
            this.numeroDaNotaTextBox.Name = "numeroDaNotaTextBox";
            this.numeroDaNotaTextBox.Size = new System.Drawing.Size(121, 22);
            this.numeroDaNotaTextBox.TabIndex = 5;
            // 
            // dataDaVendaDateTimePicker
            // 
            this.dataDaVendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeVendaBindingSource, "DataDaVenda", true));
            this.dataDaVendaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDaVendaDateTimePicker.Location = new System.Drawing.Point(184, 124);
            this.dataDaVendaDateTimePicker.Name = "dataDaVendaDateTimePicker";
            this.dataDaVendaDateTimePicker.Size = new System.Drawing.Size(121, 22);
            this.dataDaVendaDateTimePicker.TabIndex = 7;
            // 
            // notaFechadaLabel1
            // 
            this.notaFechadaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "NotaFechada", true));
            this.notaFechadaLabel1.Location = new System.Drawing.Point(184, 149);
            this.notaFechadaLabel1.Name = "notaFechadaLabel1";
            this.notaFechadaLabel1.Size = new System.Drawing.Size(480, 23);
            this.notaFechadaLabel1.TabIndex = 9;
            this.notaFechadaLabel1.Text = "label1";
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
            // notasDeVendaBindingNavigator
            // 
            this.notasDeVendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasDeVendaBindingNavigator.BindingSource = this.notasDeVendaBindingSource;
            this.notasDeVendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeVendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasDeVendaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notasDeVendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasDeVendaBindingNavigatorSaveItem});
            this.notasDeVendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeVendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasDeVendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasDeVendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasDeVendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasDeVendaBindingNavigator.Name = "notasDeVendaBindingNavigator";
            this.notasDeVendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasDeVendaBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.notasDeVendaBindingNavigator.TabIndex = 1;
            this.notasDeVendaBindingNavigator.Text = "bindingNavigator1";
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
            // notasDeVendaBindingNavigatorSaveItem
            // 
            this.notasDeVendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasDeVendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasDeVendaBindingNavigatorSaveItem.Image")));
            this.notasDeVendaBindingNavigatorSaveItem.Name = "notasDeVendaBindingNavigatorSaveItem";
            this.notasDeVendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.notasDeVendaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasDeVendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasDeVendaBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(36, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes da Nota";
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(710, 27);
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
            // produtosNotaDeEntradaBindingSource
            // 
            this.produtosNotaDeEntradaBindingSource.DataMember = "ProdutosNotaDeEntrada";
            this.produtosNotaDeEntradaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // produtosNotaDeEntradaTableAdapter
            // 
            this.produtosNotaDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.dataGridViewTextBoxColumn1,
            //this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvProdutos.DataSource = this.produtosNotaDeEntradaBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(7, 52);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(703, 220);
            this.dgvProdutos.TabIndex = 1;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Produto:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoCusto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preco:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantidadeCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormNotaDeSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.notasDeVendaBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNotaDeSaida";
            this.Text = "Cadastro de Nota de Venda";
            this.Load += new System.EventHandler(this.FormNotaDeSaida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).EndInit();
            this.notasDeVendaBindingNavigator.ResumeLayout(false);
            this.notasDeVendaBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeVendaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter notasDeVendaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeVendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasDeVendaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idNotaDeVendaLabel1;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox numeroDaNotaTextBox;
        private System.Windows.Forms.DateTimePicker dataDaVendaDateTimePicker;
        private System.Windows.Forms.Label notaFechadaLabel1;
        private DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosNotaDeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter produtosNotaDeEntradaTableAdapter;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}