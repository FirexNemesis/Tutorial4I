using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tutorial4I
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }
        private void ColoraPannello(Color colore)
        {
            pnlColore.BackColor = colore;
            pnlColore.Refresh();
        }
        private void btnColora_Click(object sender, EventArgs e)
        {
            int index = cbxColori.SelectedIndex;
            switch(index)
            {
                case 0:
                    // coloro il pannello di rosso
                    ColoraPannello(Color.Red);
                    break;
                case 1:
                    // coloro il pannello di verde
                    ColoraPannello(Color.Green);
                    break;
                case 2:
                    // coloro il pannello di blu
                    ColoraPannello(Color.Blue);
                    break;
                case 3:
                    // coloro il pannello di giallo
                    ColoraPannello(Color.Yellow);
                    break;
                case -1:
                    MessageBox.Show("Selezionare un colore.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
