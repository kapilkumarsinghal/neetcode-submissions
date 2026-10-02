public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> map = new HashSet<char>();
        int l=0;
        int res=0;
        for(int i=0;i<s.Length;i++){
            while(map.Contains(s[i])){
                map.Remove(s[l]);
                l++;
            }
            map.Add(s[i]);
            res= Math.Max(res,i-l+1);
        }
        return res;
    }
}