namespace Tutorial4I
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaluta = new System.Windows.Forms.Button();
            this.lblSaluto = new System.Windows.Forms.Label();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnRettangolo = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnFinestraDialogo = new System.Windows.Forms.Button();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnImmagini = new System.Windows.Forms.Button();
            this.btnSlideShow = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnAereo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaluta
            // 
            this.btnSaluta.Location = new System.Drawing.Point(12, 12);
            this.btnSaluta.Name = "btnSaluta";
            this.btnSaluta.Size = new System.Drawing.Size(75, 23);
            this.btnSaluta.TabIndex = 0;
            this.btnSaluta.Text = "Ciao";
            this.btnSaluta.UseVisualStyleBackColor = true;
            this.btnSaluta.Click += new System.EventHandler(this.btnSaluta_Click);
            // 
            // lblSaluto
            // 
            this.lblSaluto.AutoSize = true;
            this.lblSaluto.Location = new System.Drawing.Point(93, 17);
            this.lblSaluto.Name = "lblSaluto";
            this.lblSaluto.Size = new System.Drawing.Size(35, 13);
            this.lblSaluto.TabIndex = 1;
            this.lblSaluto.Text = "label1";
            this.lblSaluto.Click += new System.EventHandler(this.lblSaluto_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(208, 70);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnRettangolo
            // 
            this.btnRettangolo.Location = new System.Drawing.Point(12, 41);
            this.btnRettangolo.Name = "btnRettangolo";
            this.btnRettangolo.Size = new System.Drawing.Size(75, 23);
            this.btnRettangolo.TabIndex = 3;
            this.btnRettangolo.Text = "Rettangolo";
            this.btnRettangolo.UseVisualStyleBackColor = true;
            this.btnRettangolo.Click += new System.EventHandler(this.btnRettangolo_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(12, 70);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(75, 23);
            this.btnComboBox.TabIndex = 4;
            this.btnComboBox.Text = "ComboBox";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // btnFinestraDialogo
            // 
            this.btnFinestraDialogo.Location = new System.Drawing.Point(13, 100);
            this.btnFinestraDialogo.Name = "btnFinestraDialogo";
            this.btnFinestraDialogo.Size = new System.Drawing.Size(115, 23);
            this.btnFinestraDialogo.TabIndex = 5;
            this.btnFinestraDialogo.Text = "Finestra di dialogo";
            this.btnFinestraDialogo.UseVisualStyleBackColor = true;
            this.btnFinestraDialogo.Click += new System.EventHandler(this.btnFinestraDialogo_Click);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(13, 130);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBox.TabIndex = 6;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnImmagini
            // 
            this.btnImmagini.Location = new System.Drawing.Point(13, 159);
            this.btnImmagini.Name = "btnImmagini";
            this.btnImmagini.Size = new System.Drawing.Size(75, 23);
            this.btnImmagini.TabIndex = 7;
            this.btnImmagini.Text = "Immagini";
            this.btnImmagini.UseVisualStyleBackColor = true;
            this.btnImmagini.Click += new System.EventHandler(this.btnImmagini_Click);
            // 
            // btnSlideShow
            // 
            this.btnSlideShow.Location = new System.Drawing.Point(13, 189);
            this.btnSlideShow.Name = "btnSlideShow";
            this.btnSlideShow.Size = new System.Drawing.Size(75, 23);
            this.btnSlideShow.TabIndex = 8;
            this.btnSlideShow.Text = "SlideShow";
            this.btnSlideShow.UseVisualStyleBackColor = true;
            this.btnSlideShow.Click += new System.EventHandler(this.btnSlideShow_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(13, 219);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnAereo
            // 
            this.btnAereo.Location = new System.Drawing.Point(13, 249);
            this.btnAereo.Name = "btnAereo";
            this.btnAereo.Size = new System.Drawing.Size(75, 23);
            this.btnAereo.TabIndex = 10;
            this.btnAereo.Text = "Aereo";
            this.btnAereo.UseVisualStyleBackColor = true;
            this.btnAereo.Click += new System.EventHandler(this.btnAereo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 250);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 282);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAereo);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnSlideShow);
            this.Controls.Add(this.btnImmagini);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.btnFinestraDialogo);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnRettangolo);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lblSaluto);
            this.Controls.Add(this.btnSaluta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaluta;
        private System.Windows.Forms.Label lblSaluto;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnRettangolo;
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnFinestraDialogo;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnImmagini;
        private System.Windows.Forms.Button btnSlideShow;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnAereo;
        private System.Windows.Forms.TextBox txtNome;
    }
}

