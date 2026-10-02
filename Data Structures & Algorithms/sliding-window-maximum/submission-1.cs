public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> res = new List<int>();
        int l=0;
        int r=k-1;
        while(r<nums.Length){
            int maxNum = int.MinValue;
            for(int i=l;i<=r;i++){
                if(nums[i]>maxNum){
                    maxNum=nums[i];
                }
            }
            res.Add(maxNum);
            l++;
            r++;
        }
        int[] resf= new int[res.Count];
        for(int i=0;i<res.Count;i++){
            resf[i]=res[i];
        }
        return resf;
    }
}
