using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            
            Console.WriteLine(sol.solution(20,50,20));
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            double diff = Y - X;

            int score = Convert.ToInt32(Math.Ceiling(diff / D));

            return score;
        }
    }
}
