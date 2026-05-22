using System.Net.WebSockets;

namespace Models.Game.GameCharacter;

class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Attacked !!!");
    }
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks with sword");
    }
}

class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots arrow");
    }
}

class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts spell");
    }
}

