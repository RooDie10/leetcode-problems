public class Solution {
    public int[] RunningSum(int[] nums) {
        int length = nums.Length;
        for(int i=1; i<length; i++)
        {
           nums[i]+=nums[i-1];
        }
        return nums;
    }
}
