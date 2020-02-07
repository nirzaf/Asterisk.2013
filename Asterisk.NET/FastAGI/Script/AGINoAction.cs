namespace AsterNET.FastAGI.Scripts
{
    internal class AGINoAction : AGIScript
    {
        public override void Service(AGIRequest request, AGIChannel channel)
        {
            base.Hangup();
        }
    }
}