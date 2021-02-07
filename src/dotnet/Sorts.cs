using System;
using Tests;

namespace Sorts
{
    class Sort
    {
        public static void QuickSort<T>(T[] arr) where T : IComparable
        {

        }

        public static void MergeSort<T>(T[] arr) where T : IComparable
        {
            MergeSort(arr, 0, arr.Length-1);
        }

        private static void MergeSort<T>(T[] arr, int lo, int hi) where T : IComparable
        {
            // Console.WriteLine("lo={0} hi={1}", lo, hi);
            // Console.ReadLine();
            if (hi - lo <= 0)
                return;

            int mid = (hi - lo) / 2 + lo;
            MergeSort(arr, lo, mid);
            MergeSort(arr, mid+1, hi);
            Merge(arr, lo, mid, hi);
        }

        private static void Merge<T>(T[] arr, int lo, int mid, int hi) where T : IComparable
        {
            T[] merged = new T[hi - lo + 1];
            int sub1Ind = lo;
            int sub2Ind = mid+1;
            int mergedInd = 0;
            while (sub1Ind <= mid && sub2Ind <= hi)
            {
                if (Less(arr[sub1Ind], arr[sub2Ind]))
                    merged[mergedInd++] = arr[sub1Ind++];
                else
                    merged[mergedInd++] = arr[sub2Ind++];
            }
            if (sub1Ind <= mid)
                for (;sub1Ind <= mid; sub1Ind++, mergedInd++)
                    merged[mergedInd] = arr[sub1Ind];
            else
                for (;sub2Ind <= hi; sub2Ind++, mergedInd++)
                    merged[mergedInd] = arr[sub2Ind];

            for (int i = 0; i < merged.Length; i++)
                arr[lo+i] = merged[i];
        }

        public static void HeapSort()
        {

        }

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private static bool Greater<T>(T lhs, T rhs) where T : IComparable
        {
            return lhs.CompareTo(rhs) > 0;
        }

        private static bool Less<T>(T lhs, T rhs) where T : IComparable
        {
            return lhs.CompareTo(rhs) < 0;
        }
    }
    
}