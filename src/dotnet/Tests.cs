using System;

namespace Tests
{
    public class Helper
    {
        const int randomUpperBound = 100;

        public static int[] CreateRandomIntArray(int n)
        {
            Random rand = new Random();
            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
                result[i] = rand.Next(randomUpperBound);

            return result;
        }

        public static void PrintArray<T>(T[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }

    class Test
    {
        public static bool TestArrayEquals<T>(T[] expected, T[] actual) where T : IComparable
        {
            if (expected.Length != actual.Length)
                return false;
            
            for (int i = 0; i < expected.Length; i++)
                if (expected[i].CompareTo(actual[i]) != 0)
                    return false;
            return true;
        }
    }
}