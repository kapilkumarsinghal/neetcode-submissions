
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> res = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            res.Add(nums[i]);
        }
        if(nums.Length == res.Count){
            return false;
        }
        return true;
    }
}
