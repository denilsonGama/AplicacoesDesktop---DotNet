namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormEstados
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
            System.Windows.Forms.Label lblIdEstado;
            System.Windows.Forms.Label lblUf;
            System.Windows.Forms.Label lblNmEstado;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstados));
            this.estadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdEstado = new System.Windows.Forms.Label();
            this.txtNmUf = new System.Windows.Forms.TextBox();
            this.txtNmEstado = new System.Windows.Forms.TextBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.estadosTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.EstadosTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            lblIdEstado = new System.Windows.Forms.Label();
            lblUf = new System.Windows.Forms.Label();
            lblNmEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingNavigator)).BeginInit();
            this.estadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEstado
            // 
            lblIdEstado.AutoSize = true;
            lblIdEstado.Location = new System.Drawing.Point(12, 73);
            lblIdEstado.Name = "lblIdEstado";
            lblIdEstado.Size = new System.Drawing.Size(71, 17);
            lblIdEstado.TabIndex = 1;
            lblIdEstado.Text = "Id Estado:";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new System.Drawing.Point(12, 102);
            lblUf.Name = "lblUf";
            lblUf.Size = new System.Drawing.Size(34, 17);
            lblUf.TabIndex = 3;
            lblUf.Text = "U.F:";
            // 
            // lblNmEstado
            // 
            lblNmEstado.AutoSize = true;
            lblNmEstado.Location = new System.Drawing.Point(12, 130);
            lblNmEstado.Name = "lblNmEstado";
            lblNmEstado.Size = new System.Drawing.Size(56, 17);
            lblNmEstado.TabIndex = 5;
            lblNmEstado.Text = "Estado:";
            // 
            // estadosBindingNavigator
            // 
            this.estadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estadosBindingNavigator.BindingSource = this.estadosBindingSource;
            this.estadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estadosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.estadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estadosBindingNavigatorSaveItem});
            this.estadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estadosBindingNavigator.Name = "estadosBindingNavigator";
            this.estadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estadosBindingNavigator.Size = new System.Drawing.Size(713, 27);
            this.estadosBindingNavigator.TabIndex = 0;
            this.estadosBindingNavigator.Text = "bindingNavigator1";
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
            // estadosBindingNavigatorSaveItem
            // 
            this.estadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estadosBindingNavigatorSaveItem.Image")));
            this.estadosBindingNavigatorSaveItem.Name = "estadosBindingNavigatorSaveItem";
            this.estadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.estadosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.estadosBindingNavigatorSaveItem_Click);
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Location = new System.Drawing.Point(89, 73);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.Size = new System.Drawing.Size(100, 23);
            this.txtIdEstado.TabIndex = 2;
            // 
            // txtNmUf
            // 
            this.txtNmUf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadosBindingSource, "uf", true));
            this.txtNmUf.Location = new System.Drawing.Point(89, 99);
            this.txtNmUf.Name = "txtNmUf";
            this.txtNmUf.Size = new System.Drawing.Size(100, 22);
            this.txtNmUf.TabIndex = 4;
            // 
            // txtNmEstado
            // 
            this.txtNmEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadosBindingSource, "nome", true));
            this.txtNmEstado.Location = new System.Drawing.Point(89, 127);
            this.txtNmEstado.Name = "txtNmEstado";
            this.txtNmEstado.Size = new System.Drawing.Size(347, 22);
            this.txtNmEstado.TabIndex = 6;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = this.estadosTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(lblIdEstado);
            this.Controls.Add(this.txtIdEstado);
            this.Controls.Add(lblUf);
            this.Controls.Add(this.txtNmUf);
            this.Controls.Add(lblNmEstado);
            this.Controls.Add(this.txtNmEstado);
            this.Controls.Add(this.estadosBindingNavigator);
            this.Name = "FormEstados";
            this.Text = "HomeCity - Cadastro de Estados";
            this.Load += new System.EventHandler(this.FormEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingNavigator)).EndInit();
            this.estadosBindingNavigator.ResumeLayout(false);
            this.estadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estadosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estadosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label txtIdEstado;
        private System.Windows.Forms.TextBox txtNmUf;
        private System.Windows.Forms.TextBox txtNmEstado;
    }
}