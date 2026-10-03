public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
    
        int longSequence = 0;
        foreach(int num in nums){
            if(!numSet.Contains(num-1)){
                int length = 0;
                while(numSet.Contains(num+length)){
                    length++;
                }
                longSequence = int.Max(longSequence, length);
            }
        }
        return longSequence;
    }
}
