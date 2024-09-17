using Bridge.Abstraction.Interface;
using Bridge.Implementor.Interfaces;

namespace Bridge.Abstraction.Base
{
    public abstract class Content : IContent
    {

        protected IPublishingPlatform _platform;
        protected Content(IPublishingPlatform publishingPlatform)
        {
            _platform = publishingPlatform;
        }

        public virtual void Publish(string title, string content)
        {
            _platform.Send(title, content);
        }
    }
}
