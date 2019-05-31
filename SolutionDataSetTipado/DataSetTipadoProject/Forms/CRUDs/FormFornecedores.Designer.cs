namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormFornecedores
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
            System.Windows.Forms.Label lblIdFornecedor;
            System.Windows.Forms.Label lblIdCidade;
            System.Windows.Forms.Label lblNmFornecedor;
            System.Windows.Forms.Label lblCnpj;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedores));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.cidadesTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.CidadesTableAdapter();
            this.fornecedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornecedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cbxCidadeUf = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNmFornecedor = new System.Windows.Forms.TextBox();
            this.txtCnpf = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.Label();
            lblIdFornecedor = new System.Windows.Forms.Label();
            lblIdCidade = new System.Windows.Forms.Label();
            lblNmFornecedor = new System.Windows.Forms.Label();
            lblCnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).BeginInit();
            this.fornecedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdFornecedor
            // 
            lblIdFornecedor.AutoSize = true;
            lblIdFornecedor.Location = new System.Drawing.Point(134, 129);
            lblIdFornecedor.Name = "lblIdFornecedor";
            lblIdFornecedor.Size = new System.Drawing.Size(100, 17);
            lblIdFornecedor.TabIndex = 1;
            lblIdFornecedor.Text = "Id Fornecedor:";
            // 
            // lblIdCidade
            // 
            lblIdCidade.AutoSize = true;
            lblIdCidade.Location = new System.Drawing.Point(134, 158);
            lblIdCidade.Name = "lblIdCidade";
            lblIdCidade.Size = new System.Drawing.Size(71, 17);
            lblIdCidade.TabIndex = 3;
            lblIdCidade.Text = "Id Cidade:";
            // 
            // lblNmFornecedor
            // 
            lblNmFornecedor.AutoSize = true;
            lblNmFornecedor.Location = new System.Drawing.Point(134, 189);
            lblNmFornecedor.Name = "lblNmFornecedor";
            lblNmFornecedor.Size = new System.Drawing.Size(49, 17);
            lblNmFornecedor.TabIndex = 5;
            lblNmFornecedor.Text = "Nome:";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new System.Drawing.Point(134, 217);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new System.Drawing.Size(47, 17);
            lblCnpj.TabIndex = 7;
            lblCnpj.Text = "CNPJ:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = this.cidadesTableAdapter;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresBindingNavigator
            // 
            this.fornecedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecedoresBindingNavigator.BindingSource = this.fornecedoresBindingSource;
            this.fornecedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedoresBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fornecedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedoresBindingNavigatorSaveItem});
            this.fornecedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedoresBindingNavigator.Name = "fornecedoresBindingNavigator";
            this.fornecedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedoresBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.fornecedoresBindingNavigator.TabIndex = 0;
            this.fornecedoresBindingNavigator.Text = "bindingNavigator1";
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
            // fornecedoresBindingNavigatorSaveItem
            // 
            this.fornecedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresBindingNavigatorSaveItem.Image")));
            this.fornecedoresBindingNavigatorSaveItem.Name = "fornecedoresBindingNavigatorSaveItem";
            this.fornecedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.fornecedoresBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fornecedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedoresBindingNavigatorSaveItem_Click);
            // 
            // cbxCidadeUf
            // 
            this.cbxCidadeUf.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "IdCidade", true));
            this.cbxCidadeUf.DataSource = this.cidadesBindingSource;
            this.cbxCidadeUf.DisplayMember = "nome";
            this.cbxCidadeUf.FormattingEnabled = true;
            this.cbxCidadeUf.Location = new System.Drawing.Point(240, 155);
            this.cbxCidadeUf.Name = "cbxCidadeUf";
            this.cbxCidadeUf.Size = new System.Drawing.Size(316, 24);
            this.cbxCidadeUf.TabIndex = 4;
            this.cbxCidadeUf.ValueMember = "IdCidade";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // txtNmFornecedor
            // 
            this.txtNmFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Nome", true));
            this.txtNmFornecedor.Location = new System.Drawing.Point(240, 186);
            this.txtNmFornecedor.Name = "txtNmFornecedor";
            this.txtNmFornecedor.Size = new System.Drawing.Size(316, 22);
            this.txtNmFornecedor.TabIndex = 6;
            // 
            // txtCnpf
            // 
            this.txtCnpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CNPJ", true));
            this.txtCnpf.Location = new System.Drawing.Point(240, 214);
            this.txtCnpf.Name = "txtCnpf";
            this.txtCnpf.Size = new System.Drawing.Size(316, 22);
            this.txtCnpf.TabIndex = 8;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "IdFornecedor", true));
            this.txtIdFornecedor.Location = new System.Drawing.Point(240, 129);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(316, 23);
            this.txtIdFornecedor.TabIndex = 2;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblIdFornecedor);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(lblIdCidade);
            this.Controls.Add(this.cbxCidadeUf);
            this.Controls.Add(lblNmFornecedor);
            this.Controls.Add(this.txtNmFornecedor);
            this.Controls.Add(lblCnpj);
            this.Controls.Add(this.txtCnpf);
            this.Controls.Add(this.fornecedoresBindingNavigator);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).EndInit();
            this.fornecedoresBindingNavigator.ResumeLayout(false);
            this.fornecedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cbxCidadeUf;
        private System.Windows.Forms.TextBox txtNmFornecedor;
        private System.Windows.Forms.TextBox txtCnpf;
        private DataSets.DSEstadosECidadesTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.Label txtIdFornecedor;
    }
}