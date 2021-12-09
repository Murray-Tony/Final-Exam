using System;
class Song{
  private int id;
  public int ID{
    get{return id;}
    set{
      if(value.ToString().Length == 10)
        id=value;
      else
        Console.WriteLine("ID length must be 10.");
    }
  }
  public string Title{get;set;}
  public string ArtistInfo{get;set;}
  public Song():this (0000000000, "Unknown", "Unknown")
  {}
  public Song(int id):this (id, "Unknown", "Unknown")
  {}
  public Song(int id, string title):this (id, title, "Unknown")
  {}
  public Song(int id, string title, string artistinfo)
  {
    ID=id;
    Title=title;
    ArtistInfo=artistinfo;
  }

  public virtual void AddArtistInfo(string artistname)
  {
    ArtistInfo=artistname;
    Console.WriteLine("Artist "+artistname +" added to the song " + Title);
  }
  public virtual void Display()
  {
    Console.WriteLine("Song info: "+ ID + " " + Title + " "+ ArtistInfo);
  }
}