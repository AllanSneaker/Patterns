using Observer.Interfaces;
using Observer.Models;
using System;
using System.Collections.Generic;

namespace Observer.Services
{
    public class PublisherService : IPublisherService
    {
        private List<ISubscriberService> _subscribers = new List<ISubscriberService>();
        private Video _video;

        public PublisherService(Video video)
        {
            _video = video;
        }

        public void SetAvailability(Video video)
        {
            _video = video;
            NotifySubscribers();
        }


        public void NotifySubscribers()
        {
            Console.WriteLine($"\n{_video.Name} video is now available\n");

            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }

        public void RegisterSubscriber(ISubscriberService subscriber)
        {
            Console.WriteLine($"Subscriber Added : {((SubscriberService)subscriber).User.Name}");
            _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriberService subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}
