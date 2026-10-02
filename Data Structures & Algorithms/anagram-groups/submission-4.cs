public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = 
        new Dictionary<string, List<string>>();

        foreach(string s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sorteds = new string(charArray);
            if(!res.ContainsKey(sorteds)){
                res[sorteds] = new List<string>();
            }
            res[sorteds].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
