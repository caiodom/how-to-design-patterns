using Bridge.Implementor.Interfaces;

namespace Bridge.Implementor.Base
{
    public abstract class PublishingPlatform : IPublishingPlatform
    {
        public virtual void Send(string title, string content)
        {
            Console.WriteLine($"title: {title} and content: {content}");
        }

    }
}
