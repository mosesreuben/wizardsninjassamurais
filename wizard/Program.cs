using System;

namespace wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Moses = new Wizard("Moses");
            Ninja Pierre = new Ninja("Pierre");
            Human Raymond = new Human("Raymond");
            Samurai Prescott = new Samurai("Prescott");

            Moses.Attack(Pierre);
            Moses.Fireball(Pierre);
            Pierre.Steal(Moses);
            Prescott.Attack(Raymond);
            Pierre.getAway();
            Moses.Heal();
            Prescott.Meditate();
            Prescott.deathBlow(Moses);
            Prescott.deathBlow(Pierre);
        }
    }
} 