using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Artist artist1 = new Artist("Les", "Claypool");
    artist1.Display();
    Song song1 = new Song(1111111111, "Of fungi and foe");
    song1.Display();
  }
}