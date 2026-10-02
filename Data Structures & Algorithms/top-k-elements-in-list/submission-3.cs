

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Step 1: Count frequencies
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!freqMap.ContainsKey(num)) {
                freqMap[num] = 1;
            } else {
                freqMap[num]++;
            }
        }

        // Step 2: Convert to list for sorting
        List<KeyValuePair<int, int>> freqList = new List<KeyValuePair<int, int>>();
        foreach (var pair in freqMap) {
            freqList.Add(pair);
        }

        // Step 3: Sort manually by frequency (descending)
        for (int i = 0; i < freqList.Count - 1; i++) {
            int maxIndex = i;
            for (int j = i + 1; j < freqList.Count; j++) {
                if (freqList[j].Value > freqList[maxIndex].Value) {
                    maxIndex = j;
                }
            }

            // Swap
            var temp = freqList[i];
            freqList[i] = freqList[maxIndex];
            freqList[maxIndex] = temp;
        }

        // Step 4: Extract top k keys
        int[] result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = freqList[i].Key;
        }

        return result;
    }
}
