using System;

namespace Human
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100)
        {
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * this.Dexterity;
            Random rand = new Random();
            int moreDamage = rand.Next(1,6);
            if(moreDamage == 5) {
                target.health -= dmg + 10;
            }
            return target.health;
        }

        public void Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
        }
    }
}