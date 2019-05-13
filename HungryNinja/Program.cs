using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Caesar Salad", 300, false, false),
                new Food("Turkey Sub", 500, false, false),
                new Food("Chicken Pad Thai", 800, true, false),
                new Food("Pound Cake", 360, false, true),
                new Food("Sushi", 320, true, false),
                new Food("Quarter Pounder", 500, false, false),
                new Food("Greek Yogurt", 100, false, true)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            int i = rand.Next(0, Menu.Count);
            return Menu[i];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>()
            {
            };
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get 
            {
                if(calorieIntake > 1200){
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            calorieIntake += item.Calories;
            if(calorieIntake < 1200){
                FoodHistory.Add(item);
                Console.WriteLine(item.Name + ": " + item.IsSpicy + ", " + item.IsSweet);
            }
            else {
                Console.WriteLine("The ninja is full and cannot eat anymore!");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            Ninja myNinja = new Ninja();
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
        }
    }
}
