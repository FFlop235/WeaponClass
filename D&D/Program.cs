using D_D;

new[]
{
    new WeaponItem
    {
        Name = "Длинный меч", WeaponWield = WeaponWield.twoHanded,
        WeaponType = WeaponType.SlashingAndPiercing, WeaponSize = WeaponSize.large,
        NumDice = 1, DieToRoll = 12, CritThreat = 20, CritHitMult = 3, IsMonkWeapon = false
    },

    new WeaponItem
    {
        Name = "Клинок", WeaponWield = WeaponWield.oneHanded,
        WeaponType = WeaponType.Piercing, WeaponSize = WeaponSize.tiny,
        NumDice = 1, DieToRoll = 3, CritThreat = 20, CritHitMult = 1, IsMonkWeapon = false
    },

    new WeaponItem
    {
        Name = "Длинный лук", WeaponWield = WeaponWield.bow,
        WeaponType = WeaponType.Piercing, WeaponSize = WeaponSize.huge,
        NumDice = 1, DieToRoll = 14, CritThreat = 20, CritHitMult = 4, IsMonkWeapon = false
    }
}
.ToList()
.ForEach(weapon => ViemDescription(weapon));

static void ViemDescription(WeaponItem item)
{
    string description = $"""
        =============================================
        Наименование: {item.Name}
        =============================================
        Одноручный: {item.IsOneHanded()}
        Двуручный: {item.IsTwoHanded()}
        Оружие дальнего боя: {item.IsRanged()}
        Оружие ближнего боя: {item.IsMelee()}
        Колющий урон: {item.CanPierce()}
        Рубящий урон: {item.CanSlash()}
        Дробящий урон: {item.CanBludgeon()}
        Средний урон: {item.AvarageDamage()}
        Случайный урон в данный момент: {item.CalculateDamage()}
        Минимальный урон: {item.MinDamage()}
        Максимальный урон: {item.MaxDamage()}
        Максимальный критический урон: {item.MaxCritDamage()}
        Шанс крита: {item.CritChance()}
        Тип урона: {item.GetWieldTypeString()}
        Размер оружия: {item.GetSizeString()}
        Подходит монаху: {item.IsMonkWeapon}
        """;
    Console.WriteLine(description);
}