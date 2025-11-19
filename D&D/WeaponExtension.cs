using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    public static class WeaponExtension
    {
        private static readonly WeaponWield[] RangedWeaponWields =
        {
            WeaponWield.bow,
            WeaponWield.crossbow,
            WeaponWield.throwingWeapon,
        };

        private static readonly Random _rnd = new Random();

        public static bool IsOneHanded(this WeaponItem weapon) =>
            weapon.WeaponWield == WeaponWield.oneHanded;

        public static bool IsTwoHanded(this WeaponItem weapon) =>
            weapon.WeaponWield == WeaponWield.twoHanded;

        public static bool IsRanged(this WeaponItem weapon) =>
            RangedWeaponWields.Contains(weapon.WeaponWield);

        public static bool IsMelee(this WeaponItem weapon) =>
            !weapon.IsRanged();

        public static bool CanPierce(this WeaponItem weapon) =>
        weapon.WeaponType switch
        {
            WeaponType.Bludgeoning or WeaponType.Slashing => false,
            _ => true
        };

        public static bool CanSlash(this WeaponItem weapon) =>
            weapon.WeaponType is WeaponType.SlashingAndPiercing or WeaponType.Slashing;

        public static bool CanBludgeon(this WeaponItem weapon) =>
            weapon.WeaponType is WeaponType.Bludgeoning or WeaponType.PiercingAndBludgeoning;

        public static double AvarageDamage(this WeaponItem weapon) =>
            weapon.NumDice * weapon.DieToRoll / 2;

        public static double CalculateDamage(this WeaponItem weapon)
        {
            bool crit = _rnd.Next(1, 21) >= 20 - weapon.CritThreat;

            int dmg = Enumerable.Range(0, weapon.NumDice)
                .Sum(_ => _rnd.Next(1, weapon.DieToRoll + 1));

            return crit ? dmg * weapon.CritHitMult : dmg;
        }

        public static int MinDamage(this WeaponItem weapon) =>
            weapon.NumDice;

        public static int MaxDamage(this WeaponItem weapon) =>
            weapon.NumDice * weapon.DieToRoll;

        public static int MaxCritDamage(this WeaponItem weapon) =>
            weapon.CritHitMult * weapon.MaxDamage();

        public static double CritChance(this WeaponItem weapon) =>
            weapon.CritThreat / 20;

        public static string GetWieldTypeString(this WeaponItem weapon) =>
            weapon.WeaponType.ToString();

        public static string GetSizeString(this WeaponItem weapon) =>
            weapon.WeaponSize.ToString();
    }
}
