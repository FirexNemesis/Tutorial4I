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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            const string NUOVARIGA = "\r\n"; // per andare a capo

            txtOrdine.Clear();
            // txtOrdine.Text = "";
            // txtOrdine.Text = string.Empty;+
            if (cbxAntipasto.Checked)
                txtOrdine.AppendText("Antipasto" + NUOVARIGA);
            if (cbxPrimo.Checked)
                txtOrdine.AppendText("Primo" + NUOVARIGA);
            if (cbxSecondo.Checked)
                txtOrdine.AppendText("Secondo" + NUOVARIGA);
            if (cbxDolce.Checked)
                txtOrdine.AppendText("Dolce" + NUOVARIGA);
            if (cbxBevande.Checked)
                txtOrdine.AppendText("Bevande" + NUOVARIGA);

            cbxAntipasto.Checked = false;
            cbxPrimo.Checked = false;
            cbxSecondo.Checked = false;
            cbxDolce.Checked = false;
            cbxBevande.Checked = false;
        }
    }
}
