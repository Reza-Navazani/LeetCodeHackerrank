using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHackerrank.Solutions
{
    public class IsMatch
    {
        public bool IsMatchMethod(string s, string p)
        {
            int m = s.Length, n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];

            dp[0, 0] = true; // empty string matches empty pattern

            // Fill first row for patterns like x*, x*y*
            for (int j = 2; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        // Zero occurrence of previous char
                        dp[i, j] = dp[i, j - 2];

                        // One or more occurrences
                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        {
                            dp[i, j] = dp[i, j] || dp[i - 1, j];
                        }
                    }
                }
            }

            return dp[m, n];
        }

        public static void Main()
        {
            IsMatch isMatch = new IsMatch();
            Console.WriteLine(isMatch.IsMatchMethod("a", "a"));
        }
    }
}
