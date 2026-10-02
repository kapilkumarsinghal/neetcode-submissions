public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] result = new int[k];
        if(nums.Length==1){
            return new int[]{nums[0]};
        }
        for(int i=0;i<nums.Length;i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],1);
            }
            else{
                map[nums[i]] = map[nums[i]]+1;
                
            }
        }
        List<int>[] freq = new List<int>[nums.Length+1];
        for(int i=0;i<freq.Length;i++){
            freq[i] = new List<int>();
        }
        foreach(var keyval in map){
            freq[keyval.Value].Add(keyval.Key);
        }
        int countofresultelements = 0;
        for(int i=freq.Length-1;i>=1;i--){
            int elementsTobeAdded= freq[i].Count;
            while(elementsTobeAdded>0){
                result[countofresultelements] = freq[i][elementsTobeAdded-1];
                elementsTobeAdded--;
                countofresultelements++;
            }
            if(countofresultelements==k){
                break;
            }
        }
        
        return result;
    }
}