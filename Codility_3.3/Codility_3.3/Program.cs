using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_3._3
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
            if (A.Length != 0)
            {
                Array.Sort(A);
                int missing = 0;
                int flaga = 0;

                if (A.Length == 1)
                {
                    if (A[0] == 2)
                    {
                        missing = 1;
                    }
                    else
                    {
                        missing = 2;
                    }
                }
                else

                    for (int i = 1; i < A.Length; i++)
                    {
                        if (A[i] - A[i - 1] == 1)
                        {
                            flaga = 1;
                        }
                        else if (A[i] - A[i - 1] != 1)
                        {
                            flaga = 0;
                            missing = A[i - 1] + 1;
                            break;
                        }
                    }
                if (flaga == 1 && A[0] != 1)
                {
                    missing = 1;
                }
                else if (flaga == 1 && A[0] == 1)
                {
                    missing = A.Max() + 1;
                }
                {

                }
                return missing;
            }
            return 1;

        }
    }
}
