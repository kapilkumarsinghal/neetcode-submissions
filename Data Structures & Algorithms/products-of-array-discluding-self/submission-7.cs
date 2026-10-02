public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] leftMul = new int[nums.Length];
        int[] rightMul = new int[nums.Length];
        int[] res = new int[nums.Length];

        int left = 1;
        for(int i=0; i<nums.Length; i++){
            left *= nums[i];
            leftMul[i] = left;
        }

        int right = 1;
        for(int i=nums.Length-1; i>=0; i--){
            right *= nums[i];
            rightMul[i] = right;
        }

        res[0] = rightMul[1];
        for(int i=1; i< nums.Length -1; i++){
            res[i] = leftMul[i-1] * rightMul[i+1];
        }
        res[nums.Length-1] = leftMul[nums.Length-2];
        return res;
    }
}
