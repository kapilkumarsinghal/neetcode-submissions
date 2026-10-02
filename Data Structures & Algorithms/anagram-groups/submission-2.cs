public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> res = new Dictionary<string,List<string>>();
        foreach(string s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            if(!res.ContainsKey(sortedS)){
                res[sortedS] = new List<string>();
            }
            res[sortedS].Add(s); 
        }
        return res.Values.ToList<List<string>>();
    }
}
