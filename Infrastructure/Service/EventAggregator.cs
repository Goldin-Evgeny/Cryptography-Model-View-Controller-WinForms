using System;

namespace Infrastructure.Service
{
    public class EventAggregator : IEventAggregator
    {
        public void Publish<TEvent>(TEvent eventToPublish)
        {
            throw new NotImplementedException();
        }

        public void Subscribe(object subscriber)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(object unsubscriber)
        {
            throw new NotImplementedException();
        }
    }
}
