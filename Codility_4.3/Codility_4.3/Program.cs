using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, -3 };
            Console.WriteLine(Solution.solution(arr));
            Console.ReadKey();

        }
    }

    class Solution
    {
        public static int solution(int[] A)
        {
            List<int> listArray = A.Distinct().ToList<int>();
            listArray.RemoveAll(x => x < 0);
            listArray.Sort();
            bool flag = false;

            int[] tab = listArray.ToArray();

            int score = 0;

            if (tab.Min() > 1 || tab.Length == 0)
            {
                score = 1;
            }
            else if (tab.Length == 1 && tab[0] ==0)
            {
                score = 1;
            }
            else
            {
                for (int i = 0; i < tab.Length-1; i++)
                {
                    if (tab[i+1]-tab[i] != 1)
                    {
                        flag = true;
                        score = tab[i] + 1;
                        break;
                    }
                }
                if (flag == false)
                {
                    score = tab[tab.Length - 1] + 1;
                }
            }


            return score;
        }
    }
}
