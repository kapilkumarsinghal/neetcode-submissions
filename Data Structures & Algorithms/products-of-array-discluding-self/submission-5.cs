public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] arr = new int[size];
        int[] brr = new int[size];
        int[] crr = new int[size];
        int prod = 1;
        int rprod =1;
        for(int i=0;i<size;i++){
            arr[i] = prod;
            prod = prod*nums[i];
        }
        for(int i=size-1;i>=0;i--){
            brr[i] = rprod;
            rprod = rprod * nums[i];
        }
        for(int i=0;i<size;i++){
            crr[i] = arr[i]*brr[i];
        }
        return crr;

    }
}
