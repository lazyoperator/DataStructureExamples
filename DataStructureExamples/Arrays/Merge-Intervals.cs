// https://leetcode.com/problems/merge-intervals/

using System.Collections.Generic;
using System.Linq;

namespace DataStructureExamples.Arrays
{
    public class MergeIntervals
    {
        //Brute , expect result sorted and no merge of interval more than 2 intervals
        public int[,] Run(int[,] intervals)
        {
            int loop = (intervals.Length / 2) - 1;

            int[,] mergedIntervals = new int[4, 2];        


            for (int i = 0; i <= loop; i++)
            {
                if (i == loop)
                {
                    int start = intervals[i, 0];
                    int end = intervals[i, 1];

                    //mergedIntervalsDictionary[i]

                    mergedIntervals[i, 0] = start;
                    mergedIntervals[i, 1] = end;
                    break;
                }

                if (intervals[i, 1] >= intervals[i + 1, 0])
                {
                    int start = intervals[i, 0];
                    int end = intervals[i + 1, 1];

                    mergedIntervals[i, 0] = start;
                    mergedIntervals[i, 1] = end;
                    i++;
                }
                else
                {
                    int start = intervals[i, 0];
                    int end = intervals[i, 1];

                    mergedIntervals[i, 0] = start;
                    mergedIntervals[i, 1] = end;
                }
            }

            return mergedIntervals;
        }

        //Sorts the input
        public int[,] RunSorted(int[,] intervals)
        {
            int loop = (intervals.Length / 2) - 1;           

            SortedDictionary<int, int> intervalsSortedDictionary = new SortedDictionary<int, int>();

            for (int i = 0; i <= loop; i++)
            {
                intervalsSortedDictionary[intervals[i, 0]] = intervals[i, 1];
            }

            SortedDictionary<int, int> mergedIntervalsDictionary = new SortedDictionary<int, int>();

            for (int i = 0; i < intervalsSortedDictionary.Count; i++)
            {
                var p = intervalsSortedDictionary.ElementAt(i).Key;
                var t = intervalsSortedDictionary.ElementAt(i).Value;
            
                if(i == intervalsSortedDictionary.Count-1)
                {
                    mergedIntervalsDictionary.Add(intervalsSortedDictionary.ElementAt(i).Key, intervalsSortedDictionary.ElementAt(i).Value);
                    break;
                }

                if (intervalsSortedDictionary.ElementAt(i).Value >= intervalsSortedDictionary.ElementAt(i+1).Key)
                {
                    mergedIntervalsDictionary.Add(intervalsSortedDictionary.ElementAt(i).Key, intervalsSortedDictionary.ElementAt(i+1).Value);
                    i++;
                }
                else
                {
                    mergedIntervalsDictionary.Add(intervalsSortedDictionary.ElementAt(i).Key, intervalsSortedDictionary.ElementAt(i).Value);
                }
            }

            int[,] output = new int[mergedIntervalsDictionary.Count, 2];

            for (int i = 0; i < mergedIntervalsDictionary.Count; i++)
            {
                output[i,0] = mergedIntervalsDictionary.ElementAt(i).Key;
                output[i,1] = mergedIntervalsDictionary.ElementAt(i).Value;
            }


            return output;
        }
    }
}