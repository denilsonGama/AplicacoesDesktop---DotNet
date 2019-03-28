using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalarioIdeal
{
    public partial class frmCalculoSalario : Form
    {
        public frmCalculoSalario()
        {
            InitializeComponent();
            btnCalcular.Text = "Calcular";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
                RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
                
                LimparListBox();
                btnCalcular.Text = "Calcular";

                RealizarProcessamento(rbnTurno, rbnCategoria,
                    Convert.ToDouble(txtHorasTrabalhadas.Text),
                    Convert.ToDouble(txtSalarioMinimo.Text));
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha os dados novamente", "Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtSalarioMinimo.Text = "";
                txtHorasTrabalhadas.Text = "";
                txtSalarioMinimo.Focus();


            }
        }
            private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double horasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;

            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double valorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMinimo.Text) * 0.03;
                    break;
            }

            return valorCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;

            return valorGratificacao;
        }

        private static double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":

                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.02;
                    break;

                case "Veterano":

                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }
            return valorImposto;
        }

        private double GetValorAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (valorSalarioMinimo / 2)))

                valorAuxilioAlimentacao = (valorSalarioBruto / 3);

            return valorAuxilioAlimentacao;
        }

        private void ApresentarResultados(
            double valorCoeficiente,
            double valorSalarioBruto,
            double valorImposto,
            double valorGratificacao,
            double valorAuxilioAlimentacao,
            double valorSalarioLiquido)
        {
            txtSituacaoEstagiario.Text = GetSituacaoEstagiario(valorSalarioLiquido);

            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Valor do coeficiente: ", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Salário bruto: ", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Valor do imposto: ", valorImposto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Valor da gratificação: ", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Valor auxilio alimentação: ", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,24:C}", "Salário líquido: ", valorSalarioLiquido));

            FormatarTextBox();
        }

        private string GetSituacaoEstagiario(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";
        }

        private void LimparListBox()
        {
            //lbxResumo.Text = "";
            lbxResumo.Items.Clear();            
         }

        private void FormatarTextBox()
        {
            //Formata saida digitada em valores
            double SalarioMinimo = Convert.ToDouble(txtSalarioMinimo.Text);
            txtSalarioMinimo.Text = SalarioMinimo.ToString("C");
            btnCalcular.Text = "Novo Calculo";

        }
    }
}
