using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // create list of tracks
        private List<Track> tracks = new List<Track>();

        // properties
        public string Artist { get; set; }

        public string Label { get; set; }

        public short Released { get; set; }

        // readonly
        public TimeSpan PlayingTime
        {
            get
            {
                TimeSpan playingTime = new TimeSpan(0, 0, 0);

                foreach (Track track in tracks)
                {
                    playingTime += track.Length;
                }

                return playingTime;
            }
        }

        public List<Track> Tracks { get { return tracks; } }

        // constructors
        public MusicCD() { }

        public MusicCD(string artist, string title, decimal price, short released)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
        }

        // methods
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}