public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l=0;
        int r=0;
        int maxSum=0;
        int maxCount=0;
        int[] charCounts = new int[26];
        while(r<s.Length){
            charCounts[s[r]-'A']++;
            maxCount = Math.Max(maxCount,charCounts[s[r]-'A']);
            while(r-l+1-maxCount>k){
                charCounts[s[l]-'A']--;
                l++;
            }
            maxSum = Math.Max(maxSum, r - l + 1);
            r++;

        }
        return maxSum;
    }
}
