using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace TeslaCuffed
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "MrAfitol";
        public override string Name => "Tesla Cuffed";
        public override string Prefix => "tesla_cuffed";
        public override Version Version => new Version(1, 2, 0);
        public override Version RequiredExiledVersion => new Version(5, 2, 2);

        public EventHandlers eHandler;

        public override void OnEnabled()
        {
            eHandler = new EventHandlers();
            Player.TriggeringTesla += eHandler.OnTriggeringTesla;
        }

        public override void OnDisabled()
        {
            Player.TriggeringTesla -= eHandler.OnTriggeringTesla;
            eHandler = null;
        }
    }
}
