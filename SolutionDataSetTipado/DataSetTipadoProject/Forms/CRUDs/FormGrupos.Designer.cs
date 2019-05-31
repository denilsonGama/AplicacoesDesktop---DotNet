namespace DataSetTipadoProject.Forms.CRUDs
{
    partial class FormGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupos));
            System.Windows.Forms.Label LblIdGrupo;
            System.Windows.Forms.Label lblNmGrupo;
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.GruposTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.gruposBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gruposBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdGrupo = new System.Windows.Forms.Label();
            this.TxtNmGrupo = new System.Windows.Forms.TextBox();
            LblIdGrupo = new System.Windows.Forms.Label();
            lblNmGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingNavigator)).BeginInit();
            this.gruposBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = this.gruposTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gruposBindingNavigator
            // 
            this.gruposBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gruposBindingNavigator.BindingSource = this.gruposBindingSource;
            this.gruposBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gruposBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gruposBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gruposBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gruposBindingNavigatorSaveItem});
            this.gruposBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gruposBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gruposBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gruposBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gruposBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gruposBindingNavigator.Name = "gruposBindingNavigator";
            this.gruposBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gruposBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.gruposBindingNavigator.TabIndex = 0;
            this.gruposBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // gruposBindingNavigatorSaveItem
            // 
            this.gruposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gruposBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gruposBindingNavigatorSaveItem.Image")));
            this.gruposBindingNavigatorSaveItem.Name = "gruposBindingNavigatorSaveItem";
            this.gruposBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.gruposBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.gruposBindingNavigatorSaveItem.Click += new System.EventHandler(this.gruposBindingNavigatorSaveItem_Click);
            // 
            // LblIdGrupo
            // 
            LblIdGrupo.AutoSize = true;
            LblIdGrupo.Location = new System.Drawing.Point(173, 161);
            LblIdGrupo.Name = "LblIdGrupo";
            LblIdGrupo.Size = new System.Drawing.Size(67, 17);
            LblIdGrupo.TabIndex = 1;
            LblIdGrupo.Text = "Id Grupo:";
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "IdGrupo", true));
            this.txtIdGrupo.Location = new System.Drawing.Point(246, 161);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(300, 23);
            this.txtIdGrupo.TabIndex = 2;
            // 
            // lblNmGrupo
            // 
            lblNmGrupo.AutoSize = true;
            lblNmGrupo.Location = new System.Drawing.Point(173, 190);
            lblNmGrupo.Name = "lblNmGrupo";
            lblNmGrupo.Size = new System.Drawing.Size(49, 17);
            lblNmGrupo.TabIndex = 3;
            lblNmGrupo.Text = "Nome:";
            // 
            // TxtNmGrupo
            // 
            this.TxtNmGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Nome", true));
            this.TxtNmGrupo.Location = new System.Drawing.Point(246, 187);
            this.TxtNmGrupo.Name = "TxtNmGrupo";
            this.TxtNmGrupo.Size = new System.Drawing.Size(300, 22);
            this.TxtNmGrupo.TabIndex = 4;
            // 
            // FormGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(LblIdGrupo);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(lblNmGrupo);
            this.Controls.Add(this.TxtNmGrupo);
            this.Controls.Add(this.gruposBindingNavigator);
            this.Name = "FormGrupos";
            this.Text = "FormGrupos";
            this.Load += new System.EventHandler(this.FormGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingNavigator)).EndInit();
            this.gruposBindingNavigator.ResumeLayout(false);
            this.gruposBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.GruposTableAdapter gruposTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gruposBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gruposBindingNavigatorSaveItem;
        private System.Windows.Forms.Label txtIdGrupo;
        private System.Windows.Forms.TextBox TxtNmGrupo;
    }
}