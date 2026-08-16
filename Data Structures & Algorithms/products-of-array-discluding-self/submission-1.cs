public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] left = new int[len];
        int[] right = new int[len];
        int[] ret = new int[len];
        int rright =1, rleft =1;
        int li=len-1;
        int fromlast = li;

        for (int i=0;i<len;i++)
        {
            rleft = (i==0?1:nums[i-1])*rleft;
            left[i] = rleft;
            fromlast =li-i;
            rright = (fromlast==li?1:nums[fromlast+1])*rright;
            right[fromlast] = rright;

        }

         for (int i=0;i<len;i++)
         {
           // Console.WriteLine(right[i]);
           // Console.WriteLine(left[i]);

            ret[i] = right[i]*left[i];
         }

         return ret;
    }
}
