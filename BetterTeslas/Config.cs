using System;
using Exiled.API.Interfaces;
using System.ComponentModel;
using System.Collections.Generic;

namespace BetterTeslas
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("If inflicted damage may be smaller or larger than value on a list")]
        public bool RandomDamage { get; set; } = false;
        [Description("Maximum value for smaller or larger damage amount, ignored if damage from the list is equal to 0 (Damage from the list +/- from 0 to this value)")]
        public int RandomDamageMaxValue { get; set; } = 20;
        
        [Description("SCPs list with damage amount which tesla will inflict to them (Remember that one Tesla burst hits 2 or 3 times)")]
        public Dictionary<RoleType, float> ScpDamageAmount { get; set; } = new Dictionary<RoleType, float>
        {
            {RoleType.Scp049, 425f },
            {RoleType.Scp0492, 50f },
            {RoleType.Scp096, 375f },
            {RoleType.Scp106, 325f },
            {RoleType.Scp173, 534f },
            {RoleType.Scp93953, 367f },
            {RoleType.Scp93989, 367f }
        };
    }
}
