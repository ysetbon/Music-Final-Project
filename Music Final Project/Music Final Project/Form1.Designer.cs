namespace Music_Final_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentChord = new System.Windows.Forms.Label();
            this.NextChord = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Label();
            this.SwitchChordTimer = new System.Windows.Forms.Timer(this.components);
            this.TillNextTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MinimumSize = new System.Drawing.Size(300, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Chord:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.MinimumSize = new System.Drawing.Size(300, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Chord:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentChord
            // 
            this.CurrentChord.AutoSize = true;
            this.CurrentChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CurrentChord.Location = new System.Drawing.Point(12, 69);
            this.CurrentChord.MinimumSize = new System.Drawing.Size(300, 300);
            this.CurrentChord.Name = "CurrentChord";
            this.CurrentChord.Size = new System.Drawing.Size(300, 300);
            this.CurrentChord.TabIndex = 3;
            this.CurrentChord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextChord
            // 
            this.NextChord.AutoSize = true;
            this.NextChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NextChord.Location = new System.Drawing.Point(506, 69);
            this.NextChord.MinimumSize = new System.Drawing.Size(300, 300);
            this.NextChord.Name = "NextChord";
            this.NextChord.Size = new System.Drawing.Size(300, 300);
            this.NextChord.TabIndex = 4;
            this.NextChord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(342, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Till Next:";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CountDown.Location = new System.Drawing.Point(334, 217);
            this.CountDown.MinimumSize = new System.Drawing.Size(150, 100);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(150, 100);
            this.CountDown.TabIndex = 6;
            this.CountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TillNextTimer
            // 
            this.TillNextTimer.Tick += new System.EventHandler(this.TillNextTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(818, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NextChord);
            this.Controls.Add(this.CurrentChord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Choremember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentChord;
        private System.Windows.Forms.Label NextChord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.Timer SwitchChordTimer;
        private System.Windows.Forms.Timer TillNextTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

