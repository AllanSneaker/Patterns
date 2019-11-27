using Observer.Models;
using Observer.Services;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Id = 1, Name = "Introduction" };
            var video2 = new Video { Id = 2, Name = "Pattern Observer" };

            var user = new User { Id = 1, Name = "Adam" };
            var user2 = new User { Id = 2, Name = "Zoe" };

            var publisher = new PublisherService(video);

            var subscriber1 = new SubscriberService(user, publisher);
            var subscriber2 = new SubscriberService(user2, publisher);


            publisher.SetAvailability(video);

            publisher.RemoveSubscriber(subscriber2);

            publisher.SetAvailability(video2);
        }
    }
}
