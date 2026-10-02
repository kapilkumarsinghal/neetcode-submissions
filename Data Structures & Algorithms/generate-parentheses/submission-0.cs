public class Solution {  

    public void Backtrack(int openN, int closeN, int n,
     List<string> res, string stack){
        if(openN== closeN && openN==n){
            res.Add(stack);
            return;
        }
        if(openN<n){
            Backtrack(openN+1,closeN,n,res,stack+"(");
        }
        if(closeN<openN){
            Backtrack(openN, closeN+1,n,res,stack+")");
        }
     }


    public List<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        string stack="";
        Backtrack(0,0,n,res,stack);
        return res;
    }
}
