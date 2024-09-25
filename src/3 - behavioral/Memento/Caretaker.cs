namespace Memento
{
    public class Caretaker
    {
        private readonly List<Memento> _mementos= new List<Memento>();

        public void AddMemento(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }

    }
}
