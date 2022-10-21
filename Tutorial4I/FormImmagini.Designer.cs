namespace Tutorial4I
{
    partial class FormImmagini
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
            this.gbxImmagini = new System.Windows.Forms.GroupBox();
            this.rbtMeme1 = new System.Windows.Forms.RadioButton();
            this.rbtMeme2 = new System.Windows.Forms.RadioButton();
            this.rbtMeme3 = new System.Windows.Forms.RadioButton();
            this.rbtMeme4 = new System.Windows.Forms.RadioButton();
            this.rbtMeme5 = new System.Windows.Forms.RadioButton();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.pbxMeme = new System.Windows.Forms.PictureBox();
            this.gbxImmagini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMeme)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxImmagini
            // 
            this.gbxImmagini.Controls.Add(this.rbtMeme5);
            this.gbxImmagini.Controls.Add(this.rbtMeme4);
            this.gbxImmagini.Controls.Add(this.rbtMeme3);
            this.gbxImmagini.Controls.Add(this.rbtMeme2);
            this.gbxImmagini.Controls.Add(this.rbtMeme1);
            this.gbxImmagini.Location = new System.Drawing.Point(32, 12);
            this.gbxImmagini.Name = "gbxImmagini";
            this.gbxImmagini.Size = new System.Drawing.Size(200, 466);
            this.gbxImmagini.TabIndex = 0;
            this.gbxImmagini.TabStop = false;
            this.gbxImmagini.Text = "Meme";
            // 
            // rbtMeme1
            // 
            this.rbtMeme1.AutoSize = true;
            this.rbtMeme1.Location = new System.Drawing.Point(23, 56);
            this.rbtMeme1.Name = "rbtMeme1";
            this.rbtMeme1.Size = new System.Drawing.Size(60, 17);
            this.rbtMeme1.TabIndex = 0;
            this.rbtMeme1.TabStop = true;
            this.rbtMeme1.Text = "Meme1";
            this.rbtMeme1.UseVisualStyleBackColor = true;
            // 
            // rbtMeme2
            // 
            this.rbtMeme2.AutoSize = true;
            this.rbtMeme2.Location = new System.Drawing.Point(23, 95);
            this.rbtMeme2.Name = "rbtMeme2";
            this.rbtMeme2.Size = new System.Drawing.Size(60, 17);
            this.rbtMeme2.TabIndex = 1;
            this.rbtMeme2.TabStop = true;
            this.rbtMeme2.Text = "Meme2";
            this.rbtMeme2.UseVisualStyleBackColor = true;
            // 
            // rbtMeme3
            // 
            this.rbtMeme3.AutoSize = true;
            this.rbtMeme3.Location = new System.Drawing.Point(23, 135);
            this.rbtMeme3.Name = "rbtMeme3";
            this.rbtMeme3.Size = new System.Drawing.Size(60, 17);
            this.rbtMeme3.TabIndex = 2;
            this.rbtMeme3.TabStop = true;
            this.rbtMeme3.Text = "Meme3";
            this.rbtMeme3.UseVisualStyleBackColor = true;
            // 
            // rbtMeme4
            // 
            this.rbtMeme4.AutoSize = true;
            this.rbtMeme4.Location = new System.Drawing.Point(23, 174);
            this.rbtMeme4.Name = "rbtMeme4";
            this.rbtMeme4.Size = new System.Drawing.Size(60, 17);
            this.rbtMeme4.TabIndex = 3;
            this.rbtMeme4.TabStop = true;
            this.rbtMeme4.Text = "Meme4";
            this.rbtMeme4.UseVisualStyleBackColor = true;
            // 
            // rbtMeme5
            // 
            this.rbtMeme5.AutoSize = true;
            this.rbtMeme5.Location = new System.Drawing.Point(23, 212);
            this.rbtMeme5.Name = "rbtMeme5";
            this.rbtMeme5.Size = new System.Drawing.Size(60, 17);
            this.rbtMeme5.TabIndex = 4;
            this.rbtMeme5.TabStop = true;
            this.rbtMeme5.Text = "Meme5";
            this.rbtMeme5.UseVisualStyleBackColor = true;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(274, 144);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 1;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // pbxMeme
            // 
            this.pbxMeme.Location = new System.Drawing.Point(406, 37);
            this.pbxMeme.Name = "pbxMeme";
            this.pbxMeme.Size = new System.Drawing.Size(300, 300);
            this.pbxMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMeme.TabIndex = 2;
            this.pbxMeme.TabStop = false;
            // 
            // FormImmagini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 399);
            this.Controls.Add(this.pbxMeme);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.gbxImmagini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormImmagini";
            this.Text = "Immagini";
            this.gbxImmagini.ResumeLayout(false);
            this.gbxImmagini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxImmagini;
        private System.Windows.Forms.RadioButton rbtMeme5;
        private System.Windows.Forms.RadioButton rbtMeme4;
        private System.Windows.Forms.RadioButton rbtMeme3;
        private System.Windows.Forms.RadioButton rbtMeme2;
        private System.Windows.Forms.RadioButton rbtMeme1;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.PictureBox pbxMeme;
    }
}