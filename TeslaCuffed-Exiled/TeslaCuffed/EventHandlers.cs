using Exiled.Events.EventArgs;

namespace TeslaCuffed
{
    public class EventHandlers
    {
        public TeslaCont plugin;
        public Config config;
        public HandcuffingEventArgs args;

        public EventHandlers(TeslaCont plugin)
        {
            this.plugin = plugin;
            config = plugin.Config;
        }

        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.IsCuffed == true)
            {
                ev.IsTriggerable = false;
            }
        }
    }
}
