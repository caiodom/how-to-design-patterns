using Bridge.Abstraction.Base;
using Bridge.Implementor.Interfaces;


namespace Bridge.Abstraction
{
    public class Video : Content
    {
        public Video(IPublishingPlatform publishingPlatform) : base(publishingPlatform) { }

    }
}
