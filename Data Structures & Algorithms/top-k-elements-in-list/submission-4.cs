public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> res = new Dictionary<int, int>();

        foreach(int item in nums){
            if(!res.ContainsKey(item)){
                res.Add(item, 0);
            }
            res[item]++;
        }

        List<int>[] bucket = new List<int>[nums.Length+1];

        foreach(var item in res){
            if(bucket[item.Value] == null){
                bucket[item.Value] = new List<int>();
            }

            bucket[item.Value].Add(item.Key);
        }

        List<int> ans = new List<int>();
        for(int i = bucket.Length-1; i>=0 && ans.Count < k; i--){
            if(bucket[i] != null){
                foreach(int val in bucket[i]){
                    ans.Add(val);

                    if(ans.Count == k){
                        break;
                    }
                }
            }
        }

        return ans.ToArray();
    }
}
