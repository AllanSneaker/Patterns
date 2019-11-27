using Observer.Interfaces;
using Observer.Models;
using System;

namespace Observer.Services
{
    public class SubscriberService : ISubscriberService
    {
        public User User { get; set; }

        public SubscriberService(User user, IPublisherService publisherService)
        {
            User = user;
            publisherService.RegisterSubscriber(this);
        }
        public void Update()
        {
            Console.WriteLine($"Hooray {User.Name} video is now available");
        }
    }
}
