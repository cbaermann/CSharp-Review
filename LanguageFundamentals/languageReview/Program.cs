using System;
using System.Collections.Generic;

namespace languageReview
{
    class Program
    {
        public static void SayHello(string firstName = "buddy"){
            System.Console.WriteLine($"Hello {firstName}, how are you?");
        }
        
        static void Main(string[] args)
        {
            SayHello("Brandon");
            // string place = "Coding Dojo";
            // string message = $"Hello {place}";
            // Console.WriteLine(message);
            // for (int i=1; i<=5; i++){
            //     System.Console.WriteLine(i);
            // }


            // Random rand = new Random();
            // for(int val = 0; val <10; val++){
            //     System.Console.WriteLine(rand.Next(2,8));
            // }


            // int[] numArray = new int[5]; //Declares array of length 5
            // int[] numArray2 = {1,2,3,4,5}; //prepopulated Array
            // string[] myCars = new string[]{"Mazda Miata", "Ford Focus", "Dodge Challenger", "Nissan 350z"};
            // for(int idx = 0; idx < myCars.Length; idx++){
            //     System.Console.WriteLine($"I own a {myCars[idx]}");
            // }
            // foreach(string car in myCars){
            //     System.Console.WriteLine($"I own a {car}");
            // }

            // List<string> bikes = new List<string>();
            // bikes.Add("Kawasaki");
            // bikes.Add("Triumph");
            // bikes.Add("BMW");
            // bikes.Add("Moto Guzzi");
            // bikes.Add("Harley Davidson");
            // bikes.Add("Suzuki");

            // System.Console.WriteLine(bikes[2]);
            // System.Console.WriteLine($"We currently own {bikes.Count} bikes");



            // Dictionary<string,string> profile = new Dictionary<string, string>();
            // profile.Add("Name", "Speros");
            // profile.Add("Language", "PHP");
            // profile.Add("Location", "Greece");
            // System.Console.WriteLine("Instructor Profile");
            // System.Console.WriteLine("Name - " + profile["Name"]);
            // System.Console.WriteLine("From - " + profile["Location"]);
            // System.Console.WriteLine("Favorite Language - " + profile["Language"]);

            // foreach(var entry in profile){
            //     System.Console.WriteLine(entry.Key + " - " + entry.Value);
            // }

            // object BoxedData = "This is clearly a string";
            // //Make sure it is the type you need before proceeding
            // if (BoxedData is int) {
            //     //This shouldn't run
            //     Console.WriteLine("I guess we have an integer value in this box?");
            // }
            // if (BoxedData is string) {
            //     Console.WriteLine("It is totally a string in the box!");
            // }

            


        }
    }
}
