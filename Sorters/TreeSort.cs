using Sorters.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class TreeSort<T> : AlgortihtmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sortedCollection = tree.Inorder(); 
            Items = sortedCollection;
        }
    }
}
