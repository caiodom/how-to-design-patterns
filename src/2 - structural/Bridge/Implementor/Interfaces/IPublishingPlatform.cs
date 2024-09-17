namespace Bridge.Implementor.Interfaces
{
    public interface IPublishingPlatform
    {
        void Send(string title, string content);
    }
}
