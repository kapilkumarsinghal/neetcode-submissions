public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> setnums= new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(!setnums.Add(nums[i])){
                return true;
            }
        }
        return false;


    }
}
