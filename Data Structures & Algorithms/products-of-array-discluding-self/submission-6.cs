public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] leftMult = new int[nums.Length];
        int[] rightMult = new int[nums.Length];
        int[] res = new int[nums.Length];

        int tempMult = 1;
        for(int i=0; i<nums.Length;i++){
            tempMult *= nums[i];
            leftMult[i] = tempMult;
        }
        
        int tempRight = 1;
        for(int i= nums.Length-1; i>=0; i--){
            tempRight *= nums[i];
            rightMult[i] = tempRight;
        }

        res[0] = rightMult[1];
        for(int i=1; i< nums.Length-1;i++){
            res[i] = leftMult[i-1] * rightMult[i+1];
        }
        res[nums.Length-1] = leftMult[nums.Length-2];

        return res;
    }
}
