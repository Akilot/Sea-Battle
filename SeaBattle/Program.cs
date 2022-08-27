using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("The number of attempts isn't directly proportional to the size of the BattleGrid.\t");


            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.Write("\nEnter the number of cells vertically...\t\t");
            byte ElementsCountY = byte.Parse(Console.ReadLine());


            Console.Write("\nEnter the number of cells horizontally...\t");
            byte ElementsCountX = byte.Parse(Console.ReadLine());


            Console.Write("\nEnter the number of attemps...\t\t");
            int NumberOfAttempts = int.Parse(Console.ReadLine());

            if (NumberOfAttempts <= 0 || ElementsCountX <= 0 || ElementsCountY <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Error entering data, please try again...\t");
            }
            else
            {

                Random rand = new Random();


                byte[,] BattleGrid = new byte[ElementsCountY, ElementsCountX];
                for (int i = 0; i <= NumberOfAttempts; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("\nEnter coords...\t");


                    Console.Write($"Enter number from 0 to {ElementsCountY}, it is (colum)...\t");
                    int coordY = int.Parse(Console.ReadLine());

                    Console.Write($"Enter number from 0 to {ElementsCountX}, it is (row)...\t");
                    int coordX = int.Parse(Console.ReadLine());


                    int[,] TargetCoords = new int[coordY, coordX];

                    int rightcoordY = rand.Next(0, ElementsCountY);
                    int rightcoordX = rand.Next(0, ElementsCountX);


                    if (coordX > ElementsCountX || coordY > ElementsCountY || coordX < 0 || coordY < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Error entering data, please try again...\t");
                    }

                    else if (rightcoordY == coordY && rightcoordX == coordX)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSHIP DESTROYED.Keep it up !!!");
                    }
                    else if (rightcoordY != coordY || rightcoordX != coordX)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMISS, try agsin !!!");
                    }
                }
                Console.ReadLine();
            }


        }
    }
}
