public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> result = new Dictionary<char, int>();
        
        if(s.Length != t.Length) return false;
        for(int i=0;i< s.Length; i++){
            if(result.ContainsKey(s[i])){
                result[s[i]]++;
            }
            else{
                result.Add(s[i], 1);
            }
            if(result.ContainsKey(t[i])){
                result[t[i]]--;
            }
            else{
                result.Add(t[i], -1);
            }
        }

        foreach(var item in result){
            if(item.Value !=0) return false;
        }
        return true;
    }
}
