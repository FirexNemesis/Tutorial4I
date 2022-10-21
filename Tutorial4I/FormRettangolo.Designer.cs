namespace Tutorial4I
{
    partial class FormRettangolo
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
            this.btnCalcola = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltezza = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(167, 217);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(248, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(329, 217);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(64, 52);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Base";
            // 
            // lblAltezza
            // 
            this.lblAltezza.AutoSize = true;
            this.lblAltezza.Location = new System.Drawing.Point(207, 52);
            this.lblAltezza.Name = "lblAltezza";
            this.lblAltezza.Size = new System.Drawing.Size(41, 13);
            this.lblAltezza.TabIndex = 4;
            this.lblAltezza.Text = "Altezza";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(67, 110);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(67, 161);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Text = "Perimetro;";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(67, 69);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 7;
            this.txtBase.Text = "1";
            this.txtBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBase_KeyPress);
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(207, 68);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 8;
            this.txtAltezza.Text = "1";
            this.txtAltezza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBase_KeyPress);
            // 
            // FormRettangolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 290);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltezza);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRettangolo";
            this.Text = "Rettangolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltezza;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
    }
}