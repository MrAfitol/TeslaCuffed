using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

namespace TeslaCuffed
{
    public class TeslaCont : Plugin<Config>
    {
        public override string Author { get; } = "MrAfitol";
        public override string Name { get; } = "Tesla Cuffed";
        public override string Prefix { get; } = "TeslaCuffed";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        public EventHandlers eHandler;

        public override void OnEnabled()
        {
            eHandler = new EventHandlers(this);
            Player.TriggeringTesla += eHandler.OnTriggeringTesla;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.TriggeringTesla -= eHandler.OnTriggeringTesla;
            eHandler = null;
            base.OnDisabled();
        }
    }
}
