using System;
using System.ComponentModel;

namespace MethodExercise
{
    class Program
    {

        
        static void Main(string[] args)
        {
            // -----------------Exercise 1

            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is an awsome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($" Merci, {userName}!!");
            
            Console.WriteLine($" Name: {userName}");

            Console.WriteLine($" Favorite color: {color}");

            Console.WriteLine($" Favorite animial: {animal}");

            Console.WriteLine($" Favorite band: {band}");


            var amountofCars = Sum(2, 6);

            var toy = Multiply(40, 2);

            var ball = Divide(50, 5);
        }

       public  static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
    }
}
