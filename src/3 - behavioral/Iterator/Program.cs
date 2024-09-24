

using Iterator;
using Iterator.ConcreteAggregates;
using Iterator.IteratorInterfaces;

Playlist playlist = new Playlist();

playlist.AddMusic(new Music("Bohemian Rhapsody", "Queen"));
playlist.AddMusic(new Music("Blinding Lights", "The Weeknd"));
playlist.AddMusic(new Music("Clair de Lune", "The Weeknd"));

Console.WriteLine("\nNormal Iterator:");
IIterator iterator = playlist.CreateNormalIterator();
while (iterator.HasNext())
{
    Music music = iterator.Next();
    Console.WriteLine(music.ToString());
}


Console.WriteLine("\nReverse Iterator:");
IIterator reverseIterator = playlist.CreateReverseIterator();
while (reverseIterator.HasNext())
{
    Music music = reverseIterator.Next();
    Console.WriteLine(music.ToString());


}


