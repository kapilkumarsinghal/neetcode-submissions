public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i=0;
        int j =nums.Length-1;
        while(i<j){
            if(nums[i]+nums[j]==target){
                return new int[]{i+1,j+1};
            }
            else if (nums[i]+nums[j]>target){
                j -=1;
            }
            else{
                i +=1;
            }
        }
        return new int[0];
    }
}
