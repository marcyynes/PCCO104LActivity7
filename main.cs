using System;

public abstract class Weapon
{
    public string WeaponType { get; protected set; }
    public int BaseAttack { get; protected set; }
    public int AttackPercent { get; protected set; }

    private int _criticalDamage;
    private int _criticalRate;
    private int _energyRecharge;

    public Weapon(string weaponType, int baseAttack, int attackPercent, int criticalDamage, int criticalRate, int energyRecharge)
    {
        WeaponType = weaponType;
        BaseAttack = baseAttack;
        AttackPercent = attackPercent;
        _criticalDamage = criticalDamage;
        _criticalRate = criticalRate;
        _energyRecharge = energyRecharge;
    }

    public Weapon(string weaponType, int baseAttack, int criticalDamage)
        : this(weaponType, baseAttack, 0, criticalDamage, 0, 0)
    {
    }

    public Weapon()
    {
    }

    public virtual void DisplayWeaponInfo()
    {
        Console.WriteLine($"Weapon Type: {WeaponType}");
        Console.WriteLine($"MAIN STAT: Base ATK");
        Console.WriteLine($"2ND STAT: Attack%");

        Console.WriteLine($"------------------------------");

        Console.WriteLine($"Base Attack: {BaseAttack}");
        Console.WriteLine($"Attack%: {AttackPercent}%");
        Console.WriteLine($"Critical Damage: {_criticalDamage}%");
        Console.WriteLine($"Critical Rate: {_criticalRate}%");
        Console.WriteLine($"Energy Recharge: {_energyRecharge}%");
    }

    private void Enhance()
    {
    }
}

public class SkywardBlade : Weapon
{
    public SkywardBlade() : base("Sword: Skyward Blade", 608, 0, 44, 20, 8) { }
}

public class SkywardPride : Weapon
{
    public SkywardPride() : base("Claymore: Skyward Pride", 674, 0, 45, 0, 8) { }
}

public class SkywardSpine : Weapon
{
    public SkywardSpine() : base("Polearm: Skyward Spine", 674, 0, 45, 16, 8) { }
}

public class SkywardHarp : Weapon
{
    public SkywardHarp() : base("Bow: Skyward Harp", 674, 40, 44, 22, 0) { }
}

public class SkywardAtlas : Weapon
{
    public SkywardAtlas() : base("Catalyst: Skyward Atlas", 674, 33, 45, 0, 0) { }
}

public class ThousandFloatingDreams : Weapon
{
    public ThousandFloatingDreams() : base("Sword: A Thousand Floating Dreams", 510, 0, 36, 0, 0) { }
}

public class HuntersPath : Weapon
{
    public HuntersPath() : base("Bow: Hunter's Path", 510, 0, 36, 0, 0) { }
}

public class LightOfFoliarIncision : Weapon
{
    public LightOfFoliarIncision() : base("Sword: Light of Foliar Incision", 510, 0, 36, 0, 0) { }
}

class Program
{
    static void Main(string[] args)
    {
        Weapon skywardBlade = new SkywardBlade();
        Weapon skywardPride = new SkywardPride();
        Weapon skywardSpine = new SkywardSpine();
        Weapon skywardHarp = new SkywardHarp();
        Weapon skywardAtlas = new SkywardAtlas();
        Weapon thousandFloatingDreams = new ThousandFloatingDreams();
        Weapon huntersPath = new HuntersPath();
        Weapon lightOfFoliarIncision = new LightOfFoliarIncision();

        Console.WriteLine("Skyward Blade Info:");
        skywardBlade.DisplayWeaponInfo();

        Console.WriteLine("\nSkyward Pride Info:");
        skywardPride.DisplayWeaponInfo();

        Console.WriteLine("\nSkyward Spine Info:");
        skywardSpine.DisplayWeaponInfo();

        Console.WriteLine("\nSkyward Harp Info:");
        skywardHarp.DisplayWeaponInfo();

        Console.WriteLine("\nSkyward Atlas Info:");
        skywardAtlas.DisplayWeaponInfo();

        Console.WriteLine("\nA Thousand Floating Dreams Info:");
        thousandFloatingDreams.DisplayWeaponInfo();

        Console.WriteLine("\nHunter's Path Info:");
        huntersPath.DisplayWeaponInfo();

        Console.WriteLine("\nLight of Foliar Incision Info:");
        lightOfFoliarIncision.DisplayWeaponInfo();
    }
}