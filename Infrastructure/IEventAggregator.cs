namespace Infrastructure
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);

        void Unsubscribe(object unsubscriber);

        void Publish<TEvent>(TEvent eventToPublish);
        //Should be classes to represent the event I'll be firing??
    }
}
