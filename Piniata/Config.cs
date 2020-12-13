using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace Pinata
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("A percentage chance to become a Pinata")]
        public uint Chance { get; set; } = 50;

        [Description("How many items the Pinata will contain (max 8)")]
        public uint ItemAmount { get; set; } = 8;

        [Description("A hint message that will be desplayed to Pinata (leave empty to disable)")]
        public string HintMessage { get; set; } = "You have became the Pinata!";
        [Description("Duration of the hint messeage")]
        public uint HintDuration { get; set; } = 5;

        [Description("List of SCPs that can become Pinata:")]
        public List<RoleType> SCPRoles { get; set; } = new List<RoleType>
        {
            RoleType.Scp049,
            RoleType.Scp0492,
            RoleType.Scp096,
            RoleType.Scp106,
            RoleType.Scp173,
            RoleType.Scp93953,
            RoleType.Scp93989
        };

        [Description("List of avabile items which Pinata can contain:")]
        public List<ItemType> Items { get; set; } = new List<ItemType>
        {
            ItemType.Adrenaline,
            ItemType.KeycardJanitor,
            ItemType.KeycardScientist,
            ItemType.KeycardScientistMajor,
            ItemType.KeycardZoneManager,
            ItemType.KeycardGuard,
            ItemType.KeycardSeniorGuard,
            ItemType.KeycardContainmentEngineer,
            ItemType.KeycardNTFLieutenant,
            ItemType.KeycardNTFCommander,
            ItemType.KeycardFacilityManager,
            ItemType.KeycardChaosInsurgency,
            ItemType.KeycardO5,
            ItemType.Radio,
            ItemType.GunCOM15,
            ItemType.Medkit,
            ItemType.Flashlight,
            ItemType.MicroHID,
            ItemType.SCP500,
            ItemType.SCP207,
            ItemType.WeaponManagerTablet,
            ItemType.GunE11SR,
            ItemType.GunProject90,
            ItemType.Ammo556,
            ItemType.GunMP7,
            ItemType.GunLogicer,
            ItemType.GrenadeFrag,
            ItemType.GrenadeFlash,
            ItemType.Disarmer,
            ItemType.Ammo762,
            ItemType.Ammo9mm,
            ItemType.GunUSP,
            ItemType.SCP018,
            ItemType.SCP268,
            ItemType.Adrenaline,
            ItemType.Painkillers,
            ItemType.Coin
        };
    }
}
