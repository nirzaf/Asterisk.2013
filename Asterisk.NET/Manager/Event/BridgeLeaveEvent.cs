namespace AsterNET.Manager.Event
{
    public class BridgeLeaveEvent : BridgeActivityEvent
    {
        public BridgeLeaveEvent(ManagerConnection source) : base(source)
        {
        }
    }
}