using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class QuickSort<T> : AlgortihtmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            Qsort(0, Items.Count - 1);    
        }

        private void Qsort(int left, int right) 
        {
            if(left >= right) 
            {
                return; 
            }

            var pivot = Sorting(left, right);

            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right); 
        }

        private int Sorting(int left, int right) 
        {
            var pointer = left;

            //Опорный емелент находится под Right - адресом
            for(int i = left; i <= right; i++) 
            {
                if (Items[i].CompareTo(Items[right]) == -1) 
                {
                    Swap(pointer, i);
                    pointer++; 
                }
            }

            Swap(pointer, right);
            return pointer; 
        }
    }
}
