using Microsoft.Practices.Prism.PubSubEvents;

namespace Common.Events
{
    public class RaiseIsAppBusyEvent : PubSubEvent<bool>
    {
    }
}
