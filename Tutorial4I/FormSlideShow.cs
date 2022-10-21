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
    public partial class FormSlideShow : Form
    {
        string[] immagini = { "planeDown.jpg", "planeLeft.jpg", "planeRight.jpg", "planeUp.jpg" };
        int index;

        public FormSlideShow()
        {
            InitializeComponent();
            index = 0;
            // calcolare il percorso dell'immagine
            string path = Application.StartupPath + "\\images\\" + immagini[index];
            // caricare l'immagine nella picture box
            pbxImmagine.Image = Image.FromFile(path);
        }

        private void btnDestra_Click(object sender, EventArgs e)
        {
            index++;
            if (index == immagini.Length)
                index = 0;

            string path = Application.StartupPath + "\\images\\" + immagini[index];
            pbxImmagine.Image = Image.FromFile(path);
        }

        private void btnSinistra_Click(object sender, EventArgs e)
        {
            index--;
            if(index==-1)
                index = immagini.Length - 1;

            string path = Application.StartupPath + "\\images\\" + immagini[index];
            pbxImmagine.Image = Image.FromFile(path);
        }
    }
}
