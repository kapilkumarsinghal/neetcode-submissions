public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> res = new Dictionary<int, int>(nums.Length);
        
        for(int i=0; i< nums.Length; i++){
            int value = target - nums[i];
            if(res.ContainsKey(value)){
                return new int[] {res[value], i};
            }
            res.Add(nums[i], i);
        }
        return new int[] {};
    }
}
