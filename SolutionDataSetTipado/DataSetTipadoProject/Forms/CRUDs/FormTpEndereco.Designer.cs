namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormTpEndereco
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
            System.Windows.Forms.Label idTpEnderecoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTpEndereco));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.tp_EnderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp_EnderecoTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.Tp_EnderecoTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.tp_EnderecoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tp_EnderecoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTpEnderecoLabel1 = new System.Windows.Forms.Label();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            idTpEnderecoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_EnderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_EnderecoBindingNavigator)).BeginInit();
            this.tp_EnderecoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTpEnderecoLabel
            // 
            idTpEnderecoLabel.AutoSize = true;
            idTpEnderecoLabel.Location = new System.Drawing.Point(85, 105);
            idTpEnderecoLabel.Name = "idTpEnderecoLabel";
            idTpEnderecoLabel.Size = new System.Drawing.Size(88, 17);
            idTpEnderecoLabel.TabIndex = 1;
            idTpEnderecoLabel.Text = "Código Tipo:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(85, 134);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(101, 17);
            tipoLabel.TabIndex = 3;
            tipoLabel.Text = "Nome do Tipo:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp_EnderecoBindingSource
            // 
            this.tp_EnderecoBindingSource.DataMember = "Tp_Endereco";
            this.tp_EnderecoBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // tp_EnderecoTableAdapter
            // 
            this.tp_EnderecoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NotasDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.Tp_EnderecoTableAdapter = this.tp_EnderecoTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tp_EnderecoBindingNavigator
            // 
            this.tp_EnderecoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tp_EnderecoBindingNavigator.BindingSource = this.tp_EnderecoBindingSource;
            this.tp_EnderecoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tp_EnderecoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tp_EnderecoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tp_EnderecoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tp_EnderecoBindingNavigatorSaveItem});
            this.tp_EnderecoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tp_EnderecoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tp_EnderecoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tp_EnderecoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tp_EnderecoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tp_EnderecoBindingNavigator.Name = "tp_EnderecoBindingNavigator";
            this.tp_EnderecoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tp_EnderecoBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tp_EnderecoBindingNavigator.TabIndex = 0;
            this.tp_EnderecoBindingNavigator.Text = "bindingNavigator1";
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
            // tp_EnderecoBindingNavigatorSaveItem
            // 
            this.tp_EnderecoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tp_EnderecoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tp_EnderecoBindingNavigatorSaveItem.Image")));
            this.tp_EnderecoBindingNavigatorSaveItem.Name = "tp_EnderecoBindingNavigatorSaveItem";
            this.tp_EnderecoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tp_EnderecoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tp_EnderecoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tp_EnderecoBindingNavigatorSaveItem_Click_1);
            // 
            // idTpEnderecoLabel1
            // 
            this.idTpEnderecoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tp_EnderecoBindingSource, "IdTpEndereco", true));
            this.idTpEnderecoLabel1.Location = new System.Drawing.Point(200, 105);
            this.idTpEnderecoLabel1.Name = "idTpEnderecoLabel1";
            this.idTpEnderecoLabel1.Size = new System.Drawing.Size(243, 23);
            this.idTpEnderecoLabel1.TabIndex = 2;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tp_EnderecoBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(200, 131);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(243, 22);
            this.tipoTextBox.TabIndex = 4;
            // 
            // FormTpEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idTpEnderecoLabel);
            this.Controls.Add(this.idTpEnderecoLabel1);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.tp_EnderecoBindingNavigator);
            this.Name = "FormTpEndereco";
            this.Text = "Cadastro de Tipo de Endereço";
            this.Load += new System.EventHandler(this.FormTpEndereco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_EnderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_EnderecoBindingNavigator)).EndInit();
            this.tp_EnderecoBindingNavigator.ResumeLayout(false);
            this.tp_EnderecoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource tp_EnderecoBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.Tp_EnderecoTableAdapter tp_EnderecoTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tp_EnderecoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tp_EnderecoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idTpEnderecoLabel1;
        private System.Windows.Forms.TextBox tipoTextBox;
    }
}