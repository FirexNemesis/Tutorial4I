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
    public partial class FormFinestraDialogo : Form
    {
        public FormFinestraDialogo()
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
            DialogResult result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                ColoraPannello(colorDialog.Color);
            }
        }
    }
}
