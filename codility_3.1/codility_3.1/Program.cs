using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 2)
            {
                return A[1] - A[0];
            }
            else
            {
                List<int> diff = new List<int>();

                int left = 0;
                int sum = A.Sum();
                foreach (var item in A)
                {
                    left += item;
                    diff.Add(Math.Abs((sum - left) - left));
                }
                return diff.Min();
            }
        }
    }

}
