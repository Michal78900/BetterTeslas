using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using PlayerEvent = Exiled.Events.Handlers.Player;

namespace BetterTeslas
{
    public class BetterTeslas : Plugin<Config>
    {
        private static readonly Lazy<BetterTeslas> LazyInstance = new Lazy<BetterTeslas>(() => new BetterTeslas());
        public static BetterTeslas Instance => LazyInstance.Value;
        public override PluginPriority Priority => PluginPriority.High;
        public override string Author => "Michal78900";
        public override string Name => "BetterTeslas";
        public override Version Version => new Version(1, 0, 0);

        private BetterTeslas() { }

        private Handler handler;

        public override void OnEnabled()
        {
            base.OnEnabled();

            handler = new Handler();

            PlayerEvent.Hurting += handler.OnHurting;

        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            PlayerEvent.Hurting -= handler.OnHurting;

            handler = null;
        }
    }
}
