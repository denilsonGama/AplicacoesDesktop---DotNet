namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormProdutos
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
            System.Windows.Forms.Label lblIdProduto;
            System.Windows.Forms.Label lblIdGrupo;
            System.Windows.Forms.Label lblNmProduto;
            System.Windows.Forms.Label lblPrecoCompra;
            System.Windows.Forms.Label lblPrecoVenda;
            System.Windows.Forms.Label lblQuantidadeEstoque;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.gruposTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.GruposTableAdapter();
            this.produtosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdProduto = new System.Windows.Forms.Label();
            this.cbxIdGrupoNome = new System.Windows.Forms.ComboBox();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNmProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEsteque = new System.Windows.Forms.TextBox();
            this.gruposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            lblIdProduto = new System.Windows.Forms.Label();
            lblIdGrupo = new System.Windows.Forms.Label();
            lblNmProduto = new System.Windows.Forms.Label();
            lblPrecoCompra = new System.Windows.Forms.Label();
            lblPrecoVenda = new System.Windows.Forms.Label();
            lblQuantidadeEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).BeginInit();
            this.produtosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new System.Drawing.Point(106, 136);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new System.Drawing.Size(77, 17);
            lblIdProduto.TabIndex = 1;
            lblIdProduto.Text = "Id Produto:";
            // 
            // lblIdGrupo
            // 
            lblIdGrupo.AutoSize = true;
            lblIdGrupo.Location = new System.Drawing.Point(106, 165);
            lblIdGrupo.Name = "lblIdGrupo";
            lblIdGrupo.Size = new System.Drawing.Size(67, 17);
            lblIdGrupo.TabIndex = 3;
            lblIdGrupo.Text = "Id Grupo:";
            // 
            // lblNmProduto
            // 
            lblNmProduto.AutoSize = true;
            lblNmProduto.Location = new System.Drawing.Point(106, 196);
            lblNmProduto.Name = "lblNmProduto";
            lblNmProduto.Size = new System.Drawing.Size(75, 17);
            lblNmProduto.TabIndex = 5;
            lblNmProduto.Text = "Descricao:";
            // 
            // lblPrecoCompra
            // 
            lblPrecoCompra.AutoSize = true;
            lblPrecoCompra.Location = new System.Drawing.Point(106, 224);
            lblPrecoCompra.Name = "lblPrecoCompra";
            lblPrecoCompra.Size = new System.Drawing.Size(124, 17);
            lblPrecoCompra.TabIndex = 7;
            lblPrecoCompra.Text = "Preco De Compra:";
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.AutoSize = true;
            lblPrecoVenda.Location = new System.Drawing.Point(106, 252);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new System.Drawing.Size(116, 17);
            lblPrecoVenda.TabIndex = 9;
            lblPrecoVenda.Text = "Preco De Venda:";
            // 
            // lblQuantidadeEstoque
            // 
            lblQuantidadeEstoque.AutoSize = true;
            lblQuantidadeEstoque.Location = new System.Drawing.Point(106, 280);
            lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            lblQuantidadeEstoque.Size = new System.Drawing.Size(142, 17);
            lblQuantidadeEstoque.TabIndex = 11;
            lblQuantidadeEstoque.Text = "Quantidade Estoque:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = this.gruposTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingNavigator
            // 
            this.produtosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtosBindingNavigator.BindingSource = this.produtosBindingSource;
            this.produtosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.produtosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtosBindingNavigatorSaveItem});
            this.produtosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtosBindingNavigator.Name = "produtosBindingNavigator";
            this.produtosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.produtosBindingNavigator.TabIndex = 0;
            this.produtosBindingNavigator.Text = "bindingNavigator1";
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
            // produtosBindingNavigatorSaveItem
            // 
            this.produtosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosBindingNavigatorSaveItem.Image")));
            this.produtosBindingNavigatorSaveItem.Name = "produtosBindingNavigatorSaveItem";
            this.produtosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.produtosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtosBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtosBindingNavigatorSaveItem_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "IdProduto", true));
            this.txtIdProduto.Location = new System.Drawing.Point(254, 136);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(394, 23);
            this.txtIdProduto.TabIndex = 2;
            // 
            // cbxIdGrupoNome
            // 
            this.cbxIdGrupoNome.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "IdGrupo", true));
            this.cbxIdGrupoNome.DataSource = this.gruposBindingSource1;
            this.cbxIdGrupoNome.DisplayMember = "Nome";
            this.cbxIdGrupoNome.FormattingEnabled = true;
            this.cbxIdGrupoNome.Location = new System.Drawing.Point(254, 162);
            this.cbxIdGrupoNome.Name = "cbxIdGrupoNome";
            this.cbxIdGrupoNome.Size = new System.Drawing.Size(217, 24);
            this.cbxIdGrupoNome.TabIndex = 4;
            this.cbxIdGrupoNome.ValueMember = "IdGrupo";
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // txtNmProduto
            // 
            this.txtNmProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Descricao", true));
            this.txtNmProduto.Location = new System.Drawing.Point(254, 193);
            this.txtNmProduto.Name = "txtNmProduto";
            this.txtNmProduto.Size = new System.Drawing.Size(394, 22);
            this.txtNmProduto.TabIndex = 6;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "PrecoDeCompra", true));
            this.txtPrecoCompra.Location = new System.Drawing.Point(254, 221);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(93, 22);
            this.txtPrecoCompra.TabIndex = 8;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "PrecoDeVenda", true));
            this.txtPrecoVenda.Location = new System.Drawing.Point(254, 249);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(93, 22);
            this.txtPrecoVenda.TabIndex = 10;
            // 
            // txtQuantidadeEsteque
            // 
            this.txtQuantidadeEsteque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "QuantidadeEstoque", true));
            this.txtQuantidadeEsteque.Location = new System.Drawing.Point(254, 277);
            this.txtQuantidadeEsteque.Name = "txtQuantidadeEsteque";
            this.txtQuantidadeEsteque.Size = new System.Drawing.Size(93, 22);
            this.txtQuantidadeEsteque.TabIndex = 12;
            // 
            // gruposBindingSource1
            // 
            this.gruposBindingSource1.DataMember = "Grupos";
            this.gruposBindingSource1.DataSource = this.dSEstadosECidades;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblIdProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(lblIdGrupo);
            this.Controls.Add(this.cbxIdGrupoNome);
            this.Controls.Add(lblNmProduto);
            this.Controls.Add(this.txtNmProduto);
            this.Controls.Add(lblPrecoCompra);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(lblPrecoVenda);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(lblQuantidadeEstoque);
            this.Controls.Add(this.txtQuantidadeEsteque);
            this.Controls.Add(this.produtosBindingNavigator);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).EndInit();
            this.produtosBindingNavigator.ResumeLayout(false);
            this.produtosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label txtIdProduto;
        private System.Windows.Forms.ComboBox cbxIdGrupoNome;
        private System.Windows.Forms.TextBox txtNmProduto;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtQuantidadeEsteque;
        private DataSets.DSEstadosECidadesTableAdapters.GruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.BindingSource gruposBindingSource1;
    }
}