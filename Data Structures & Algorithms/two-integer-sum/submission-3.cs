public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> res = new Dictionary<int,int>();
        int diff =0;
        for(int i=0;i<nums.Length;i++){
            diff = target - nums[i];
            if(res.ContainsKey(diff)){
                return new int[] {res[diff],i};
            }
            res[nums[i]] = i;
        }
        return new int[0];
    }
}
