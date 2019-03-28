namespace ConsumoEnergiaCondominio
{
    partial class FormConsumo
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
            this.pnlConsumoEnergia = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblNrCasa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlConsumoEnergia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsumoEnergia
            // 
            this.pnlConsumoEnergia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlConsumoEnergia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlConsumoEnergia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsumoEnergia.Controls.Add(this.btnLimpar);
            this.pnlConsumoEnergia.Controls.Add(this.lblResultado);
            this.pnlConsumoEnergia.Controls.Add(this.btnProcessar);
            this.pnlConsumoEnergia.Controls.Add(this.dgvLeituras);
            this.pnlConsumoEnergia.Controls.Add(this.txtConsumo);
            this.pnlConsumoEnergia.Controls.Add(this.txtCasa);
            this.pnlConsumoEnergia.Controls.Add(this.btnRegistrar);
            this.pnlConsumoEnergia.Controls.Add(this.lblConsumo);
            this.pnlConsumoEnergia.Controls.Add(this.lblNrCasa);
            this.pnlConsumoEnergia.Location = new System.Drawing.Point(12, 11);
            this.pnlConsumoEnergia.Name = "pnlConsumoEnergia";
            this.pnlConsumoEnergia.Size = new System.Drawing.Size(617, 526);
            this.pnlConsumoEnergia.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(249, 472);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(339, 26);
            this.lblResultado.TabIndex = 8;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(31, 467);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(190, 39);
            this.btnProcessar.TabIndex = 6;
            this.btnProcessar.Text = "Processar Dados";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(30, 88);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.RowTemplate.Height = 24;
            this.dgvLeituras.Size = new System.Drawing.Size(558, 361);
            this.dgvLeituras.TabIndex = 7;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(315, 33);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(104, 31);
            this.txtConsumo.TabIndex = 4;
            // 
            // txtCasa
            // 
            this.txtCasa.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCasa.Location = new System.Drawing.Point(118, 33);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(67, 31);
            this.txtCasa.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(435, 33);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 30);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(206, 36);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(100, 26);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "&Consumo:";
            // 
            // lblNrCasa
            // 
            this.lblNrCasa.AutoSize = true;
            this.lblNrCasa.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrCasa.Location = new System.Drawing.Point(26, 38);
            this.lblNrCasa.Name = "lblNrCasa";
            this.lblNrCasa.Size = new System.Drawing.Size(92, 26);
            this.lblNrCasa.TabIndex = 0;
            this.lblNrCasa.Text = "&Nr. Casa:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(31, 467);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(190, 39);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Inserir Registros";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FormConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 549);
            this.Controls.Add(this.pnlConsumoEnergia);
            this.Name = "FormConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo de Energia de um Condomimio";
            this.pnlConsumoEnergia.ResumeLayout(false);
            this.pnlConsumoEnergia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsumoEnergia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblNrCasa;
        private System.Windows.Forms.Button btnLimpar;
    }
}