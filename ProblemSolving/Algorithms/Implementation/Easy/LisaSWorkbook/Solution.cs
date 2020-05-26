using System.Linq;

namespace LisaSWorkbook
{
    public static class Solution
    {
        public static int Workbook(int k, int[] arr)
        {
            return arr
                .SelectMany(n => Enumerable
                    .Range(1, n)
                    .GroupBy(pb => (pb - 1) / k))
                .Select((gpg, i) => new { Index = i + 1, Pages = gpg })
                .Count(gpg => gpg.Pages.Contains(gpg.Index));
        }
    }
}
