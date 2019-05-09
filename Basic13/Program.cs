using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers(){
            for(int i=1; i< 256; i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds(){
            for(int i=1; i<256; i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum(){
            int sum = 0;
            for(int i=0; i<256; i++){
                Console.WriteLine("New number: " + i);
                sum += i;
                Console.WriteLine("Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers1){
            for(int i=0; i<numbers1.Length; i++){
                Console.WriteLine(string.Join(", ", numbers1[i]));
            }
        }

        public static int FindMax(int[] numbers2){
            int max = numbers2[0];
            for(int i=1; i<numbers2.Length; i++){
                if(numbers2[i]>max){
                    max = numbers2[i];
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers3){
            int sum = 0;
            for(int i=0; i<numbers3.Length; i++){
                sum += numbers3[i];
            }
            double avg = sum/numbers3.Length;
            Console.WriteLine(avg);
        }

        public static int[] OddArray(){
            // int [] odds = new int [];
            List<int> oddList = new List<int>();
            for(int i=1; i<256; i+=2){
                oddList.Add(i);
            }
            
            int [] odds = new int [oddList.Count];
            for(int i=0; i<odds.Length; i++){
                odds[i] = oddList[i];
            }
            return odds;

        }

        public static int GreaterThanY(int[] numbers4, int y){
            int count = 0;
            for(int i=0; i<numbers4.Length; i++){
                if(numbers4[i]>y){
                    count++;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers5){
            for(int i=0; i<numbers5.Length; i++){
                numbers5[i] *= numbers5[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers5));
        }

        public static void EliminateNegatives(int[] numbers6){
            for(int i=0; i<numbers6.Length; i++){
                if(numbers6[i]<0){
                    numbers6[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers6));
        }

        public static void MinMaxAverage(int[] numbers7){
            int max = numbers7[0];
            int min = numbers7[0];
            int sum = 0;

            for(int i=0; i<numbers7.Length; i++){
                sum += numbers7[i];
                if(numbers7[i] > max){
                    max = numbers7[i];
                }
                if(numbers7[i] < min){
                    min = numbers7[i];
                }
            }
            int avg = sum/numbers7.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }

        public static void ShiftValues(int[] numbers8){
            for(int i=0; i<numbers8.Length-1; i++){
                numbers8[i] = numbers8[i+1];
            }
            numbers8[numbers8.Length-1] = 0;
            Console.WriteLine("[{0}]", string.Join(", ", numbers8));
           
        }

        public static object[] NumToString(int[] numbers9){
            object [] dojonumbers = new object[numbers9.Length];
            for(int i=0; i<numbers9.Length; i++){
                if(numbers9[i] >= 0){
                    dojonumbers[i] = numbers9[i];
                }
                else {
                    dojonumbers[i] = "Dojo";
                }
            }
            return dojonumbers;
        }


        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();

            int [] numbers1 = {11,23,34,45};
            LoopArray(numbers1);

            int [] numbers2 = {-11,-23,-45,0};
            int max = FindMax(numbers2);
            Console.WriteLine(max);

            int [] numbers3 = {1,2,3,4,5};
            GetAverage(numbers3);

            int [] allOdds = OddArray();
            Console.WriteLine("[{0}]", string.Join(", ", allOdds));

            int [] numbers4 = {1,3,5,7};
            int y = 2;
            int greater = GreaterThanY(numbers4, y);
            Console.WriteLine(greater);

            int[] numbers5 = {1,2,3,4,5};
            SquareArrayValues(numbers5);

            int[] numbers6 = {1,2,3,4,-5};
            EliminateNegatives(numbers6);

            int[] numbers7 = {1,2,3,4,5};
            MinMaxAverage(numbers7);

            int [] numbers8 = {1,2,3,4,5};
            ShiftValues(numbers8);

            int[] numbers9 = {-1,3,-5,7,0};
            object[] dojo = NumToString(numbers9);
            Console.WriteLine("[{0}]", string.Join(", ", dojo));
        }
    }
}
