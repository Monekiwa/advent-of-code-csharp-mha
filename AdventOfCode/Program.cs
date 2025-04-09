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
                Console.WriteLine("Running Day 1...");
                var day1 = new Day1(); 
                Console.WriteLine($"Day 1 Part 1 - Total Distance: {day1.Part1()}");
                Console.WriteLine($"Day 1 Part 2 - Similarity Score: {day1.Part2()}");
                Console.WriteLine(); 

                Console.WriteLine("Running Day 2...");
                string inputData = System.IO.File.ReadAllText(@"Input/data.txt");

                int safeReportsPart1 = Day2.CountSafeReports(inputData);
                Console.WriteLine($"Day 2 Part 1 - Safe reports: {safeReportsPart1}");

                int safeReportsPart2 = Day2.CountSafeReportsWithDampener(inputData);
                Console.WriteLine($"Day 2 Part 2 - Safe reports with dampener: {safeReportsPart2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
