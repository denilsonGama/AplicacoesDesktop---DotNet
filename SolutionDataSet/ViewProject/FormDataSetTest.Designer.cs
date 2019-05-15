namespace ViewProject
{
    partial class FormDataSetTest
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
            this.btnCriarDataSet = new System.Windows.Forms.Button();
            this.btnInserirDados = new System.Windows.Forms.Button();
            this.btnVisualizarXML = new System.Windows.Forms.Button();
            this.btnControlesVisuais = new System.Windows.Forms.Button();
            this.tcResultados = new System.Windows.Forms.TabControl();
            this.tpgXML = new System.Windows.Forms.TabPage();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tpgComboEGrid = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tcResultados.SuspendLayout();
            this.tpgXML.SuspendLayout();
            this.tpgComboEGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarDataSet
            // 
            this.btnCriarDataSet.Location = new System.Drawing.Point(16, 15);
            this.btnCriarDataSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarDataSet.Name = "btnCriarDataSet";
            this.btnCriarDataSet.Size = new System.Drawing.Size(156, 28);
            this.btnCriarDataSet.TabIndex = 0;
            this.btnCriarDataSet.Text = "Criar DataSet";
            this.btnCriarDataSet.UseVisualStyleBackColor = true;
            this.btnCriarDataSet.Click += new System.EventHandler(this.btnCriarDataSet_Click);
            // 
            // btnInserirDados
            // 
            this.btnInserirDados.Location = new System.Drawing.Point(180, 15);
            this.btnInserirDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirDados.Name = "btnInserirDados";
            this.btnInserirDados.Size = new System.Drawing.Size(156, 28);
            this.btnInserirDados.TabIndex = 1;
            this.btnInserirDados.Text = "Inserir dados";
            this.btnInserirDados.UseVisualStyleBackColor = true;
            this.btnInserirDados.Click += new System.EventHandler(this.btnInserirDados_Click);
            // 
            // btnVisualizarXML
            // 
            this.btnVisualizarXML.Location = new System.Drawing.Point(344, 15);
            this.btnVisualizarXML.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizarXML.Name = "btnVisualizarXML";
            this.btnVisualizarXML.Size = new System.Drawing.Size(156, 28);
            this.btnVisualizarXML.TabIndex = 2;
            this.btnVisualizarXML.Text = "Visualizar XML";
            this.btnVisualizarXML.UseVisualStyleBackColor = true;
            this.btnVisualizarXML.Click += new System.EventHandler(this.btnVisualizarXML_Click);
            // 
            // btnControlesVisuais
            // 
            this.btnControlesVisuais.Location = new System.Drawing.Point(508, 15);
            this.btnControlesVisuais.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlesVisuais.Name = "btnControlesVisuais";
            this.btnControlesVisuais.Size = new System.Drawing.Size(156, 28);
            this.btnControlesVisuais.TabIndex = 3;
            this.btnControlesVisuais.Text = "Controles Visuais";
            this.btnControlesVisuais.UseVisualStyleBackColor = true;
            this.btnControlesVisuais.Click += new System.EventHandler(this.btnControlesVisuais_Click);
            // 
            // tcResultados
            // 
            this.tcResultados.Controls.Add(this.tpgXML);
            this.tcResultados.Controls.Add(this.tpgComboEGrid);
            this.tcResultados.Location = new System.Drawing.Point(16, 50);
            this.tcResultados.Margin = new System.Windows.Forms.Padding(4);
            this.tcResultados.Name = "tcResultados";
            this.tcResultados.SelectedIndex = 0;
            this.tcResultados.Size = new System.Drawing.Size(648, 256);
            this.tcResultados.TabIndex = 4;
            // 
            // tpgXML
            // 
            this.tpgXML.Controls.Add(this.txtXML);
            this.tpgXML.Location = new System.Drawing.Point(4, 25);
            this.tpgXML.Margin = new System.Windows.Forms.Padding(4);
            this.tpgXML.Name = "tpgXML";
            this.tpgXML.Padding = new System.Windows.Forms.Padding(4);
            this.tpgXML.Size = new System.Drawing.Size(640, 227);
            this.tpgXML.TabIndex = 0;
            this.tpgXML.Text = "Dados em XML";
            this.tpgXML.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXML.Location = new System.Drawing.Point(4, 4);
            this.txtXML.Margin = new System.Windows.Forms.Padding(4);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXML.Size = new System.Drawing.Size(632, 219);
            this.txtXML.TabIndex = 0;
            // 
            // tpgComboEGrid
            // 
            this.tpgComboEGrid.Controls.Add(this.tableLayoutPanel1);
            this.tpgComboEGrid.Location = new System.Drawing.Point(4, 25);
            this.tpgComboEGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tpgComboEGrid.Name = "tpgComboEGrid";
            this.tpgComboEGrid.Padding = new System.Windows.Forms.Padding(4);
            this.tpgComboEGrid.Size = new System.Drawing.Size(640, 227);
            this.tpgComboEGrid.TabIndex = 1;
            this.tpgComboEGrid.Text = "Dados em Controles";
            this.tpgComboEGrid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbxEstados, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCidades, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 219);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cbxEstados
            // 
            this.cbxEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(68, 4);
            this.cbxEstados.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(560, 24);
            this.cbxEstados.TabIndex = 1;
            // 
            // dgvCidades
            // 
            this.dgvCidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCidades, 2);
            this.dgvCidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCidades.Location = new System.Drawing.Point(4, 36);
            this.dgvCidades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(624, 179);
            this.dgvCidades.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(4, 7);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado:";
            // 
            // FormDataSetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 321);
            this.Controls.Add(this.tcResultados);
            this.Controls.Add(this.btnControlesVisuais);
            this.Controls.Add(this.btnVisualizarXML);
            this.Controls.Add(this.btnInserirDados);
            this.Controls.Add(this.btnCriarDataSet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataSetTest";
            this.Text = "Testes com DataSet e seus componentes";
            this.tcResultados.ResumeLayout(false);
            this.tpgXML.ResumeLayout(false);
            this.tpgXML.PerformLayout();
            this.tpgComboEGrid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarDataSet;
        private System.Windows.Forms.Button btnInserirDados;
        private System.Windows.Forms.Button btnVisualizarXML;
        private System.Windows.Forms.Button btnControlesVisuais;
        private System.Windows.Forms.TabControl tcResultados;
        private System.Windows.Forms.TabPage tpgXML;
        private System.Windows.Forms.TabPage tpgComboEGrid;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

