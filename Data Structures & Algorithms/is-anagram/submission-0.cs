public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!= t.Length){
            return false;
        }
        Dictionary<char,int> anagram = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            if(anagram.ContainsKey(s[i])){
                anagram[s[i]] = anagram[s[i]]+1;
            }
            else{
                anagram.Add(s[i],1);
            }
            
        }
        for(int i=0;i<t.Length;i++){
            if(anagram.ContainsKey(t[i])){
                anagram[t[i]] = anagram[t[i]]-1;
            }
            else{
                return false;
            }
        }
        for(int i=0;i<s.Length;i++){
            if(anagram[s[i]]!=0){
                return false;
            }
        }
        return true;
    }
}
