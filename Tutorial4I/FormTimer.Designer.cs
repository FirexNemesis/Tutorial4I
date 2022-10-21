namespace Tutorial4I
{
    partial class FormTimer
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
            this.components = new System.ComponentModel.Container();
            this.lblSecondi = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtSecondi = new System.Windows.Forms.TextBox();
            this.btnImposta = new System.Windows.Forms.Button();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSecondi
            // 
            this.lblSecondi.AutoSize = true;
            this.lblSecondi.Location = new System.Drawing.Point(13, 13);
            this.lblSecondi.Name = "lblSecondi";
            this.lblSecondi.Size = new System.Drawing.Size(46, 13);
            this.lblSecondi.TabIndex = 0;
            this.lblSecondi.Text = "Secondi";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(105, 170);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(52, 55);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "0";
            // 
            // txtSecondi
            // 
            this.txtSecondi.Location = new System.Drawing.Point(13, 30);
            this.txtSecondi.Name = "txtSecondi";
            this.txtSecondi.Size = new System.Drawing.Size(100, 20);
            this.txtSecondi.TabIndex = 2;
            this.txtSecondi.Text = "0";
            // 
            // btnImposta
            // 
            this.btnImposta.Location = new System.Drawing.Point(16, 80);
            this.btnImposta.Name = "btnImposta";
            this.btnImposta.Size = new System.Drawing.Size(75, 46);
            this.btnImposta.TabIndex = 3;
            this.btnImposta.Text = "Imposta";
            this.btnImposta.UseVisualStyleBackColor = true;
            this.btnImposta.Click += new System.EventHandler(this.btnImposta_Click);
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(159, 80);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 46);
            this.btnAvvia.TabIndex = 4;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.btnImposta);
            this.Controls.Add(this.txtSecondi);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblSecondi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTimer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecondi;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtSecondi;
        private System.Windows.Forms.Button btnImposta;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Timer timer;
    }
}