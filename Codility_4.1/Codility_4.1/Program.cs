using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Solution
        {
            public int solution(int[] A)
            {
                Array.Sort(A);
                int score = 1;
                if (A.Length == 1 && A[0] != 1)
                {
                    score = 0;
                }
                else
                {
                    if (A.Length >= 1 && A[0] != 1)
                    {
                        score = 0;
                    }
                    else
                    {
                        for (int i = 0; i < A.Length - 1; i++)
                        {
                            if (A[i + 1] - A[i] != 1)
                            {
                                score = 0;
                                break;
                            }
                        }
                    }
                }

                return score;
            }

        }
    }
}
