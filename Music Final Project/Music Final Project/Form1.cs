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
using System.Runtime.InteropServices;

namespace Music_Final_Project
{
    public partial class Form1 : Form
    {
        BindingList<Song> m_SongList = new BindingList<Song>() { new Song(null, "The Chainsmokers & Coldplay:Something Just Like This"),
                                                                         new Song(new List<ChordToShow>()
                                                                            {new ChordToShow(920,0,"Am"),
                                                                             new ChordToShow(920,0,"F"),
                                                                             new ChordToShow(920,0,"C"),
                                                                             new ChordToShow(1240,0,"G")},
                                                                            "Eagle Eye Cherry:Save Tonight")};
        Queue<ChordToShow> m_ChordQueue;
        ChordToShow m_Current;
        int m_TimeElapsed;

        readonly List<ChordProxy> m_Chords = new List<ChordProxy> 
                                                    { new ChordProxy("A4maj"),
                                                      new ChordProxy("B4maj"),
                                                      new ChordProxy("C4maj"),
                                                      new ChordProxy("D4maj"),
                                                      new ChordProxy("E4maj"),
                                                      new ChordProxy("F4maj"),
                                                      new ChordProxy("G4maj"),
                                                      new ChordProxy("A4min"),
                                                      new ChordProxy("B4min"),
                                                      new ChordProxy("C4min"),
                                                      new ChordProxy("D4min"),
                                                      new ChordProxy("E4min"),
                                                      new ChordProxy("F4min"),
                                                      new ChordProxy("G4min")};

        readonly Dictionary<string, int> keyButtons = new Dictionary<string, int> {
                                                        {"Q",0}, {"W",1}, {"E",2}, {"R",3}, {"T",4}, {"Y",5}, {"U",6}, 
                                                        {"A",7}, {"S",8}, {"D",9}, {"F",10}, {"G",11}, {"H",12}, {"J",13}};

        private bool[] m_IsPressed = new bool[270];

        private ChordButton[] chordButtons = new ChordButton[14];

        private OutputDevice outDevice;

        private int outDeviceID = 0;




        public Form1()
        {
            InitializeComponent();
            InitializeSongListSelection();
            LyricsTextBox.SelectionAlignment = HorizontalAlignment.Center;

            // 
            // Chord Buttons
            // 
            string minor = "";
            int height = 400;
            int j = 0;
            for (int i = 0; i < m_Chords.Count; i++)
            {
                if (i == 7)
                {
                    minor = "m";
                    height = 350;
                    j = 0;
                }

                chordButtons[i] = new ChordButton(m_Chords[i]);
                chordButtons[i].Location = new System.Drawing.Point(140 + j * 80, height);
                chordButtons[i].Name = m_Chords[i].ToHumanReadableString();
                chordButtons[i].Size = new System.Drawing.Size(60, 46);
                chordButtons[i].TabIndex = 0;
                chordButtons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                chordButtons[i].BackColor = System.Drawing.Color.White;
                chordButtons[i].Text = Char.ConvertFromUtf32(65 + j).ToString() + minor;
                ChordButton cb = chordButtons[i];
                chordButtons[i].MouseDown += (sender, EventArgs) => { ChordKeyDown(sender, EventArgs, cb.ButtonChord); };
                chordButtons[i].KeyDown += keyboardButtonDown;
                chordButtons[i].MouseUp += (sender, EventArgs) => { ChordKeyUp(sender, EventArgs, cb.ButtonChord); };
                chordButtons[i].KeyUp += keyboardButtonUp;
                this.panel1.Controls.Add(chordButtons[i]);
                chordButtons[i].BringToFront();
                j++;
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

        private void keyboardButtonDown(object sender, KeyEventArgs e)
        {
            if (keyButtons.ContainsKey(e.KeyCode.ToString()) && !m_IsPressed[e.KeyValue])
            {
                m_IsPressed[e.KeyValue] = true;
                ChordKeyDown(sender, e, chordButtons[keyButtons[e.KeyCode.ToString()]].ButtonChord);
            }
        }

        private void keyboardButtonUp(object sender, KeyEventArgs e)
        {
            if (keyButtons.ContainsKey(e.KeyCode.ToString()))
            {
                m_IsPressed[e.KeyValue] = false;
                ChordKeyUp(sender, e, chordButtons[keyButtons[e.KeyCode.ToString()]].ButtonChord);
            }
        }

        public void ChordSwitch(Object myObject, EventArgs myEventArgs)
        {
            SwitchChordTimer.Stop();

            if (m_ChordQueue != null && m_ChordQueue.Count > 0)
            {
                m_Current = m_ChordQueue.Dequeue();
                CurrentChord.Text = m_Current.Chord;
                NextChord.Text = (m_ChordQueue.Count > 0) ? m_ChordQueue.Peek().Chord : "";

                // Sets the timer interval to be till the next note.
                SwitchChordTimer.Interval = m_Current.TimeTillNext;

                // Restarts the timer
                SwitchChordTimer.Enabled = true;
            }
        }

        public bool Play()
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

                return true;
            }
            else
            {
                MessageBox.Show("Please choose a song!", "No song chosen",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private void TillNextTimer_Tick(object sender, EventArgs e)
        {
            int time = m_TimeElapsed - TillNextTimer.Interval;
            CountDown.Text = (time > 0) ? time.ToString() : "0";
        }

        protected override void OnLoad(EventArgs e)
        {
            if (OutputDevice.DeviceCount == 0)
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
                catch (Exception ex)
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

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongList.SelectedIndex != -1)
            {
                Song selectedSong = SongList.SelectedItem as Song;
                LoadQueue(new Queue<ChordToShow>(selectedSong.SongChords));
                LyricsTextBox.Text = LyricsGetter.GetLyricsForSong(selectedSong.SongName);
            }
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void recordButton_CheckedChanged(object sender, EventArgs e)
        {
            if (recordButton.Checked)
            {
                recordButton.Text = "▌▌";
                recordButton.ForeColor = System.Drawing.Color.Black;
                record("open new Type waveaudio Alias recsound", "", 0, 0);
                record("record recsound", "", 0, 0);   
            }
            else
            {
                recordButton.Text = "●";
                recordButton.ForeColor = System.Drawing.Color.Red;
                record("save recsound d:\\mic.wav", "", 0, 0);
                record("close recsound", "", 0, 0);  
            }
        }

        private void button1_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Checked)
            {
                if (Play())
                {
                    button1.Text = "Stop";
                }
                else
                {
                    button1.Checked = false;
                }
            }
            else
            {
                SwitchChordTimer.Stop();
                CurrentChord.Text = "";
                NextChord.Text = "";
                CountDown.Text = "";
                button1.Text = "Play";
            }
        }
    }
}
