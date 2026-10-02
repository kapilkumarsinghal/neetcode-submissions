public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> sDict = new Dictionary<char, int>();

        for(int i = 0; i< s.Length; i++){
            if(!sDict.ContainsKey(s[i])){
                sDict.Add(s[i], 1);
            }
            else{
                sDict[s[i]]++;
            }
        }

        for(int i =0; i< t.Length; i++){
            if(sDict.ContainsKey(t[i])){
                sDict[t[i]]--;
            }
        }

        foreach(var item in sDict){
            if(item.Value !=0) return false;
        }

        return true;
    }
}
