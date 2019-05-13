using System;

namespace Human
{
    class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            public int health;
             
            // add a public "getter" property to access health
            public int Health
            {
                get { return health; }
            }     
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
            // Add a constructor to assign custom values to all fields
            public Human(string name, int str, int intel, int dex, int hp)
            {
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }
            // Build Attack method
            public virtual int Attack(Human target)
            {
                int dmg = this.Strength * 3;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }
}
