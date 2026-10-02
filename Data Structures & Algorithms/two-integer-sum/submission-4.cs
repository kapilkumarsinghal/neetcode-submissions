public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> arr = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int res = target-nums[i];
            if(arr.ContainsKey(res)){
                return new int[] {arr[res],i};
            }
            arr[nums[i]]=i;
        }
        return new int[] {};
    }
}
