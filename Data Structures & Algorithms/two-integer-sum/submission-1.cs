public class Solution {
    public int[] TwoSum(int[] nums, int target) {
Dictionary<int,int> d = new Dictionary<int,int>();
int r=0;
for (int i=0;i<nums.Length;i++)
{
    r = target-nums[i];
    if(d.ContainsKey(r))
    {
      return new int[] { d[r], i };
    }


else
d.Add(nums[i],i);
}
 return new int[] { 0,0};
    }
}
