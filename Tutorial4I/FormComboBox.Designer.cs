namespace Tutorial4I
{
    partial class FormComboBox
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
            this.cbxColori = new System.Windows.Forms.ComboBox();
            this.pnlColore = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnColora
            // 
            this.btnColora.Location = new System.Drawing.Point(101, 83);
            this.btnColora.Name = "btnColora";
            this.btnColora.Size = new System.Drawing.Size(75, 23);
            this.btnColora.TabIndex = 0;
            this.btnColora.Text = "Colora";
            this.btnColora.UseVisualStyleBackColor = true;
            this.btnColora.Click += new System.EventHandler(this.btnColora_Click);
            // 
            // cbxColori
            // 
            this.cbxColori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColori.FormattingEnabled = true;
            this.cbxColori.Items.AddRange(new object[] {
            "Rosso",
            "Verde",
            "Blu",
            "Giallo"});
            this.cbxColori.Location = new System.Drawing.Point(39, 28);
            this.cbxColori.Name = "cbxColori";
            this.cbxColori.Size = new System.Drawing.Size(212, 21);
            this.cbxColori.TabIndex = 1;
            // 
            // pnlColore
            // 
            this.pnlColore.BackColor = System.Drawing.Color.White;
            this.pnlColore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColore.Location = new System.Drawing.Point(39, 146);
            this.pnlColore.Name = "pnlColore";
            this.pnlColore.Size = new System.Drawing.Size(212, 103);
            this.pnlColore.TabIndex = 2;
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlColore);
            this.Controls.Add(this.cbxColori);
            this.Controls.Add(this.btnColora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColora;
        private System.Windows.Forms.ComboBox cbxColori;
        private System.Windows.Forms.Panel pnlColore;
    }
}