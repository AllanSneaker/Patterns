
namespace Observer.Interfaces
{
    public interface IPublisherService
    {
        void RegisterSubscriber(ISubscriberService subscriber);
        void RemoveSubscriber(ISubscriberService subscriber);
        void NotifySubscribers();
    }
}
