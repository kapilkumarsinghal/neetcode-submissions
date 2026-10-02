public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] charCount=new int[26];
        int[] charCountB = new int[26];
        int left=0;
        int right=0;
        for(int i=0;i<s1.Length;i++){
            charCount[s1[i]-'a']++;
        }
        int count=0;
        while(right<s2.Length){
            charCountB[s2[right]-'a']++;
            if(right-left+1==s1.Length){
                if(Enumerable.SequenceEqual(charCountB,charCount)){
                    return true;
                }
                charCountB[s2[left]-'a']--;
                left++;
            }
            right++;
        }
        return false;
        
    }
}
