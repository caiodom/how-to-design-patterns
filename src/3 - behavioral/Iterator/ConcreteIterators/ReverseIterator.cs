using Iterator.ConcreteAggregates;
using Iterator.IteratorInterfaces;

namespace Iterator.ConcreteIterators
{
    //Concrete Iterator
    public class ReverseIterator : IIterator
    {
        private readonly Playlist _playlist;
        private int _position;

        public ReverseIterator(Playlist playlist)
        {
            _playlist = playlist;
            _position = _playlist.Count() - 1;
        }

        public bool HasNext()
        {
            return _position >= 0;
        }

        public Music Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements in the collection.");

            return _playlist.GetMusic(_position--);
        }
    }
}
