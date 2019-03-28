namespace TrocaDeValores
{
    partial class frmTrocaDeValores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.btnTrocarValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(72, 24);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(70, 22);
            this.txtPrimeiroValor.TabIndex = 0;
            this.txtPrimeiroValor.TextChanged += new System.EventHandler(this.txtPrimeiroValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(235, 24);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(70, 22);
            this.txtSegundoValor.TabIndex = 3;
            // 
            // btnTrocarValor
            // 
            this.btnTrocarValor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTrocarValor.Location = new System.Drawing.Point(120, 71);
            this.btnTrocarValor.Name = "btnTrocarValor";
            this.btnTrocarValor.Size = new System.Drawing.Size(130, 40);
            this.btnTrocarValor.TabIndex = 4;
            this.btnTrocarValor.Text = "Trocar Valores";
            this.btnTrocarValor.UseVisualStyleBackColor = true;
            this.btnTrocarValor.Click += new System.EventHandler(this.btnTrocarValor_Click);
            // 
            // frmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 123);
            this.Controls.Add(this.btnTrocarValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimeiroValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTrocaDeValores";
            this.Text = "Troca de Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Button btnTrocarValor;
    }
}

