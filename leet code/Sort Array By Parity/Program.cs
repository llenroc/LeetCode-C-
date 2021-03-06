﻿using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/sort-array-by-parity/
/*
Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.

 

Example 1:

Input: [3,1,2,4]
Output: [2,4,3,1]
The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
 

Note:

1 <= A.length <= 5000
0 <= A[i] <= 5000 
*/
namespace Sort_Array_By_Parity
{
    public static class AppHelper
    {
        //using linq
        public static Int32[] Sorted(Int32[] array)
        {
            return array.OrderBy(a => a % 2 == 0 ? -a : a).ToArray();
        }
        //using two pointer
        public static Int32[] Sort(Int32[] arr)
        {
            Int32 temp;
            if (arr.Length == 1 || arr.Length == 0)
            {
                return arr;
            }
            Int32 i = 0;
            Int32 j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] % 2 != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return arr;
        }
        public static Int32[] TwoLists(Int32[] arr)
        {
            if (arr.Length == 1 || arr.Length == 0)
            {
                return arr;
            }
            List<Int32> lsteven = arr.Where(a => a % 2 == 0).Select(g => g).ToList<Int32>();
            List<Int32> lstodd = arr.Where(a => a % 2 != 0).Select(g => g).ToList<Int32>();
            lsteven.AddRange(lstodd);
            return lsteven.ToArray<Int32>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = AppHelper.Sorted(new int[] { 4, 1, 3, 2 });
            Console.Write(String.Join(" ", array.Select(a => a)));
        }
    }
}
