//https://leetcode.com/problems/subarray-sum-equals-k/
//https://leetcode.com/problems/product-of-array-except-self
//https://leetcode.com/problems/merge-intervals/

/*
 Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExamples.Arrays
{
    public class SubarraySumEqualsK
    {
        /*           
        Time complexity : O(n^2). We need to consider every subarray possible.
        Space complexity : O(1). Constant space is used.
         */
        public int SubarraySumHack(int[] nums, int k)
        {
            int noOfSubArrays = 0;

            if (nums.Count() == 0)
                return noOfSubArrays;

            for (int i = 0; i < nums.Length; i++)
            {
                var accumulatedSum = 0;    

                for (int j = i ; j < nums.Length; j++)
                {
                    accumulatedSum += nums[j];
                    if (accumulatedSum == k)
                        noOfSubArrays ++;
                }
            }

            return noOfSubArrays;         
        }

        public int SubarraySum(int[] nums, int k)
        {
            int count = 0, sum = 0;

            Dictionary<int, int> sumOccurrencesMap = new Dictionary<int, int>();
            sumOccurrencesMap.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                var diff = sum - k;               

                if (sumOccurrencesMap.ContainsKey(diff))
                {
                    count += sumOccurrencesMap[diff];
                    //count ++;
                }

                sumOccurrencesMap.TryGetValue(sum, out int val);
                sumOccurrencesMap[sum] = val+ 1;
            }

            return count;
        }
    }
}
