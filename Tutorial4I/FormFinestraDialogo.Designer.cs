namespace Tutorial4I
{
    partial class FormFinestraDialogo
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
            this.btnColora = new System.Windows.Forms.Button();
            this.pnlColore = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnColora
            // 
            this.btnColora.Location = new System.Drawing.Point(103, 51);
            this.btnColora.Name = "btnColora";
            this.btnColora.Size = new System.Drawing.Size(75, 23);
            this.btnColora.TabIndex = 0;
            this.btnColora.Text = "Colora";
            this.btnColora.UseVisualStyleBackColor = true;
            this.btnColora.Click += new System.EventHandler(this.btnColora_Click);
            // 
            // pnlColore
            // 
            this.pnlColore.BackColor = System.Drawing.Color.White;
            this.pnlColore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColore.Location = new System.Drawing.Point(44, 106);
            this.pnlColore.Name = "pnlColore";
            this.pnlColore.Size = new System.Drawing.Size(200, 132);
            this.pnlColore.TabIndex = 1;
            // 
            // FormFinestraDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlColore);
            this.Controls.Add(this.btnColora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFinestraDialogo";
            this.Text = "Finestra di Dialogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColora;
        private System.Windows.Forms.Panel pnlColore;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}