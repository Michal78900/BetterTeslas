using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Collections.Generic;
using MEC;

using EPlayer = Exiled.API.Features.Player;

namespace Pinata
{
    class Handler
    {
        readonly Random rng = new Random();

        public void OnSpawn(SpawningEventArgs ev)
        {
            Timing.CallDelayed(1f, () =>
            {
                if (Pinata.Instance.Config.SCPRoles.Contains(ev.Player.Role) && Pinata.Instance.Config.Chance > rng.Next(0, 100))
                {
                    if (!string.IsNullOrWhiteSpace(Pinata.Instance.Config.HintMessage)) ev.Player.ShowHint(Pinata.Instance.Config.HintMessage, Pinata.Instance.Config.HintDuration);

                    for (int i = 0; i < Pinata.Instance.Config.ItemAmount; i++) ev.Player.AddItem(Pinata.Instance.Config.Items[rng.Next(-1, Pinata.Instance.Config.Items.Count)]);
                }
            });
        }
    }
}
