using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private string artist;
    private string songName;
    private int seconds;
    private int minutes;

    public Song(string artist,string songName, int minutes, int seconds)
    {
        this.Artist = artist;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value<0||value>14)
            {
                throw new InvalidSongMinutesException();
            }
            minutes = value;
        }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value<0||value>59)
            {
                throw new InvalidSongSecondsException();
            }
            seconds = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length<3||value.Length>30)
            {
                throw new InvalidSongNameException();
            }
            songName = value;
        }
    }

    public string Artist
    {
        get { return artist; }
        set
        {
            if (value.Length < 3 || value.Length>20)
            {
                throw new InvalidArtistNameException();
            }
            artist = value;
        }
    }

}