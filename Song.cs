using System;
class Song{
 
  public int ID{
    get{return ID;}
    set{
      if(value.ToString().Length==9)
        ID=value;
      else
        Console.WriteLine("ID not correct length.");
    }
  }
  public string Title{get;set;}
  public string ArtistInfo{get;set;}
  public Song():this (0000000000, "Unknown", "Unknown")
  {}
  public Song(int id):this (id, "Unknown", "Unknown")
  {}
  public Song(int id, string title):this (0000000000, title, "Unknown")
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
    Console.WriteLine("Artist "+artistname +" added to the song" + Title);
  }
  public virtual void Display()
  {
    Console.WriteLine("Song info: "+ ID + " " + Title + " "+ ArtistInfo);
  }
}