namespace Tutorial4I
{
    partial class FormCheckBox
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
            this.gbxMenu = new System.Windows.Forms.GroupBox();
            this.cbxBevande = new System.Windows.Forms.CheckBox();
            this.cbxDolce = new System.Windows.Forms.CheckBox();
            this.cbxSecondo = new System.Windows.Forms.CheckBox();
            this.cbxPrimo = new System.Windows.Forms.CheckBox();
            this.cbxAntipasto = new System.Windows.Forms.CheckBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.txtOrdine = new System.Windows.Forms.TextBox();
            this.gbxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMenu
            // 
            this.gbxMenu.Controls.Add(this.cbxBevande);
            this.gbxMenu.Controls.Add(this.cbxDolce);
            this.gbxMenu.Controls.Add(this.cbxSecondo);
            this.gbxMenu.Controls.Add(this.cbxPrimo);
            this.gbxMenu.Controls.Add(this.cbxAntipasto);
            this.gbxMenu.Location = new System.Drawing.Point(12, 12);
            this.gbxMenu.Name = "gbxMenu";
            this.gbxMenu.Size = new System.Drawing.Size(152, 375);
            this.gbxMenu.TabIndex = 0;
            this.gbxMenu.TabStop = false;
            this.gbxMenu.Text = "Menu";
            // 
            // cbxBevande
            // 
            this.cbxBevande.AutoSize = true;
            this.cbxBevande.Location = new System.Drawing.Point(6, 199);
            this.cbxBevande.Name = "cbxBevande";
            this.cbxBevande.Size = new System.Drawing.Size(69, 17);
            this.cbxBevande.TabIndex = 4;
            this.cbxBevande.Text = "Bevande";
            this.cbxBevande.UseVisualStyleBackColor = true;
            // 
            // cbxDolce
            // 
            this.cbxDolce.AutoSize = true;
            this.cbxDolce.Location = new System.Drawing.Point(6, 159);
            this.cbxDolce.Name = "cbxDolce";
            this.cbxDolce.Size = new System.Drawing.Size(54, 17);
            this.cbxDolce.TabIndex = 3;
            this.cbxDolce.Text = "Dolce";
            this.cbxDolce.UseVisualStyleBackColor = true;
            // 
            // cbxSecondo
            // 
            this.cbxSecondo.AutoSize = true;
            this.cbxSecondo.Location = new System.Drawing.Point(6, 116);
            this.cbxSecondo.Name = "cbxSecondo";
            this.cbxSecondo.Size = new System.Drawing.Size(69, 17);
            this.cbxSecondo.TabIndex = 2;
            this.cbxSecondo.Text = "Secondo";
            this.cbxSecondo.UseVisualStyleBackColor = true;
            // 
            // cbxPrimo
            // 
            this.cbxPrimo.AutoSize = true;
            this.cbxPrimo.Location = new System.Drawing.Point(6, 77);
            this.cbxPrimo.Name = "cbxPrimo";
            this.cbxPrimo.Size = new System.Drawing.Size(52, 17);
            this.cbxPrimo.TabIndex = 1;
            this.cbxPrimo.Text = "Primo";
            this.cbxPrimo.UseVisualStyleBackColor = true;
            // 
            // cbxAntipasto
            // 
            this.cbxAntipasto.AutoSize = true;
            this.cbxAntipasto.Location = new System.Drawing.Point(6, 40);
            this.cbxAntipasto.Name = "cbxAntipasto";
            this.cbxAntipasto.Size = new System.Drawing.Size(70, 17);
            this.cbxAntipasto.TabIndex = 0;
            this.cbxAntipasto.Text = "Antipasto";
            this.cbxAntipasto.UseVisualStyleBackColor = true;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(224, 153);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(75, 23);
            this.btnOrdina.TabIndex = 1;
            this.btnOrdina.Text = "Ordina";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // txtOrdine
            // 
            this.txtOrdine.Location = new System.Drawing.Point(367, 12);
            this.txtOrdine.Multiline = true;
            this.txtOrdine.Name = "txtOrdine";
            this.txtOrdine.Size = new System.Drawing.Size(143, 335);
            this.txtOrdine.TabIndex = 2;
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 399);
            this.Controls.Add(this.txtOrdine);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.gbxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCheckBox";
            this.Text = "CheckBox";
            this.gbxMenu.ResumeLayout(false);
            this.gbxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenu;
        private System.Windows.Forms.CheckBox cbxBevande;
        private System.Windows.Forms.CheckBox cbxDolce;
        private System.Windows.Forms.CheckBox cbxSecondo;
        private System.Windows.Forms.CheckBox cbxPrimo;
        private System.Windows.Forms.CheckBox cbxAntipasto;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.TextBox txtOrdine;
    }
}