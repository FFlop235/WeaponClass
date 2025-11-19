# Реализация классса оружия для игры D&D (задача по программированию)
## Задача:

Есть примерный класс оружия из днд игры:
```csharp
WeaponItem
{
	Name,
	WeaponWield (one-handed = 1, two-handed = 2, bow = 3, crossbow = 4, shield = 5,  double-sided weapon = 6, throwing weapon = 7),
	WeaponType (Piercing = 1, Bludgeoning = 2, Slashing = 3, Slashing and Piercing = 4, Piercing and Bludgeoning = 5),
    WeaponSize (tiny = 1, small = 2, medium = 3, large = 4, huge = 5),
	NumDice, // количество кубиков урона)
	DieToRoll, //количество сторон на кубике урона
	CritThreat, // критическая угроза, 1 = 1/20, 2 = 1/10, 3 = 3/20, рассчитывается при броске как (d20 >= 20 - CritThreat)
	CritHitMult, // критический множитель урона 2/3/4)
	IsMonkWeapon, // (0 or 1),
}
```

`пример {Длинный меч, WeaponWield = 1, WeaponType = 3, WeaponSize = 3, NumDice = 1, DieToRoll = 8, CritThreat = 2, CritHitMult = 2}`

Разработайте для него полезные методы расширения:
```charp
bool IsOneHanded
bool IsTwoHanded
bool IsRanged
bool IsMelee
bool CanPierce
bool CanSlash
bool CanBludgeon
double AverageDamage // без крита
double CalculateDamage // с расчетом шанса крита
int MinDamage        // без крита
int MaxDamage        // без крита
int MaxCritDamage
bool IsMonkWeapon
double CritChance // шанс в виде дроби
string GetWieldTypeString
string GetSizeString
```

Нужно протестировать методы расширения в консоли.
