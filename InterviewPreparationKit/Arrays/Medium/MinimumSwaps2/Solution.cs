namespace MinimumSwaps2
{
    public static class Solution
    {
        public static int MinimumSwaps(int[] arr)
        {
            var result = 0;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                while (arr[i] != i + 1)
                {
                    var tmp = arr[i];
                    arr[i] = arr[tmp - 1];
                    arr[tmp - 1] = tmp;

                    result++;
                }
            }

            return result;
        }
    }
}
