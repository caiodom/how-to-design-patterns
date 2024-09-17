using Bridge.Abstraction.Base;
using Bridge.Implementor.Interfaces;


namespace Bridge.Abstraction
{
    public class Article : Content
    {
        public Article(IPublishingPlatform publishingPlatform) : base(publishingPlatform) { }
    }
}
