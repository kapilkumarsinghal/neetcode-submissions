public class Solution {
    public bool IsValid(string s) {
        Stack<char> arr= new Stack<char>();

        for(int i=0;i<s.Length;i++){
            if(s[i]=='(' || s[i]=='{' || s[i]=='['){
                arr.Push(s[i]);
            }
            else{
                if(arr.Count>0 && ((arr.Peek()=='(' && s[i]==')') || (arr.Peek()=='{' && s[i]=='}') || (arr.Peek()=='[' && s[i]==']'))){
                    arr.Pop();
                }
                else{
                    return false;
                }
            }
            
        }
        if(arr.Count==0){
            return true;
        }
        else{
            return false;
        }
    }
}
