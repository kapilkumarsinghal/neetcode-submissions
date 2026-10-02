public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product=1;
        int count=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                product= product*nums[i];
            }
            else{
                count++;
            }
        }
        //Console.WriteLine(product);
        int[] arr= new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0 && count<=0){
                //Console.WriteLine(nums[i]);
                arr[i]= product/nums[i];                
            }
            else if(nums[i]!=0 && count==1){
                //Console.WriteLine(nums[i]);
                arr[i] = 0;
            }
            else if( count>1){
                //Console.WriteLine(nums[i]);
                arr[i] = 0;
            }
            else if(count==arr.Length){
                Console.WriteLine(nums[i]);
                //arr[i] =0;
            }
            else{
                Console.WriteLine(nums[i]);
                arr[i]=product;
            }
        }
        return arr;
        
    }
}
