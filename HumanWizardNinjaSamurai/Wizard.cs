using System;

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string name): base(name, 3, 25, 3, 50)
        {
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * this.Intelligence;
            target.health -= dmg;
            this.health += dmg;
            return target.health;
        }

        public void Heal(Human target)
        {
            target.health += 10 * this.Intelligence;
        }
    }
}