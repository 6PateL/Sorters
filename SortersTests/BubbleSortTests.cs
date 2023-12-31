﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for(int i = 0; i < 800; i++)
            {
                items.Add(rnd.Next(0, 100)); 
            }

            bubble.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            bubble.Sort();
            
            //assert
            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]); 
            }
        }
    }
}