namespace AsterNET.Manager.Event
{
    public class BridgeCreateEvent : BridgeStateEvent
    {
        public BridgeCreateEvent(ManagerConnection source) : base(source)
        {
        }
    }
}