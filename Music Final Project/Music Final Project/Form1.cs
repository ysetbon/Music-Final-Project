using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFugue.Playing;
using NFugue.Theory;
using Sanford.Multimedia.Midi;
using Music_Final_Project.Scripts;

namespace Music_Final_Project
{
    public partial class Form1 : Form
    {
        Player m_Player;
        Queue<ChordToShow> m_ChordQueue;
        ChordToShow m_Current;
        int m_TimeElapsed;

        public Form1()
        {
            m_Player = new Player();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Player.Play("CEG");
        }

        private void LoadQueue(Queue<ChordToShow> i_ChordQueue)
        {
            m_ChordQueue = i_ChordQueue;
        }

        public void ChordSwitch(Object myObject, EventArgs myEventArgs)
        {
            SwitchChordTimer.Stop();

            if (m_ChordQueue != null && m_ChordQueue.Count > 0)
            {
                m_Current = m_ChordQueue.Dequeue();
                CurrentChord.Text = m_Current.Chord;
                NextChord.Text = (m_ChordQueue.Count > 0)? m_ChordQueue.Peek().Chord : "";

                // Sets the timer interval to be till the next note.
                SwitchChordTimer.Interval = m_Current.TimeTillNext;

                // Restarts the timer
                SwitchChordTimer.Enabled = true;
            }
        }

        public void Play()
        {
            if (m_ChordQueue != null && m_ChordQueue.Count > 0)
            {
                m_Current = m_ChordQueue.Dequeue();
                CurrentChord.Text = m_Current.Chord;
                NextChord.Text = (m_ChordQueue.Count > 0) ? m_ChordQueue.Peek().Chord : "";

                SwitchChordTimer.Tick += new EventHandler(ChordSwitch);

                // Sets the timer interval to 5 seconds.
                SwitchChordTimer.Interval = m_Current.TimeTillNext;

                // On display timer
                m_TimeElapsed = m_Current.TimeTillNext;

                SwitchChordTimer.Start();
                TillNextTimer.Start();
            }
        }

        private void TillNextTimer_Tick(object sender, EventArgs e)
        {
            int time = m_TimeElapsed - TillNextTimer.Interval;
            CountDown.Text = (time > 0)? time.ToString() : "0";
        }
    }
}
