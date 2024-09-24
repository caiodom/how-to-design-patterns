using Iterator.Aggregates;
using Iterator.ConcreteIterators;
using Iterator.IteratorInterfaces;

namespace Iterator.ConcreteAggregates
{
    //Concrete Aggregate
    public class Playlist : IAggregate
    {
        private readonly List<Music> _musics = new List<Music>();


        public void AddMusic(Music music)
        {
            _musics.Add(music);
        }

        public Music GetMusic(int index)
        {
            return _musics[index];
        }

        public int Count()
        {
            return _musics.Count;
        }


        public IIterator CreateNormalIterator()
        {
            return new NormalIterator(this);
        }

        public IIterator CreateReverseIterator()
        {
            return new ReverseIterator(this);
        }
    }
}
