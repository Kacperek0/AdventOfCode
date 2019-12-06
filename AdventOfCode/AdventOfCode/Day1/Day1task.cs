using System;
namespace AdventOfCode.Day1
{
    public class Day1task
    {
        public Day1task()
        {

            string[] lines = System.IO.File.ReadAllLines(@"/Users/kacper.szczepanek/Documents/AdventOfCode/AdventOfCode/AdventOfCode/Day1/input.txt");
            int[] input = new int[lines.Length];
            int i = 0;
            int sum = 0;

            foreach (var item in lines) //Change all strings from text file to ints in array input
            {
                input[i] = int.Parse(item);
                i++;
            }

            foreach (var item in input)
            {
                sum += SantaFuelCalculateAll(item);
            }

            Console.WriteLine(sum);

        }

        public int SantaFuelCalculateAll(int mass)
        {
            int sumFuel = 0;
            while (mass > 0)
            {
                int r = SantasFuellCalculate(mass);
                sumFuel += r;
                mass = r;
            }

            return sumFuel;
        }

        public int SantasFuellCalculate(int mass)
        {
            int fuellNeeded;

            fuellNeeded = mass / 3;
            fuellNeeded -= 2;

            return Math.Max(fuellNeeded, 0);
        }
    }
}
