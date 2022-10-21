using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4I
{
    public partial class FormTimer : Form
    {
        int tempo;
        public FormTimer()
        {
            InitializeComponent();
            btnAvvia.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = tempo + "";
            if (tempo == 0)
                timer.Enabled = false;
        }

        private void btnImposta_Click(object sender, EventArgs e)
        {
            bool ctrl = int.TryParse(txtSecondi.Text, out tempo); // converto da stringa a intero
            if (ctrl == false)
            {
                MessageBox.Show("Inserire un numero valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(tempo<=0)
                {
                    MessageBox.Show("Inserire un numero valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnAvvia.Enabled = true;
                    lblTempo.Text = tempo + "";
                    // lblTempo.text = tempo.ToString();
                }
            }

        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btnAvvia.Enabled = false;
        }
    }
}
