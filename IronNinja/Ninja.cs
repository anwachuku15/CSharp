using System;
using System.Collections.Generic;

namespace IronNinja
{
    abstract class Ninja
    {
        protected int calorieIntake;
        public int calorieLimit;
        public List<IConsumable> ConsumptionHistory;
        public string Name;
        public Ninja(string name, int limit)
        {
            this.Name = name;
            this.calorieIntake = 0;
            this.calorieLimit = limit;
            this.ConsumptionHistory = new List<IConsumable>();
        }
        public bool IsFull 
        {
            get { return calorieIntake >= calorieLimit; }
        }
        public virtual void Consume(IConsumable item)
        {
            if(this.IsFull)
            {
                Console.WriteLine($"{this.Name} is full.");
                Console.WriteLine($"{this.Name} consumed {this.calorieIntake} calories.");
                return;
            }
            this.calorieIntake += item.Calories;
            this.ConsumptionHistory.Add(item);
            
            
        }
    }

}