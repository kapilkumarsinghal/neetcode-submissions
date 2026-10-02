public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> arr = new HashSet<int>();
        for(int i=0; i<nums.Length; i++){
            if(arr.Contains(nums[i])) return true;
            arr.Add(nums[i]);
        }
        return false;
    }
}