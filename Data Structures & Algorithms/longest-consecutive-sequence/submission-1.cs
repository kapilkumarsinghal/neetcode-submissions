public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0){
            return 0;
        }
        if(nums.Length==1){
            return 1;
        }
        Array.Sort(nums);
        int tempMax=1;
        int finalMax=1;
        int intValue= nums[0];
        // for(int i=0;i<nums.Length;i++){
        //     Console.Write(nums[i]+" ");
        // }
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==(intValue+1)){
                intValue +=1;
                tempMax +=1;
                //Console.WriteLine(tempMax);
            }
            else if(nums[i]==intValue){
                
            }
            else{
                intValue=nums[i];
                tempMax =1;
            }
            if(tempMax>finalMax){
                    finalMax=tempMax;
                }
        }
        return finalMax;
    }
}
