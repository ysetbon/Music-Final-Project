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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentChord = new System.Windows.Forms.Label();
            this.NextChord = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Label();
            this.SwitchChordTimer = new System.Windows.Forms.Timer(this.components);
            this.TillNextTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.MinimumSize = new System.Drawing.Size(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Chord:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(490, 18);
            this.label2.MinimumSize = new System.Drawing.Size(300, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Chord:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentChord
            // 
            this.CurrentChord.AutoSize = true;
            this.CurrentChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CurrentChord.Location = new System.Drawing.Point(22, 57);
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
            this.NextChord.Location = new System.Drawing.Point(490, 57);
            this.NextChord.MinimumSize = new System.Drawing.Size(300, 300);
            this.NextChord.Name = "NextChord";
            this.NextChord.Size = new System.Drawing.Size(300, 300);
            this.NextChord.TabIndex = 4;
            this.NextChord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(357, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Till Next:";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CountDown.Location = new System.Drawing.Point(334, 196);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 484);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NextChord);
            this.Controls.Add(this.CurrentChord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

