using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Final_Project.Scripts
{
    public class ChordToShow
    {
        // In miliseconds
        public int TimeTillNext { get; set; }

        public string Chord { get; set; }

        public ChordToShow(int timeTillNext, string chord)
        {
            this.TimeTillNext = timeTillNext;
            this.Chord = chord;
        }
    }
}
