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
using Sanford.Multimedia.Midi.UI;

namespace Music_Final_Project
{
    public partial class Form1 : Form
    {
        Queue<ChordToShow> m_ChordQueue;
        ChordToShow m_Current;
        int m_TimeElapsed;

        /* Am = (57,60,64)
            F = (59,62,66)
            C = (60, 64, 67)
            G = (59, 62, 67)
            E = (64, 67, 71)
            D = (62, 66, 69)
            */
        readonly List<ChordProxy> m_ChordList = new List<ChordProxy> { new ChordProxy(new Note[] { new Note(57), new Note(60), new Note(64)}), 
                                                    new ChordProxy(new Note[] { new Note(59), new Note(62), new Note(66)}), 
                                                    new ChordProxy(new Note[] { new Note(60), new Note(64), new Note(67)}), 
                                                    new ChordProxy(new Note[] { new Note(59), new Note(62), new Note(67)}), 
                                                    new ChordProxy(new Note[] { new Note(64), new Note(67), new Note(71)}), 
                                                    new ChordProxy(new Note[] { new Note(62), new Note(66), new Note(69)})};

        //readonly List<string> m_ChordNames = new List<string> {"Am", "F", }

        public Form1()
        {
            // 
            // Chord Buttons
            // 
            for (int i = 0; i < this.m_ChordList.Count; i++)
            {
                ChordButton newButton = new ChordButton(m_ChordList[i]);
                newButton.Location = new System.Drawing.Point(29 + i * 90, 381);
                newButton.Name = m_ChordList[i].ToHumanReadableString();
                newButton.Size = new System.Drawing.Size(70, 76);
                newButton.TabIndex = 0;
                newButton.Text = newButton.Name;
                newButton.UseVisualStyleBackColor = true;
                newButton.MouseDown += (sender, EventArgs) => { ChordKeyDown(sender, EventArgs, newButton.ButtonChord); };
                newButton.MouseUp += (sender, EventArgs) => { ChordKeyUp(sender, EventArgs, newButton.ButtonChord); };
                this.Controls.Add(newButton);
            }

            InitializeComponent();
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

        private OutputDevice outDevice;

        private int outDeviceID = 0;

        protected override void OnLoad(EventArgs e)
        {
            if(OutputDevice.DeviceCount == 0)
            {
                MessageBox.Show("No MIDI output devices available.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Close();
            }
            else
            {
                try
                {
                    outDevice = new OutputDevice(outDeviceID);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Close();
                }
            }

            base.OnLoad(e);
        }

        private void ChordKeyDown(object sender, EventArgs e, Chord i_Chord)
        {
            Note[] notes = i_Chord.GetNotes();

            for (int i = 0; i < notes.Length; i++)
            {
                outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, notes[i].Value, 127));
            }
        }

        private void ChordKeyUp(object sender, EventArgs e, Chord i_Chord)
        {
            Note[] notes = i_Chord.GetNotes();

            for (int i = 0; i < notes.Length; i++)
            {
                outDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, notes[i].Value, 0));
            }
        }
    }
}
