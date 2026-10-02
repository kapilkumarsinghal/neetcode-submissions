public class Solution {
    public int Trap(int[] height) {
        int l= height.Length;
        int[] arr= new int[l];
        int[] brr= new int[l];
        int max1=arr[0];
        for(int i=0;i<l;i++){
            if(height[i]>max1){
                max1= height[i];
            }
            arr[i] = max1;
        }
        int max2=height[l-1];
        for(int i=l-1;i>=0;i--){
            if(height[i]>max2){
                max2= height[i];
            }
            brr[i]= max2;
        }
        int res=0;
        for(int i=0;i<l;i++){
            res += ((Math.Min(arr[i],brr[i]))-height[i]);
        }
        return res;
    }
}
