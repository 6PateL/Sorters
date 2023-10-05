using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] c = { 1, 2, 3, 4, 5 }; 

            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] < c[i - 1])
                {
                    c[i] = c[i - 1];
                    Console.WriteLine(c[i]);
                }
            }
        }
    }
}
