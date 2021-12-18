using Exiled.Events.EventArgs;

namespace TeslaCuffed
{
    public class EventHandlers
    {
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.IsCuffed == true)
            {
                ev.IsTriggerable = false;
            }
        }
    }
}
