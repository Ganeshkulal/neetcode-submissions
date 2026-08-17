public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int lp=0;
        int rp= (numbers.Length-1);
        while(lp<rp)
        {
            while((numbers[lp]+numbers[rp]) < target)
            lp++;
             while((numbers[lp]+numbers[rp]) > target)
             rp--;
            if( numbers[lp]+numbers[rp]==target )
            {
                return new int[]{lp+1,rp+1};
            }
        }
         return new int[]{lp+1,rp};

    }
}
