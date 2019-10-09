using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i=1; i <256; i++){
            //     System.Console.WriteLine(i);
            // }
            // for(int i=1; i <=100; i++){
            //     if(i % 3 == 0){
            //         System.Console.WriteLine(i);
            //     }
            //     if(i % 5 == 0){
            //         System.Console.WriteLine(i);
            //     }
            // }
            for(int i=1; i <=100; i++){
                if(i % 3 ==0 && i % 5 == 0){
                    System.Console.WriteLine("FizzBuzz");
                }
                if(i % 3 == 0){
                    System.Console.WriteLine("Fizz");
                }
                if(i % 5 == 0){
                    System.Console.WriteLine("Buzz");
                }
            }
        }
    }
}
