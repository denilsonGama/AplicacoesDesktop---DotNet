namespace CalculoSalarioIdeal
{
    partial class frmCalculoSalario
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
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnTurnoMatutino = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbnTurnoNoturno = new System.Windows.Forms.RadioButton();
            this.rbnTurnoVespertino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.ttpSalarioMinimo = new System.Windows.Forms.ToolTip(this.components);
            this.ttpHorasTrabalhadas = new System.Windows.Forms.ToolTip(this.components);
            this.gbxTurno.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(297, 127);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(124, 32);
            this.txtHorasTrabalhadas.TabIndex = 11;
            this.txtHorasTrabalhadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpHorasTrabalhadas.SetToolTip(this.txtHorasTrabalhadas, "Informe o total de Horas Trabalhadas.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salário Minimo:";
            // 
            // rbnTurnoMatutino
            // 
            this.rbnTurnoMatutino.AutoSize = true;
            this.rbnTurnoMatutino.Location = new System.Drawing.Point(33, 57);
            this.rbnTurnoMatutino.Name = "rbnTurnoMatutino";
            this.rbnTurnoMatutino.Size = new System.Drawing.Size(117, 31);
            this.rbnTurnoMatutino.TabIndex = 0;
            this.rbnTurnoMatutino.TabStop = true;
            this.rbnTurnoMatutino.Text = "Matutino";
            this.rbnTurnoMatutino.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbnTurnoNoturno);
            this.gbxTurno.Controls.Add(this.rbnTurnoVespertino);
            this.gbxTurno.Controls.Add(this.rbnTurnoMatutino);
            this.gbxTurno.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTurno.Location = new System.Drawing.Point(440, 67);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(190, 225);
            this.gbxTurno.TabIndex = 13;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbnTurnoNoturno
            // 
            this.rbnTurnoNoturno.AutoSize = true;
            this.rbnTurnoNoturno.Location = new System.Drawing.Point(33, 169);
            this.rbnTurnoNoturno.Name = "rbnTurnoNoturno";
            this.rbnTurnoNoturno.Size = new System.Drawing.Size(111, 31);
            this.rbnTurnoNoturno.TabIndex = 2;
            this.rbnTurnoNoturno.TabStop = true;
            this.rbnTurnoNoturno.Text = "Noturno";
            this.rbnTurnoNoturno.UseVisualStyleBackColor = true;
            // 
            // rbnTurnoVespertino
            // 
            this.rbnTurnoVespertino.AutoSize = true;
            this.rbnTurnoVespertino.Location = new System.Drawing.Point(33, 110);
            this.rbnTurnoVespertino.Name = "rbnTurnoVespertino";
            this.rbnTurnoVespertino.Size = new System.Drawing.Size(136, 31);
            this.rbnTurnoVespertino.TabIndex = 1;
            this.rbnTurnoVespertino.TabStop = true;
            this.rbnTurnoVespertino.Text = "Vespertino";
            this.rbnTurnoVespertino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(440, 518);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(190, 46);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 20;
            this.lbxResumo.Location = new System.Drawing.Point(47, 313);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResumo.Size = new System.Drawing.Size(583, 184);
            this.lbxResumo.TabIndex = 14;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(297, 75);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(124, 32);
            this.txtSalarioMinimo.TabIndex = 10;
            this.txtSalarioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpSalarioMinimo.SetToolTip(this.txtSalarioMinimo, "Informe o Valor atual para o Salário Minimo.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbnVeterano);
            this.gbxCategoria.Controls.Add(this.rbnCalouro);
            this.gbxCategoria.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoria.Location = new System.Drawing.Point(48, 188);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(373, 104);
            this.gbxCategoria.TabIndex = 12;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Location = new System.Drawing.Point(179, 47);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(121, 31);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(37, 47);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(107, 31);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(47, 520);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(374, 40);
            this.txtSituacaoEstagiario.TabIndex = 16;
            this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttpSalarioMinimo
            // 
            this.ttpSalarioMinimo.IsBalloon = true;
            this.ttpSalarioMinimo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpSalarioMinimo.ToolTipTitle = "Ajuda";
            // 
            // ttpHorasTrabalhadas
            // 
            this.ttpHorasTrabalhadas.IsBalloon = true;
            this.ttpHorasTrabalhadas.ToolTipTitle = "Ajuda";
            // 
            // frmCalculoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 579);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxCategoria);
            this.Name = "frmCalculoSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Salário";
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnTurnoMatutino;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbnTurnoNoturno;
        private System.Windows.Forms.RadioButton rbnTurnoVespertino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.ToolTip ttpSalarioMinimo;
        private System.Windows.Forms.ToolTip ttpHorasTrabalhadas;
    }
}