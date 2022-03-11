using System;

namespace SortierAlgorhytmus_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arraysort = {45,10,15,4};

            Console.WriteLine("Ihr Array unsortiert:");
            foreach (int value in Arraysort)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine("Ihr Array sortiert:");
            Array.Sort(Arraysort);
            foreach (int value in Arraysort)
            {
                Console.WriteLine(value + " ");
            }
            Console.ReadKey();

        }
    }
}
