using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventCodeChallanges.Days
{
    public class Day2
    {
        public static int CountSafeReports(string inputData)
        {
            string[] lines = inputData.Trim().Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.RemoveEmptyEntries
            );

            int safeCount = 0;

            foreach (string line in lines)
            {
                List<int> report = line.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries
                ).Select(int.Parse).ToList();

                if (IsSafeReport(report))
                {
                    safeCount++;
                }
            }

            return safeCount;
        }

        public static int CountSafeReportsWithDampener(string inputData)
        {
            string[] lines = inputData.Trim().Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.RemoveEmptyEntries
            );

            int safeCount = 0;

            foreach (string line in lines)
            {
                List<int> report = line.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries
                ).Select(int.Parse).ToList();

                if (IsReportSafeWithDampener(report))
                {
                    safeCount++;
                }
            }

            return safeCount;
        }

        private static bool IsSafeReport(List<int> report)
        {
            if (report.Count < 2)
                return false;

            bool increasing;
            if (report[1] > report[0])
                increasing = true;
            else if (report[1] < report[0])
                increasing = false;
            else
                return false;

            for (int i = 0; i < report.Count - 1; i++)
            {
                int diff = report[i + 1] - report[i];
                if ((increasing && diff <= 0) || (!increasing && diff >= 0))
                    return false;

                int absDiff = Math.Abs(diff);
                if (absDiff < 1 || absDiff > 3)
                    return false;
            }

            return true;
        }

        private static bool IsReportSafeWithDampener(List<int> report)
        {
            if (IsSafeReport(report))
                return true;

            if (report.Count < 3)
                return false;

            for (int i = 0; i < report.Count; i++)
            {
                List<int> modifiedReport = new List<int>(report);
                modifiedReport.RemoveAt(i);

                if (IsSafeReport(modifiedReport))
                    return true;
            }

            return false;
        }
    }
}
