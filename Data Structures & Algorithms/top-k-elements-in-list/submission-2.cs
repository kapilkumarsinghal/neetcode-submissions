public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> res = new Dictionary<int,int>();
        var arr = new List<int>();
        foreach(int val in nums){
            if(!res.ContainsKey(val)){
                res[val] =1;
            }
            else{
                res[val] +=1;
            }
        }
        
            return res
                .OrderByDescending(pair => pair.Value)
                .Take(k)
                .Select(pair => pair.Key)
                .ToArray();

    }
}
