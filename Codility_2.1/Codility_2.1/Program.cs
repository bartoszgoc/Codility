using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1 };
            Solution sol = new Solution();
            Console.WriteLine(sol.solution(arr));
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int score = 0;
            Array.Sort(A);

            if (A.Length != 1)
            {
                for (int i = 0; i < A.Length - 1; i = i + 2)
                {
                    if (A[i] != A[i + 1])
                    {
                        score = A[i];
                        break;
                    }
                    score = A[A.Length - 1];
                }
            }
            else
            {
                score = A[0];
            }
            return score;
        }
    }
}
