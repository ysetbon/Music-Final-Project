﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Final_Project.Scripts
{
    public class Song
    {
        public IList<ChordToShow> SongChords { get; private set; }
        public string SongName { get; private set; } //Song name should be taken from http://lyrics.wikia.com

        public Song(IList<ChordToShow> i_SongChords, string i_SongName)//TODO: songChords should be an arraylist with the following fields: chord, time to play chord.
            //the sum of all chords is equal to song length in seconds.
        {
            SongName = i_SongName;
            SongChords = i_SongChords;
        }

        public override string ToString()
        {
            return (!String.IsNullOrEmpty(SongName)) ? SongName : base.ToString();
        }
    }
}
