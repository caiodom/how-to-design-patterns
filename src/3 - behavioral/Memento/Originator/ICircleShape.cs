namespace Memento.Originator
{
    //Originator
    public interface ICircleShape
    {
        void Draw(int radius);
        string Get();
        Memento SaveToMemento();
        string RestoreToMemento(Memento memento);
    }
}
