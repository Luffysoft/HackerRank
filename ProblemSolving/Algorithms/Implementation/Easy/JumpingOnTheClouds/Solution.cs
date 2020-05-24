namespace JumpingOnTheClouds
{
    public static class Solution
    {
        public static int JumpingOnClouds(int[] clouds)
        {
            var result = 0;

            var i = 0;
            while (i < clouds.Length - 1)
            {
                i += i + 2 < clouds.Length && clouds[i + 2] == 0 ? 2 : 1;
                result++;
            }

            return result;
        }
    }
}
