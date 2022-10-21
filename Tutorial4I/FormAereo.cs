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
    public partial class FormAereo : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 1;
        int speedBonus = 0;
        string[] immagini = { "planeDown.jpg", "planeLeft.jpg", "planeRight.jpg", "planeUp.jpg" };
        int index;
        // overloading
        /*
        public FormAereo()
        {
            InitializeComponent();
            lblNome.Text = Common.NomeGiocatore;
            index = 0;
            // calcolare il percorso dell'immagine
            string path = Application.StartupPath + "\\images\\" + immagini[index];
            // caricare l'immagine nella picture box
            pbxImmagine.Image = Image.FromFile(path);
        }
      */
        public FormAereo(string nome)
        {
            InitializeComponent();
            lblNome.Text = "Ciao "+nome;
            index = 3;
            string path = Application.StartupPath + "\\images\\" + immagini[index];
            pbxImmagine.Image = Image.FromFile(path);
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;
            btnReset.Enabled = false;
            trackBar1.Enabled = false;
            cbxBonus.Enabled = false;
        }
        
        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (cbxBonus.Checked)
                speed = trackBar1.Value+5;
            else if (!cbxBonus.Checked)
                speed = trackBar1.Value;
            if(moveLeft==true && pbxImmagine.Left > 5)
            {
                index = 1;
                string path = Application.StartupPath + "\\images\\" + immagini[index];
                pbxImmagine.Image = Image.FromFile(path);
                pbxImmagine.Left -= speed;
            }
            if (moveRight == true && pbxImmagine.Left < 472)
            {
                index = 2;
                string path = Application.StartupPath + "\\images\\" + immagini[index];
                pbxImmagine.Image = Image.FromFile(path);
                pbxImmagine.Left += speed;
            }
            if (moveUp == true && pbxImmagine.Top > 140)
            {
                index = 3;
                string path = Application.StartupPath + "\\images\\" + immagini[index];
                pbxImmagine.Image = Image.FromFile(path);
                pbxImmagine.Top -= speed;
            }
            if (moveDown == true && pbxImmagine.Top < 459)
            {
                index = 0;
                string path = Application.StartupPath + "\\images\\" + immagini[index];
                pbxImmagine.Image = Image.FromFile(path);
                pbxImmagine.Top += speed;
            }
            lblSpeed.Text = "velocità "+speed;

        }
        
        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            moveUp = true;
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            moveUp = false;
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            moveLeft = true;
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            moveDown = true;
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            moveDown = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbxImmagine.Top = 250;
            pbxImmagine.Left = 250;
            string path = Application.StartupPath + "\\images\\" + immagini[3];
            pbxImmagine.Image = Image.FromFile(path);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnUp.Enabled)
                btnUp.Enabled = false;
            else
                btnUp.Enabled = true;

            if (btnDown.Enabled)
                btnDown.Enabled = false;
            else
                btnDown.Enabled = true;

            if (btnLeft.Enabled)
                btnLeft.Enabled = false;
            else
                btnLeft.Enabled = true;

            if (btnRight.Enabled)
                btnRight.Enabled = false;
            else
                btnRight.Enabled = true;

            if (btnReset.Enabled)
                btnReset.Enabled = false;
            else
                btnReset.Enabled = true;

            if (trackBar1.Enabled)
                trackBar1.Enabled = false;
            else
                trackBar1.Enabled = true;

            if (cbxBonus.Enabled)
                cbxBonus.Enabled = false;
            else
                cbxBonus.Enabled = true;
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeft = false;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            moveRight = true;
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            moveRight = false;
        }

    }
}
