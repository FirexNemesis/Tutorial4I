namespace Tutorial4I
{
    partial class FormAereo
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
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxComandi = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.gbxDirezione = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.gbxVelocita = new System.Windows.Forms.GroupBox();
            this.cbxBonus = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pbxImmagine = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.gbxComandi.SuspendLayout();
            this.gbxDirezione.SuspendLayout();
            this.gbxVelocita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImmagine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // gbxComandi
            // 
            this.gbxComandi.Controls.Add(this.lblSpeed);
            this.gbxComandi.Controls.Add(this.btnReset);
            this.gbxComandi.Controls.Add(this.btnStartStop);
            this.gbxComandi.Controls.Add(this.lblNome);
            this.gbxComandi.Location = new System.Drawing.Point(433, 12);
            this.gbxComandi.Name = "gbxComandi";
            this.gbxComandi.Size = new System.Drawing.Size(139, 124);
            this.gbxComandi.TabIndex = 1;
            this.gbxComandi.TabStop = false;
            this.gbxComandi.Text = "Comandi";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(9, 105);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "label1";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(35, 73);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(35, 43);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start / Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // gbxDirezione
            // 
            this.gbxDirezione.Controls.Add(this.btnDown);
            this.gbxDirezione.Controls.Add(this.btnRight);
            this.gbxDirezione.Controls.Add(this.btnLeft);
            this.gbxDirezione.Controls.Add(this.btnUp);
            this.gbxDirezione.Location = new System.Drawing.Point(13, 13);
            this.gbxDirezione.Name = "gbxDirezione";
            this.gbxDirezione.Size = new System.Drawing.Size(113, 123);
            this.gbxDirezione.TabIndex = 2;
            this.gbxDirezione.TabStop = false;
            this.gbxDirezione.Text = "Direzione";
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(37, 87);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "🢃";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(67, 53);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 30);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "🢂";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(6, 53);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 30);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "🢀";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(37, 17);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 30);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "🢁";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // gbxVelocita
            // 
            this.gbxVelocita.Controls.Add(this.cbxBonus);
            this.gbxVelocita.Controls.Add(this.trackBar1);
            this.gbxVelocita.Location = new System.Drawing.Point(132, 13);
            this.gbxVelocita.Name = "gbxVelocita";
            this.gbxVelocita.Size = new System.Drawing.Size(295, 123);
            this.gbxVelocita.TabIndex = 3;
            this.gbxVelocita.TabStop = false;
            this.gbxVelocita.Text = "Velocità";
            // 
            // cbxBonus
            // 
            this.cbxBonus.AutoSize = true;
            this.cbxBonus.Location = new System.Drawing.Point(7, 77);
            this.cbxBonus.Name = "cbxBonus";
            this.cbxBonus.Size = new System.Drawing.Size(77, 17);
            this.cbxBonus.TabIndex = 1;
            this.cbxBonus.Text = "Bonus (+5)";
            this.cbxBonus.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(7, 26);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            // 
            // pbxImmagine
            // 
            this.pbxImmagine.Location = new System.Drawing.Point(250, 250);
            this.pbxImmagine.Name = "pbxImmagine";
            this.pbxImmagine.Size = new System.Drawing.Size(100, 100);
            this.pbxImmagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImmagine.TabIndex = 4;
            this.pbxImmagine.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // FormAereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pbxImmagine);
            this.Controls.Add(this.gbxVelocita);
            this.Controls.Add(this.gbxDirezione);
            this.Controls.Add(this.gbxComandi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAereo";
            this.Text = "Aereo";
            this.gbxComandi.ResumeLayout(false);
            this.gbxComandi.PerformLayout();
            this.gbxDirezione.ResumeLayout(false);
            this.gbxVelocita.ResumeLayout(false);
            this.gbxVelocita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImmagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbxComandi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.GroupBox gbxDirezione;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox gbxVelocita;
        private System.Windows.Forms.CheckBox cbxBonus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pbxImmagine;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label lblSpeed;
    }
}