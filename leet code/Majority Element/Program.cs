﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    //https://leetcode.com/problems/majority-element/
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array =Console.ReadLine().Split(new String[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
            var p = array.GroupBy(a => a).Select(b => new { Key = b.Key, Count = b.Count() });
            int x = p.OrderByDescending(a2 => a2.Count).Select(a1 => a1.Key).FirstOrDefault();
        }
    }
}
