using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            int k = 2;
            Solution sol = new Solution();
            Console.WriteLine(string.Join(", ", sol.solution(arr, k).Select(v => v.ToString())));
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {   
            for (var i = 0; i < K; i++)
            {
                for (var j = A.Length - 1; j > 0; j--)
                {
                    var mid = A[j];
                    A[j] = A[j - 1];
                    A[j - 1] = mid;
                }
            }
            return A;
        }
    }
}

