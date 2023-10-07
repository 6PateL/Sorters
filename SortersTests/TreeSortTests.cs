using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters.Tests
{
    [TestClass()]
    public class TreeSortTest
    {
        [TestMethod()]
        public void MakeSortTest()
        {
            var tree = new TreeSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 800; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            tree.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            tree.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], tree.Items[i]);
            }
        }
    }
}