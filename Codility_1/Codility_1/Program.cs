using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(42);
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            char[] znaki = Convert.ToString(N, 2).ToCharArray();
            int firstOfOnes = 0;
            int lastOfOnes = 0;

            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == '1')
                {
                    firstOfOnes = i;
                    break;
                }
            }
            for (int i = znaki.Length - 1; i >= 0; i--)
            {
                if (znaki[i] == '1')
                {
                    lastOfOnes = i;
                    break;
                }
            }

            int score = 0;
            int flaga = 0;

            for (int i = firstOfOnes; i <= lastOfOnes; i++)
            {
                if (znaki[i] == '0')
                {
                    score++;
                }
                else
                {
                    if (score > flaga)
                    {
                        flaga = score;
                    }
                    score = 0;
                }
            }
            return flaga;
        }

    }


}
