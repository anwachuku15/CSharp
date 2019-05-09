using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] randoms = new int[10];
            Random rand = new Random();
            
            for(int i=0; i<randoms.Length; i++){
                randoms[i] = rand.Next(5,25);
            }
            return randoms;
        }

        public static string TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int coin = rand.Next(1,3);
            string heads = "Heads";
            string tails = "Tails";
            if(coin==1){
                Console.WriteLine("Heads");
                return heads;
            }
            else{
                Console.WriteLine("Tails");
                return tails;
            }
        }

        public static double TossMultipleCoins(int num){
            string[] tosses = new string[num];
            int headsCount = 0;
            for(int i=0; i<num; i++){
                tosses[i] = TossCoin();
                if(tosses[i] == "Heads"){
                    headsCount++;
                }
            }
            double ratio = (double)headsCount/(double)num;
            Console.WriteLine(ratio);
            return ratio;
        }

        public static List<string> Names(){
            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            
            Random rand = new Random();
            Console.WriteLine(string.Join(", ", nameList));
            List<string> randomized = new List<string>();
            while(nameList.Count > 0){
                int index = rand.Next(0, nameList.Count);
                randomized.Add(nameList[index]);
                nameList.RemoveAt(index);
            }
            for(int i=0; i<randomized.Count; i++){
                nameList.Add(randomized[i]);
            }
            Console.WriteLine(string.Join(", ", nameList));

            List<string> five = new List<string>();
            for(int i=0; i<nameList.Count; i++){
                if(nameList[i].Length > 5){
                    five.Add(nameList[i]);
                }
            }
            Console.WriteLine(string.Join(", ", five));

            return nameList;
        }
        static void Main(string[] args)
        {
            // RANDOM ARRAY
            int [] random = RandomArray();
            Console.WriteLine("[{0}]", string.Join(", ", random));
            int min = random[0];
            int max = random[0];
            int sum = 0;

            for(int i=0; i<random.Length; i++){
                sum += random[i];
                if(random[i] < min){
                    min = random[i];
                }
                if(random[i] > max){
                    max = random[i];
                }
            }
            Console.WriteLine("minimum: " + min + "\n" + "maximum: " + max + "\n" + "sum: " + sum);

            // COIN FLIP
            TossCoin();

            // TOSS MULTIPLE COINS
            TossMultipleCoins(3);

            // NAMES
            Names();
        }
    }
}
