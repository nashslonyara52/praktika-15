using System;
public interface Damager
{
    void Damage();
}
public interface Healer
{
    void Heal();
}
public class Warrior : Damager
{
    public void Damage()
    {
        Console.WriteLine("Воин атакует!");
    }
}
public class Mage : Damager, Healer
{
    public void Damage()
    {
        Console.WriteLine("Маг атакует!");
    }
    public void Heal()
    {
        Console.WriteLine("Маг лечит!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Damager Damage = new Warrior();
        Damager DamagerMage = new Mage();
        Healer Mageheal = new Mage();
        Damage.Damage();
        DamagerMage.Damage();
        Mageheal.Heal();
    }
}