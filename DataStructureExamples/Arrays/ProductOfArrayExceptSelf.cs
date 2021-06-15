using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DataStructureExamples.Arrays
{
    public class ProductOfArrayExceptSelf
    {
        public int[] BruteProduct(int[] num)
        {
            List<int> productArray = new List<int>();

            for (int i = 1; i <= num.Length; i++)
            {
                int prod = 1;
                for (int j = 1; j <= num.Length; j++)
                {
                    if (i != j)
                    {
                        prod = prod * num[j - 1];
                    }
                }
                productArray.Add(prod);
            }
            return productArray.ToArray();
        }

        public int[] OptimisedProduct(int[] nums)
        {
            List<int> productArray = new List<int>();

            List<int> prefixArray = new List<int>();

            List<int> suffixArray = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefixArray.Add(1);
                }
                else
                {
                    int index = (prefixArray[i - 1]) * nums[i - 1];
                    prefixArray.Add(index);
                }
            }

            int lastprod = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    suffixArray.Add(1);
                }
                else
                {
                    lastprod *= nums[i + 1];
                    suffixArray.Add(lastprod);
                }
            }

            for (int i = 0; i < prefixArray.Count; i++)
            {
                var product = prefixArray[i] * suffixArray[(suffixArray.Count - 1) - i];
                productArray.Add(product);
            }


            return productArray.ToArray();
        }

        public int[] HighOptimisedProduct(int[] nums)
        {
            List<int> productArray = new List<int>();

            List<int> prefixArray = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefixArray.Add(1);
                }
                else
                {
                    int index = (prefixArray[i - 1]) * nums[i - 1];
                    prefixArray.Add(index);
                }
            }

            int lastprod = 1;
            int count = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i != nums.Length - 1)
                {
                    lastprod *= nums[i + 1];
                }

                productArray.Add(prefixArray[(prefixArray.Count - 1) - count] * lastprod);
                count++;
            }

            productArray.Reverse();
            return productArray.ToArray();
        }
    }
}
