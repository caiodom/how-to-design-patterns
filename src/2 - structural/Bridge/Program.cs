using Bridge.Abstraction;
using Bridge.Abstraction.Interface;
using Bridge.Implementor;
using Bridge.Implementor.Interfaces;

IPublishingPlatform blog = new BlogPlatform();
IPublishingPlatform socialMedia = new SocialMediaPlatform();

IContent article= new Article(blog);
IContent video=new Video(socialMedia);


article.Publish("How to Use Design Patterns", "Design patterns help you structure your code effectively...");
video.Publish("Understanding Bridge Pattern", "https://video.example.com/bridge-pattern");