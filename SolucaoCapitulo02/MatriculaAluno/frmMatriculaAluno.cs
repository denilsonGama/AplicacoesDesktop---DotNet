using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
                    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty || txtAnoNascimento.Text == String.Empty || txtUltimoAniversario.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);
                //lblIdade.ForeColor = Color.Red;
                lblIdade.Text = "Voce tem: " +  idade.ToString() + " anos";
                
                   
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
            }
        }

        private void txtUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " +
                "NASCIMENTO com 4 digitos", "Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUltimoAniversario.Text != String.Empty && Convert.ToInt32(txtUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO deve ser superior ao do ANO DE NASCIMENTO.", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Cancel = true;
            }
        }
    }
}
