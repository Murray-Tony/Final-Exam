using System;
using System.Collections.Generic;
class Album
{
public string Title;
public string ListOfSongs;
public Album(string title)
{
  Title = title;
}
public List<Song> Albumlist = new List<Song>();
public virtual void AddSongs(Song a)
{
  Albumlist.Add(a);
  Console.WriteLine("Song titled "+a.Title+" was added to album.");
}
public virtual void RemoveSong(Song a)
{
  Albumlist.Remove(a);
  Console.WriteLine("Song titled "+a.Title+" removed from album.");
}
public virtual void DisplaySongs()
{
  Console.WriteLine("Here are the songs in album:");
foreach (var song in Albumlist) {
      song.Display();
}
}
}