using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergiaCondominio
{
        public partial class FormConsumo : Form
        {
            private IList<Leitura> leituras = new BindingList<Leitura>();
            private BindingSource leituraSource = new BindingSource();
            public FormConsumo()
            {
                InitializeComponent();
                leituraSource.DataSource = leituras;
                dgvLeituras.DataSource = leituraSource;
                

            }
            private void BtnRegistrar_Click(object sender, EventArgs e)
            {
            
                if (txtCasa.Text != String.Empty && txtConsumo.Text != String.Empty)
                    RegistraConsumo(txtCasa.Text,
                    Convert.ToDouble(txtConsumo.Text));
            else
            {
                    MessageBox.Show("Informe o Nr da Casa e o seu Consumo", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCasa.Focus();
            }
        }
        
            private void RegistraConsumo(string casa, double consumo)
            {
                Leitura leitura = new Leitura(casa, consumo);
                if (leituras.Contains(leitura))
                {
                    MessageBox.Show("A leitura para esta casa já foi registrada", "Alerta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCasa.Text = "";
                    txtCasa.Focus();
                    
                }
                else
                {
                    this.leituras.Add(leitura);
                    InicializaFormulario();
                }
            }
            private void InicializaFormulario()
            {
                txtCasa.Clear();
                txtConsumo.Clear();
                txtCasa.Focus();
            }
        private void BtnProcessar_Click(object sender,
        EventArgs e)
        {
            ProcessarLeituras(dgvLeituras);            
        }

        private void BtnLimpar_Click(object sender,EventArgs e)
        {
            LimparGrid();
        }

        private void ProcessarLeituras(DataGridView dgv)

        {
            try
            {
                if (dgv != null)
                {

                    DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];
                    this.leituras.Add(new Leitura("Total", 0));
                    for (int i = 0; i < 3; i++)
                    {
                        dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                        dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                        dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                    }
                    double totalConsumo = 0, totalDesconto = 0;                    

                    foreach (var leitura in leituras)
                        {
                            totalConsumo += leitura.Consumo;
                            totalDesconto += leitura.Desconto;

                            dgv[0, dgv.Rows.Count - 1].Value = "Total";
                            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo;
                            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto;
                            lblResultado.Text = "Total consumo líquido: " + (totalConsumo - totalDesconto).ToString("N");

                            btnProcessar.Visible = false;
                            btnLimpar.Visible = true;
                        }
                    }
                
            }
            
            catch (Exception)

            {
                MessageBox.Show("Voce precisa registrar leituras antes do processamento", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCasa.Focus();
            }

        }

        private void LimparGrid()
        {
            this.dgvLeituras.Rows.Clear();
            txtCasa.Focus();
            btnProcessar.Visible = true;
            btnLimpar.Visible = false;
            lblResultado.Text = "";
            
        }
    }

}