using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Artist artist1 = new Artist("Les", "Claypool");
    artist1.Display();
    Song song1 = new Song(1111111111, "Of fungi and foe");
    Song song2 = new Song(1234567890, "Kalamazoo");
    Song song3 = new Song(1231231239, "Antipop");
    song1.Display();
    song1.AddArtistInfo("Les Claypool");
    song2.AddArtistInfo("Les Claypool");
    song3.AddArtistInfo("Les Claypool");
    song1.Display();
    song2.Display();
    song3.Display();
    Album album1 = new Album("The Brown Album");
    album1.AddSongs(song2);
    album1.AddSongs(song1);
    album1.AddSongs(song3);
    album1.DisplaySongs();
    album1.RemoveSong(song1);
    album1.DisplaySongs();
  }
}