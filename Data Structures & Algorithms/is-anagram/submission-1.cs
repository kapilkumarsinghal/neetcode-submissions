public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> sDictionary = new Dictionary<char,int>();
        if(s.Length != t.Length) return false;
        for(int i = 0;i<s.Length;i++){
            if(sDictionary.ContainsKey(s[i])){
                sDictionary[s[i]] += 1;
            }
            else{
                sDictionary.Add(s[i],1);
            }
        }
        for(int i = 0; i<t.Length; i++){
            if(sDictionary.ContainsKey(t[i])){
                sDictionary[t[i]] -= 1;
            }
            else{
                return false;
            }
        }
        foreach(KeyValuePair<char,int> item in sDictionary){
            if(item.Value != 0)return false;
        }
        return true;
    }
}
