using System;
using AdventCodeChallanges.Days;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Day1 day1 = new Day1();

                long part1Result = day1.Part1();
                Console.WriteLine("Part 1: " + part1Result);

                long part2Result = day1.Part2();
                Console.WriteLine("Part 2: " + part2Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
