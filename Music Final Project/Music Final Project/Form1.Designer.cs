﻿using System.Drawing;
using System.Windows.Forms;
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SongList = new System.Windows.Forms.ListBox();
            this.SongListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LyricsTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(225, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Chord:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(379, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(225, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Chord:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentChord
            // 
            this.CurrentChord.AutoSize = true;
            this.CurrentChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CurrentChord.Location = new System.Drawing.Point(8, 56);
            this.CurrentChord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentChord.MinimumSize = new System.Drawing.Size(225, 244);
            this.CurrentChord.Name = "CurrentChord";
            this.CurrentChord.Size = new System.Drawing.Size(225, 244);
            this.CurrentChord.TabIndex = 3;
            this.CurrentChord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextChord
            // 
            this.NextChord.AutoSize = true;
            this.NextChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NextChord.Location = new System.Drawing.Point(379, 56);
            this.NextChord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NextChord.MinimumSize = new System.Drawing.Size(225, 244);
            this.NextChord.Name = "NextChord";
            this.NextChord.Size = new System.Drawing.Size(225, 244);
            this.NextChord.TabIndex = 4;
            this.NextChord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(249, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Till Next:";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CountDown.Location = new System.Drawing.Point(247, 199);
            this.CountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountDown.MinimumSize = new System.Drawing.Size(112, 81);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(112, 81);
            this.CountDown.TabIndex = 6;
            this.CountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TillNextTimer
            // 
            this.TillNextTimer.Tick += new System.EventHandler(this.TillNextTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(249, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 102);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CountDown);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NextChord);
            this.panel1.Controls.Add(this.CurrentChord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 393);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SongList);
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 394);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MaximumSize = new System.Drawing.Size(164, 61);
            this.label3.MinimumSize = new System.Drawing.Size(164, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose a song:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongList
            // 
            this.SongList.DataSource = this.SongListBindingSource;
            this.SongList.DisplayMember = "SongName";
            this.SongList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SongList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 25;
            this.SongList.Location = new System.Drawing.Point(-2, 63);
            this.SongList.Margin = new System.Windows.Forms.Padding(2);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(167, 329);
            this.SongList.TabIndex = 0;
            // 
            // SongListBindingSource
            // 
            this.SongListBindingSource.DataSource = typeof(Music_Final_Project.Scripts.Song);
            // 
            // LyricsTextBox
            // 
            this.LyricsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LyricsTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyricsTextBox.Location = new System.Drawing.Point(1, 393);
            this.LyricsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LyricsTextBox.Name = "LyricsTextBox";
            this.LyricsTextBox.ReadOnly = true;
            this.LyricsTextBox.Size = new System.Drawing.Size(781, 271);
            this.LyricsTextBox.TabIndex = 11;
            this.LyricsTextBox.Text = "";
            this.LyricsTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(780, 603);
            this.Controls.Add(this.LyricsTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Choremember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(SongList.Items[e.Index].ToString(), SongList.Font, SongList.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(SongList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentChord;
        private System.Windows.Forms.Label NextChord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.Timer SwitchChordTimer;
        private System.Windows.Forms.Timer TillNextTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private ListBox SongList;
        private Label label3;
        private BindingSource SongListBindingSource;
        private RichTextBox LyricsTextBox;
    }
}

