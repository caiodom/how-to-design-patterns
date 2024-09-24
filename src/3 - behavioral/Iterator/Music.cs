
namespace Iterator
{
    public class Music
    {
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public Music(string title, string artist)
        {
            this.Title = title;
            this.Artist = artist;
        }
        public override string ToString()
        {
            return $"{Title} by {Artist}";
        }
    }
}
