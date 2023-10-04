using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class AlgortihtmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        public int SwapCount { get; protected set; } = 0;
        public int ComprasionCount { get; protected set; } = 0; 

        protected void Swap(int positionA, int positionB)
        {
            if(positionA < Items.Count &&  positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB]; 
                Items[positionB] = temp;

                SwapCount++;
            }
        }

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;
            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort(); 
        }
    }
}
