namespace AsterNET.Manager.Event
{
    public class BridgeDestroyEvent : BridgeStateEvent
    {
        public BridgeDestroyEvent(ManagerConnection source) : base(source)
        {
        }
    }
}