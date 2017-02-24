using NFugue.Theory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Final_Project.Scripts
{
    class ChordProxy : Chord
    {
        private string ChordName { get; set;}

        public ChordProxy(string chordAsString, string i_ChordName = "")
            : base(chordAsString)
        {
            ChordName = (String.IsNullOrEmpty(i_ChordName)) ? this.ToHumanReadableString() : i_ChordName;
        }

        public new Note[] GetNotes()
        {
            return base.GetNotes();
        }

        public new string ToHumanReadableString()
        {
            return ChordName;
        }
    }
}
