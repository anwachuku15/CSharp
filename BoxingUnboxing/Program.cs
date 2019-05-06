using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<object> obj = new List<object>();
            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");

            foreach(object i in obj){
                Console.WriteLine(i);
            }
            int sum = 0;

            foreach(object i in obj){
                if(i is int){
                    int iValue = (int)i;
                    sum += iValue;
                }
            }
            Console.WriteLine(sum);


        }
    }
}
