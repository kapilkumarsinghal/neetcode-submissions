public class Solution {
    public bool IsPalindrome(string s) {
        string s1="";
        for(int i=0;i<s.Length;i++){
            if(char.IsLetterOrDigit(s[i])){
                s1 += char.ToLower(s[i]);
            }
        }
        //Console.WriteLine("string is "+s1);
        int k=0;
        int j=s1.Length-1;
        while(k<j){
            if(s1[k] != s1[j]){
                return false;
            }
            k++;
            j--;
        }
        return true; 
    }
}
