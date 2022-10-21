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
    public partial class FormImmagini : Form
    {
        public FormImmagini()
        {
            InitializeComponent();
            pbxMeme.Image = Properties.Resources.img01; // carico l'immagine di default
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if(rbtMeme1.Checked)
                pbxMeme.Image = Properties.Resources.img01;
            else if(rbtMeme2.Checked)
                pbxMeme.Image = Properties.Resources.img02;
            else if (rbtMeme3.Checked)
                pbxMeme.Image = Properties.Resources.img03;
            else if (rbtMeme4.Checked)
                pbxMeme.Image = Properties.Resources.img04;
            else if (rbtMeme5.Checked)
                pbxMeme.Image = Properties.Resources.img05;
        }
    }
}
