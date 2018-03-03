using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();
        for (int i = 0; i < numbers; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string artist = input[0];
            string songName = input[1];
            var lenght = input[2].Split(':');
            try
            {
                int minutes = 0;
                int seconds = 0;
                if (!int.TryParse(lenght[0], out minutes) || !int.TryParse(lenght[1], out seconds))
                {
                    throw new InvalidSongLengthException();
                }
                Song song = new Song(artist, songName, minutes, seconds);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine($"Songs added: {songs.Count}");
        var totalMinutes = songs.Sum(e => e.Minutes);
        var totalSeconds = songs.Sum(e => e.Seconds)+totalMinutes*60;

        var finalMinutes=totalSeconds/60;
        var finalSeconds = totalSeconds % 60;

        Console.WriteLine($"Playlist length: {finalMinutes/60}h {finalMinutes%60}m {finalSeconds}s");
    }
}