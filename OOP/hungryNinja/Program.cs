using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public string GetInfo()
            {
                return $"Your {Name} has {Calories} calories. Is it spicy? {IsSpicy}. Is it sweet? {IsSweet}";
            }

        //constructor to take all 4 parameters

        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
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
                new Food("Pasta", 900, false, false),
                new Food("Tacos", 400, true, false),
                new Food("ButterFinger", 250, false, true),
                new Food("Salmon", 200, false, false),
                new Food("Steak", 500, false, false),
                new Food("Curry", 450, true, false),
                new Food("Ice Cream", 350, false, true),
            };
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        //add constuctor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        //add public getter property called IsFull
        public bool Isfull{get;set;}
        //build out Eat method
        public void Eat(Food item)
        {
            if(calorieIntake <= 1000)
            {
                calorieIntake =+ item.Calories;
                FoodHistory.Add(item);
                item.GetInfo();
                Isfull = false;
            }
            else
            {
                System.Console.WriteLine("This ninja is full!!!");
                Isfull = true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
