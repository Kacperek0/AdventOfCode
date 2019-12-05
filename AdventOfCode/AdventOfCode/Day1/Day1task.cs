using System;
namespace AdventOfCode.Day1
{
    public class Day1task
    {
        public Day1task()
        {

            string[] lines = System.IO.File.ReadAllLines(@"/Users/Kacper/Documents/Repos/AdventOfCode/AdventOfCode/AdventOfCode/Day1/input.txt");
            int[] input = new int[lines.Length];
            int i = 0;
            int sum = 0;
            int negativeSum = 0;

            foreach (var item in lines) //Change all strings from text file to ints in array input
            {
                input[i] = int.Parse(item);
                i++;
            }

            foreach (var item in input)
            {
                sum += SantasFuellCalculate(item);
            }

            Console.WriteLine(sum);

            Console.WriteLine(NegativeFuelCopy(SantasFuellCalculate(14)));
            Console.WriteLine(NegativeFuelCopy(SantasFuellCalculate(21)));
            Console.WriteLine(SantasFuellCalculate(1969) + NegativeFuelCopy(SantasFuellCalculate(1969)));
            Console.WriteLine(SantasFuellCalculate(100756) + NegativeFuelCopy(SantasFuellCalculate(100756)));


        }

        public int SantasFuellCalculate(int mass)
        {
            int fuellNeeded;

            fuellNeeded = mass / 3;
            fuellNeeded -= 2;

            return fuellNeeded;
        }

        public int NegativeFuell(int mass)
        {
            int fuellNeeded;

            fuellNeeded = mass / 3;
            if (fuellNeeded > 0)
            {
                if (fuellNeeded - 2 > 2)
                {
                    fuellNeeded -= 2;
                    return fuellNeeded;
                }
                else
                {
                    return fuellNeeded;
                }
            }
            else
            {
                return fuellNeeded;
            }
        }

        public int NegativeFuelCopy(int mass)
        {
            int fuellNeeded;
            int fuellSubSum = 0;

            while (mass != 0)
            {
                if (mass / 3 != 1)
                {
                    fuellNeeded = mass / 3;
                    if (fuellNeeded > 0)
                    {
                        if (fuellNeeded - 2 > 0)
                        {
                            fuellNeeded -= 2;
                            fuellSubSum += fuellNeeded;
                            mass = fuellNeeded;
                        }
                        else
                        {
                            fuellSubSum += fuellNeeded;
                            mass = fuellNeeded;
                        }
                    }
                    else
                    {
                        fuellSubSum += fuellNeeded;
                        mass = fuellNeeded;
                    }
                }
                else
                {
                    fuellSubSum += mass;
                    break;
                }
            }

            return fuellSubSum;
        }
    }
}
