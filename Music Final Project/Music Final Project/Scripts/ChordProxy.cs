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
        private Chord RepresentedChord {get; set;}
        private Note[] ChordNotes {get; set;}
        private string ChordName { get; set;}

        public ChordProxy(Note[] i_Notes, string i_ChordName = "")
            : base(getChordForBaseClass(i_Notes))
        {
            try
            {
                RepresentedChord = Chord.FromNotes(i_Notes);
            }
            catch (Exception)
            {
                RepresentedChord = null;
            }

            if (RepresentedChord == null)
            {
                ChordNotes = i_Notes;
            }

            ChordName = (String.IsNullOrEmpty(i_ChordName) && RepresentedChord != null) ? RepresentedChord.ToHumanReadableString() : i_ChordName;
        }

        /// <summary>
        /// Temporary solution to ensure the base class gets correct input
        /// </summary>
        /// <param name="i_Notes"></param>
        /// <returns></returns>
        private static Chord getChordForBaseClass(Note[] i_Notes)
        {
            try
            {
                return Chord.FromNotes(i_Notes);
            }
            catch (Exception)
            {
                return Chord.FromNotes(new Note[] { new Note(57), new Note(60), new Note(64) });
            }
        }

        public new Note[] GetNotes()
        {
            if (RepresentedChord != null)
            {
                return base.GetNotes();
            }

            return ChordNotes;
        }

        public new string ToHumanReadableString()
        {
            return ChordName;
        }
    }
}
