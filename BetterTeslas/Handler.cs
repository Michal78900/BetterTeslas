using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Collections.Generic;
using MEC;

namespace BetterTeslas
{
    class Handler
    {
        readonly Random rng = new Random();
        public void OnHurting(HurtingEventArgs ev)
        {
            if (ev.DamageType == DamageTypes.Tesla)
            {
                if(BetterTeslas.Instance.Config.ScpDamageAmount.ContainsKey(ev.Target.Role))
                {
                    if (BetterTeslas.Instance.Config.RandomDamage && BetterTeslas.Instance.Config.ScpDamageAmount[ev.Target.Role] != 0)
                    {
                        if (rng.Next(0, 10) >= 5) ev.Amount = BetterTeslas.Instance.Config.ScpDamageAmount[ev.Target.Role] + rng.Next(-1, BetterTeslas.Instance.Config.RandomDamageMaxValue);
                                                 else ev.Amount = BetterTeslas.Instance.Config.ScpDamageAmount[ev.Target.Role] - rng.Next(-1, BetterTeslas.Instance.Config.RandomDamageMaxValue);
                    }
                    else ev.Amount = BetterTeslas.Instance.Config.ScpDamageAmount[ev.Target.Role];
                }
            }
        }
    }
}
