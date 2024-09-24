using Iterator.ConcreteAggregates;
using Iterator.IteratorInterfaces;

namespace Iterator.ConcreteIterators
{
    //Concrete Iterator
    public class NormalIterator : IIterator
    {
        private readonly Playlist _musicCollection;
        private int _position = 0;
        public NormalIterator(Playlist musicCollection)
        {
            _musicCollection = musicCollection;
        }

        public bool HasNext()
        {
            return _position < _musicCollection.Count();
        }

        public Music Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements in the collection.");
            
            return _musicCollection.GetMusic(_position++);
        }
    }
}
