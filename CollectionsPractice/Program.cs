using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Console.WriteLine("Hello World!");
            int[] basic1 = {0,1,2,3,4,5,6,7,8,9};
            string[] basic2 = {"Tim", "Martin", "Nikki", "Sara"};
            string[] basic3 = new string[10];
            for(int i=0; i<basic3.Length; i++){
                if(i%2==0){
                    basic3[i] = "true";
                }
                else {
                    basic3[i] = "false";
                }
            }

            //List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("strawberry");
            flavors.Add("cookie dough");
            flavors.Add("rocky road");
            // Console.WriteLine(flavors.Count);
            // Console.WriteLine(flavors[2]);
            // flavors.Remove(flavors[2]);
            // Console.WriteLine(flavors.Count);

            //User Info Dictionary
            Random rand = new Random();

            Dictionary<string,string> favorites = new Dictionary<string,string>();
            favorites.Add("Tim", $"{flavors[rand.Next(flavors.Count)]}");
            favorites.Add("Martin", $"{flavors[rand.Next(flavors.Count)]}");
            favorites.Add("Nikki", $"{flavors[rand.Next(flavors.Count)]}");
            favorites.Add("Sara", $"{flavors[rand.Next(flavors.Count)]}");
            // Console.WriteLine(favorites);

            foreach(var person in favorites){
                Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
    }
}
