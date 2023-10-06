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
    public class ShellSortTests
    {
        [TestMethod()]
        public void MakeSortTest()
        {
            var Shell = new ShellSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 800; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            Shell.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            Shell.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], Shell.Items[i]);
            }
        }
    }
}