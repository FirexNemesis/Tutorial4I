using System;
using System.Windows.Forms;

namespace Tutorial4I
{
    public partial class FormRettangolo : Form
    {
        public FormRettangolo()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            bool conversioneBase, conversioneAltezza;
            double rbase, raltezza, area, perimetro;
            string b = txtBase.Text;
            string a = txtAltezza.Text;
            // convertire le variabili "a" e "b" da string a double
            conversioneBase = double.TryParse(b, out rbase);
            conversioneAltezza = double.TryParse(a, out raltezza);

            // se i dati non sono corretti visualizzo un messaggio di errore
            if(!conversioneBase || !conversioneAltezza)
            {
                MessageBox.Show("Base e altezza errati.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(rbase<=0 || raltezza<=0)
                {
                    MessageBox.Show("Base e altezza errati.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    area = rbase * raltezza;
                    perimetro = (rbase + raltezza) * 2;

                    lblArea.Text = "Area vale: "+area;
                    lblPerimetro.Text = "Il perimetro vale: " + perimetro;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // resettare le due textbox
            txtBase.Text = "";
            txtAltezza.Text = "";
            // resettare le due label
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
