using NFugue.Theory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Final_Project.Scripts
{
    class ChordButton : Button
    {
        public Chord ButtonChord {get; private set;}

        public ChordButton(Chord i_ChordNotes)
        {
            ButtonChord = i_ChordNotes;
        }
    }
}
