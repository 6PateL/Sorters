using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class BubbleSort<T> : AlgortihtmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count; 

            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1]; 

                    if(a.CompareTo(b) == 1)
                    {
                        Swap(j, j + 1);
                        ComprasionCount++;
                    }
                }
            }
        }
    }
}
