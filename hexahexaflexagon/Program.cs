using System;
using System.ComponentModel.Design;

namespace hexahexaflexagon
{
    internal class Program
    {
       static int[,] hexa = { { -1, -1, 1 }, { 3, 5, -1 }, { 1, 6, -1 }, { 2, 4, -1 }, { 8, -1, -1 }, { 0, -1, -1 }, { 7, -1, -1 }, { -1, -1, 2 }, { -1, -1, 3 } };
        static void Main(string[] args)
        {
            int currentSide = 3;
            string choice = "";
            Console.WriteLine($"current Side is {currentSide}");
            do
            { Console.WriteLine("Which way are you going to fold? a, b or c ? any other value will exit.");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "a":
                        if (hexa[currentSide, 0] == -1)
                        {
                            Console.WriteLine("You can't fold that way");
                            
                        }
                        else
                        {
                            currentSide = hexa[currentSide, 0];
                            Console.WriteLine($"You are now at side {currentSide}");
                        }
                        break;
                    case "b":
                        if (hexa[currentSide, 1] == -1)
                        {
                            Console.WriteLine("You can't fold that way");
                            
                        }
                        else
                        {
                            currentSide = hexa[currentSide, 1];
                            Console.WriteLine($"You are now at side {currentSide}");
                        }
                        break;
                    case "c":
                        if (hexa[currentSide, 2] == -1)
                        {
                            Console.WriteLine("You can't fold that way");
                            
                        }
                        else
                        {
                            currentSide = hexa[currentSide, 2];
                            Console.WriteLine($"You are now at side {currentSide}");
                        }
                        break;
                    default: Console.WriteLine("That is not an acceptable value - exiting");
                        break;
                } 
            }
            while (choice == "a" || choice == "b" || choice == "c");
        }
    }
}
