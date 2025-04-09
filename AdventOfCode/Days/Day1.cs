using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCodeChallanges.Days
{
    public class Day1
    {
        private readonly int[] _leftList;
        private readonly int[] _rightList;

        public Day1()
        {
            string basePath = @"Input/";
            string leftFile = Path.Combine(basePath, "leftList.txt");
            string rightFile = Path.Combine(basePath, "rightList.txt");

            if (!File.Exists(leftFile) || !File.Exists(rightFile))
            {
                throw new FileNotFoundException("One or both input files are missing.");
            }

            _leftList = File.ReadAllLines(leftFile).Select(int.Parse).ToArray();
            _rightList = File.ReadAllLines(rightFile).Select(int.Parse).ToArray();

            if (_leftList.Length != _rightList.Length)
            {
                throw new InvalidOperationException("The lists must have the same length.");
            }
        }

        public long Part1()
        {
            int[] sortedLeft = (int[])_leftList.Clone();
            int[] sortedRight = (int[])_rightList.Clone();

            Array.Sort(sortedLeft);
            Array.Sort(sortedRight);

            long totalDistance = 0;
            for (int i = 0; i < sortedLeft.Length; i++)
            {
                totalDistance += Math.Abs(sortedLeft[i] - sortedRight[i]);
            }

            return totalDistance;
        }

        public long Part2()
        {
            long similarityScore = 0;

            foreach (var number in _leftList)
            {
                int countInRightList = _rightList.Count(x => x == number);
                similarityScore += number * countInRightList;
            }

            return similarityScore;
        }
    }
}
