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
        BindingList<Song> m_SongList = new BindingList<Song>() { new Song(null, "The Chainsmokers & Coldplay:Something Just Like This") };
        Queue<ChordToShow> m_ChordQueue;
        ChordToShow m_Current;
        int m_TimeElapsed;
         
        readonly List<ChordProxy> m_MajorChords = new List<ChordProxy> 
                                                    { new ChordProxy("A4maj"),
                                                      new ChordProxy("B4maj"),
                                                      new ChordProxy("C4maj"),
                                                      new ChordProxy("D4maj"),
                                                      new ChordProxy("E4maj"),
                                                      new ChordProxy("F4maj"),
                                                      new ChordProxy("G4maj")};

        readonly List<ChordProxy> m_MinorChords = new List<ChordProxy> 
                                                    { new ChordProxy("A4min"),
                                                      new ChordProxy("B4min"),
                                                      new ChordProxy("C4min"),
                                                      new ChordProxy("D4min"),
                                                      new ChordProxy("E4min"),
                                                      new ChordProxy("F4min"),
                                                      new ChordProxy("G4min")};
                                                     

        //readonly List<string> m_ChordNames = new List<string> {"Am", "F", }

       

        public Form1()
        {
            InitializeComponent();
            InitializeSongListSelection();

            // 
            // Chord Buttons
            // 
            for (int i = 0; i < this.m_MajorChords.Count; i++)
            {
                ChordButton newButton = new ChordButton(m_MajorChords[i]);
                newButton.Location = new System.Drawing.Point(20 + i * 80, 350);
                newButton.Name = m_MajorChords[i].ToHumanReadableString();
                newButton.Size = new System.Drawing.Size(60, 46);
                newButton.TabIndex = 0;
                newButton.Text = newButton.Name;
                newButton.UseVisualStyleBackColor = true;
                newButton.MouseDown += (sender, EventArgs) => { ChordKeyDown(sender, EventArgs, newButton.ButtonChord); };
                newButton.MouseUp += (sender, EventArgs) => { ChordKeyUp(sender, EventArgs, newButton.ButtonChord); };
                this.panel1.Controls.Add(newButton);
            }

            for (int i = 0; i < this.m_MinorChords.Count; i++)
            {
                ChordButton newButton = new ChordButton(m_MinorChords[i]);
                newButton.Location = new System.Drawing.Point(20 + i * 80, 300);
                newButton.Name = m_MinorChords[i].ToHumanReadableString();
                newButton.Size = new System.Drawing.Size(60, 46);
                newButton.TabIndex = 0;
                newButton.Text = newButton.Name;
                newButton.UseVisualStyleBackColor = true;
                newButton.MouseDown += (sender, EventArgs) => { ChordKeyDown(sender, EventArgs, newButton.ButtonChord); };
                newButton.MouseUp += (sender, EventArgs) => { ChordKeyUp(sender, EventArgs, newButton.ButtonChord); };
                this.panel1.Controls.Add(newButton);
            }
            
        }

        /// <summary>
        /// Initializes the song selection list box
        /// </summary>
        private void InitializeSongListSelection()
        {
            SongListBindingSource.DataSource = this.m_SongList;
            SongList.ClearSelected();
            SongList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);

            SongList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            SongList.MeasureItem += lst_MeasureItem;
            SongList.DrawItem += lst_DrawItem;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongList.SelectedIndex != -1)
            {
                Song selectedSong = SongList.SelectedItem as Song;
                //LoadQueue(new Queue<ChordToShow>(selectedSong.SongChords));
                LyricsTextBox.Text = LyricsGetter.GetLyricsForSong(selectedSong.SongName);
            }
        }
    }
}
