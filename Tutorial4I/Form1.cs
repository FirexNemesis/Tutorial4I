using System;
using System.Windows.Forms;

namespace Tutorial4I
{
    public partial class Form1 : Form
    {
        // metodo costruttore
        // 1. stesso nome della classe
        // 2. non ha tipo di ritorno, neanche void
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSaluto_Click(object sender, EventArgs e)
        {

        }

        private void btnSaluta_Click(object sender, EventArgs e)
        {
            lblSaluto.Text = "Ciao 4I";
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRettangolo_Click(object sender, EventArgs e)
        {
            // 1. creare la formRettangolo
            // 2. visualizzarla
            FormRettangolo form = new FormRettangolo();
            form.ShowDialog();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            FormComboBox form = new FormComboBox();
            form.ShowDialog();
        }

        private void btnFinestraDialogo_Click(object sender, EventArgs e)
        {
            FormFinestraDialogo form = new FormFinestraDialogo();
            form.ShowDialog();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            FormCheckBox form = new FormCheckBox();
            form.ShowDialog();
        }

        private void btnImmagini_Click(object sender, EventArgs e)
        {
            FormImmagini form = new FormImmagini();
            form.ShowDialog();
        }

        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            FormSlideShow form = new FormSlideShow();
            form.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            FormTimer form = new FormTimer();
            form.ShowDialog();
        }

        private void btnAereo_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Inserire il nome del giocatore", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Common.NomeGiocatore = txtNome.Text;
                FormAereo form = new FormAereo(txtNome.Text);
                form.ShowDialog();
            }
            
        }

    }
}
