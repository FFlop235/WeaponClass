using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    public sealed class WeaponItem
    {
        public string Name { get; set; }
        public WeaponWield WeaponWield { get; set; }
        public WeaponType WeaponType { get; set; }
        public WeaponSize WeaponSize { get; set; }
        public int NumDice { get; set; }
        public int DieToRoll { get; set; }
        public int CritThreat { get; set; }
        public int CritHitMult { get; set; }
        public bool IsMonkWeapon { get; set; }
    }

    public enum WeaponWield
    {
        oneHanded = 1,
        twoHanded = 2,
        bow = 3,
        crossbow = 4,
        shield = 5,
        doubleSidedWeapon = 6,
        throwingWeapon = 7
    }
    public enum WeaponType
    {
        Piercing = 1,
        Bludgeoning = 2,
        Slashing = 3,
        SlashingAndPiercing = 4,
        PiercingAndBludgeoning = 5
    }
    public enum WeaponSize
    {
        tiny = 1,
        small = 2,
        medium = 3,
        large = 4,
        huge = 5
    }
}

