using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] trueFalse= {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();
            flavors.Add("Strawberry");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Mint");
            flavors.Add("Caramel");

            System.Console.WriteLine(flavors.Count);
            System.Console.WriteLine(flavors[3]);
            flavors.RemoveAt(3);
            System.Console.WriteLine(flavors.Count);

            Dictionary<string,string> nameKeys = new Dictionary<string,string>();
            foreach( var name in nameArray){
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach( var name in nameArray){
                int randInx = rand.Next(flavors.Count-1);
                nameKeys[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }

            foreach(var entry in nameKeys){
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }

        }
    }
}
