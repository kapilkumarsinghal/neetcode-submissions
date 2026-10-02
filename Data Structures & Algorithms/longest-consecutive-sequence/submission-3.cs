public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        Array.Sort(nums);
        int prevNum = nums[0];
        int maxLength=1;
        int tempLength=1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==prevNum){

            }
            else if(nums[i]==(prevNum+1)){
                tempLength++;
            }
            else{
                tempLength=1;
            }
            //Console.WriteLine("prev and Curr value is "+ prevNum+ " "+nums[i]);
            //Console.WriteLine("tmep length and maxLength is "+ tempLength +" "+maxLength);
            if(tempLength>maxLength){
                maxLength=tempLength;    
            }
            prevNum=nums[i];
        }
        return maxLength;
    }
}
