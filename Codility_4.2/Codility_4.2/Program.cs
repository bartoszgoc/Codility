using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            int[] arr = { 1, 3, 1, 4, 2, 3, 5, 4 };
            Solution sol = new Solution();
            Console.WriteLine(sol.solution(k, arr));
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            bool[] leavesInPosition = new bool[X + 1];
            int taken = 0;
            int pos = 0;

            for (int i = 0; i < A.Length; i++)
            {
                pos = A[i];
                if (pos <= X && !leavesInPosition[pos])
                {
                    leavesInPosition[pos] = true;
                    taken++;
                }

                if (taken == X)
                {
                    return i;
                }
            }
            return -1;
        }

    }


}


