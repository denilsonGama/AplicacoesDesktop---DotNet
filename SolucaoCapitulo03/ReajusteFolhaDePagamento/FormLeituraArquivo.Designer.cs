namespace ReajusteFolhaDePagamento
{
    partial class FormLeituraArquivo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentualDoReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblTotalR = new System.Windows.Forms.Label();
            this.lblTotalCR = new System.Windows.Forms.Label();
            this.lblTotalSR = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvLeitura);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.txtArquivo);
            this.panel1.Controls.Add(this.btnAbrirArquivo);
            this.panel1.Location = new System.Drawing.Point(14, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 426);
            this.panel1.TabIndex = 0;
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.AllowUserToAddRows = false;
            this.dgvLeitura.AllowUserToDeleteRows = false;
            this.dgvLeitura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(14, 116);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(728, 277);
            this.dgvLeitura.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualDoReajuste, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalR, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 59);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblPercentualDoReajuste
            // 
            this.lblPercentualDoReajuste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentualDoReajuste.AutoSize = true;
            this.lblPercentualDoReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDoReajuste.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPercentualDoReajuste.Location = new System.Drawing.Point(594, 34);
            this.lblPercentualDoReajuste.Name = "lblPercentualDoReajuste";
            this.lblPercentualDoReajuste.Size = new System.Drawing.Size(0, 20);
            this.lblPercentualDoReajuste.TabIndex = 5;
            this.lblPercentualDoReajuste.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalComReajuste.Location = new System.Drawing.Point(345, 34);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(0, 20);
            this.lblTotalComReajuste.TabIndex = 4;
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalR
            // 
            this.lblTotalR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalR.AutoSize = true;
            this.lblTotalR.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalR.Location = new System.Drawing.Point(481, 3);
            this.lblTotalR.Name = "lblTotalR";
            this.lblTotalR.Size = new System.Drawing.Size(227, 24);
            this.lblTotalR.TabIndex = 2;
            this.lblTotalR.Text = "Percentual de Reajuste";
            this.lblTotalR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCR
            // 
            this.lblTotalCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalCR.AutoSize = true;
            this.lblTotalCR.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCR.Location = new System.Drawing.Point(251, 3);
            this.lblTotalCR.Name = "lblTotalCR";
            this.lblTotalCR.Size = new System.Drawing.Size(189, 24);
            this.lblTotalCR.TabIndex = 1;
            this.lblTotalCR.Text = "Total com Reajuste";
            this.lblTotalCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSR
            // 
            this.lblTotalSR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalSR.AutoSize = true;
            this.lblTotalSR.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSR.Location = new System.Drawing.Point(21, 3);
            this.lblTotalSR.Name = "lblTotalSR";
            this.lblTotalSR.Size = new System.Drawing.Size(188, 24);
            this.lblTotalSR.TabIndex = 0;
            this.lblTotalSR.Text = "Total sem Reajuste";
            this.lblTotalSR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(115, 34);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(0, 20);
            this.lblTotalSemReajuste.TabIndex = 3;
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(14, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(624, 28);
            this.txtArquivo.TabIndex = 2;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrirArquivo.FlatAppearance.BorderSize = 3;
            this.btnAbrirArquivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivo.Location = new System.Drawing.Point(660, 10);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(83, 34);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "...";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "DadosFolha";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de";
            // 
            // FormLeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.panel1);
            this.Name = "FormLeituraArquivo";
            this.Text = "Leitura de Arquivo para Reajuste de Salários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblTotalSR;
        private System.Windows.Forms.Label lblTotalR;
        private System.Windows.Forms.Label lblTotalCR;
        private System.Windows.Forms.Label lblPercentualDoReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.DataGridView dgvLeitura;
    }
}