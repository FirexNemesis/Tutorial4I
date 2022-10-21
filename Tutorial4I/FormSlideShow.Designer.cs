namespace Tutorial4I
{
    partial class FormSlideShow
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
            this.pbxImmagine = new System.Windows.Forms.PictureBox();
            this.btnSinistra = new System.Windows.Forms.Button();
            this.btnDestra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImmagine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImmagine
            // 
            this.pbxImmagine.Location = new System.Drawing.Point(12, 12);
            this.pbxImmagine.Name = "pbxImmagine";
            this.pbxImmagine.Size = new System.Drawing.Size(300, 300);
            this.pbxImmagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImmagine.TabIndex = 0;
            this.pbxImmagine.TabStop = false;
            // 
            // btnSinistra
            // 
            this.btnSinistra.Location = new System.Drawing.Point(37, 355);
            this.btnSinistra.Name = "btnSinistra";
            this.btnSinistra.Size = new System.Drawing.Size(75, 23);
            this.btnSinistra.TabIndex = 1;
            this.btnSinistra.Text = "<";
            this.btnSinistra.UseVisualStyleBackColor = true;
            this.btnSinistra.Click += new System.EventHandler(this.btnSinistra_Click);
            // 
            // btnDestra
            // 
            this.btnDestra.Location = new System.Drawing.Point(204, 355);
            this.btnDestra.Name = "btnDestra";
            this.btnDestra.Size = new System.Drawing.Size(75, 23);
            this.btnDestra.TabIndex = 2;
            this.btnDestra.Text = ">";
            this.btnDestra.UseVisualStyleBackColor = true;
            this.btnDestra.Click += new System.EventHandler(this.btnDestra_Click);
            // 
            // FormSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 412);
            this.Controls.Add(this.btnDestra);
            this.Controls.Add(this.btnSinistra);
            this.Controls.Add(this.pbxImmagine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSlideShow";
            this.Text = "SlideShow";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImmagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImmagine;
        private System.Windows.Forms.Button btnSinistra;
        private System.Windows.Forms.Button btnDestra;
    }
}