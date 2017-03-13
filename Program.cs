using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] A = { 1, 3, 6, 4, 1, 2};
            //int[] A = { 1 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {
       
        public int solution(int[] A)
        {
            Array.Sort(A);
            int N = A.Length;
            int min = 1;
            for (int i = 0; i < N; i++) {
                if (A[i] == min) min++;
            }
            return min;
        }
    }
}
