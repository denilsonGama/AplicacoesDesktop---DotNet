using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriaPorIdadeV2
{
    public partial class frmCategoriaPorIdadeV2 : Form
    {
        public frmCategoriaPorIdadeV2()
        {
            InitializeComponent();
            lblHoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção!",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataNasc.Value;
                
                int idade = (tsQuantidadeDias.Days / 365);
                lblIdade.ForeColor = Color.Red;
                lblIdade.Text = "Voce tem: " + idade.ToString() + " anos";

                int anoNasc = dtpDataNasc.Value.Year;
                lblAnoNasc.Text = anoNasc.ToString();                             
                

                if (idade > 17)
                {
                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Adulto";

                }
                else if (idade > 13)
                {

                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Infantil A";
                }
                else
                {
                    lblCategoria.Visible = true;
                    lblCategoria.ForeColor = Color.Red;
                    lblCategoria.Text = "Não existe categoria";
                }

                SetUltimoAniversario();
            }

        }
        private void SetUltimoAniversario()
        {
            DateTime dataAniv, dataHoje;
            
            dataAniv = DateTime.Parse(dtpDataNasc.Value.ToString());
            dataHoje = DateTime.Now.Date;

            if (dataAniv.Month < dataHoje.Month)
            {
                lblUltimoAniv.Text = Convert.ToString(dataHoje.Year);
            }
            else if (dataAniv.Month == dataHoje.Month)
            {
                lblUltimoAniv.Text = Convert.ToString(dataHoje.Year);
            }
            
            else
                lblUltimoAniv.Text = Convert.ToString(dataHoje.Year - 1);
        }
               
    }

 }
