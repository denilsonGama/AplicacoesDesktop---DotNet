namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormCidades
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
            System.Windows.Forms.Label lblIdCidade;
            System.Windows.Forms.Label lblNmEstado;
            System.Windows.Forms.Label lblNmCidade;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCidades));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.CidadesTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.estadosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.EstadosTableAdapter();
            this.cidadesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cidadesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdCidade = new System.Windows.Forms.Label();
            this.cbxNmEstado = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNmCidade = new System.Windows.Forms.TextBox();
            lblIdCidade = new System.Windows.Forms.Label();
            lblNmEstado = new System.Windows.Forms.Label();
            lblNmCidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingNavigator)).BeginInit();
            this.cidadesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCidade
            // 
            lblIdCidade.AutoSize = true;
            lblIdCidade.Location = new System.Drawing.Point(201, 161);
            lblIdCidade.Name = "lblIdCidade";
            lblIdCidade.Size = new System.Drawing.Size(71, 17);
            lblIdCidade.TabIndex = 1;
            lblIdCidade.Text = "Id Cidade:";
            // 
            // lblNmEstado
            // 
            lblNmEstado.AutoSize = true;
            lblNmEstado.Location = new System.Drawing.Point(201, 190);
            lblNmEstado.Name = "lblNmEstado";
            lblNmEstado.Size = new System.Drawing.Size(71, 17);
            lblNmEstado.TabIndex = 3;
            lblNmEstado.Text = "Id Estado:";
            // 
            // lblNmCidade
            // 
            lblNmCidade.AutoSize = true;
            lblNmCidade.Location = new System.Drawing.Point(201, 221);
            lblNmCidade.Name = "lblNmCidade";
            lblNmCidade.Size = new System.Drawing.Size(49, 17);
            lblNmCidade.TabIndex = 5;
            lblNmCidade.Text = "Nome:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = this.cidadesTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EnderecosTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = this.estadosTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // cidadesBindingNavigator
            // 
            this.cidadesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cidadesBindingNavigator.BindingSource = this.cidadesBindingSource;
            this.cidadesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cidadesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cidadesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cidadesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cidadesBindingNavigatorSaveItem});
            this.cidadesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cidadesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cidadesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cidadesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cidadesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cidadesBindingNavigator.Name = "cidadesBindingNavigator";
            this.cidadesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cidadesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.cidadesBindingNavigator.TabIndex = 0;
            this.cidadesBindingNavigator.Text = "bindingNavigator1";
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
            // cidadesBindingNavigatorSaveItem
            // 
            this.cidadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cidadesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cidadesBindingNavigatorSaveItem.Image")));
            this.cidadesBindingNavigatorSaveItem.Name = "cidadesBindingNavigatorSaveItem";
            this.cidadesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cidadesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cidadesBindingNavigatorSaveItem.Click += new System.EventHandler(this.cidadesBindingNavigatorSaveItem_Click_1);
            // 
            // txtIdCidade
            // 
            this.txtIdCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "IdCidade", true));
            this.txtIdCidade.Location = new System.Drawing.Point(278, 161);
            this.txtIdCidade.Name = "txtIdCidade";
            this.txtIdCidade.Size = new System.Drawing.Size(307, 23);
            this.txtIdCidade.TabIndex = 2;
            // 
            // cbxNmEstado
            // 
            this.cbxNmEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "IdEstado", true));
            this.cbxNmEstado.DataSource = this.estadosBindingSource;
            this.cbxNmEstado.DisplayMember = "Nome";
            this.cbxNmEstado.FormattingEnabled = true;
            this.cbxNmEstado.Location = new System.Drawing.Point(278, 187);
            this.cbxNmEstado.Name = "cbxNmEstado";
            this.cbxNmEstado.Size = new System.Drawing.Size(151, 24);
            this.cbxNmEstado.TabIndex = 4;
            this.cbxNmEstado.ValueMember = "IdEstado";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // txtNmCidade
            // 
            this.txtNmCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "Nome", true));
            this.txtNmCidade.Location = new System.Drawing.Point(278, 218);
            this.txtNmCidade.Name = "txtNmCidade";
            this.txtNmCidade.Size = new System.Drawing.Size(307, 22);
            this.txtNmCidade.TabIndex = 6;
            // 
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblIdCidade);
            this.Controls.Add(this.txtIdCidade);
            this.Controls.Add(lblNmEstado);
            this.Controls.Add(this.cbxNmEstado);
            this.Controls.Add(lblNmCidade);
            this.Controls.Add(this.txtNmCidade);
            this.Controls.Add(this.cidadesBindingNavigator);
            this.Name = "FormCidades";
            this.Text = "FormCidades";
            this.Load += new System.EventHandler(this.FormCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingNavigator)).EndInit();
            this.cidadesBindingNavigator.ResumeLayout(false);
            this.cidadesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cidadesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cidadesBindingNavigatorSaveItem;
        private DataSets.DSEstadosECidadesTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.Label txtIdCidade;
        private System.Windows.Forms.ComboBox cbxNmEstado;
        private System.Windows.Forms.TextBox txtNmCidade;
        private System.Windows.Forms.BindingSource estadosBindingSource;
    }
}