public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        for(int i=0;i<tokens.Length;i++){
            if(tokens[i]=="+"){
                int a= stack.Pop();
                int b= stack.Pop();
                stack.Push(a+b);
            }
            else if(tokens[i]=="-"){
                int a = stack.Pop();
                int b = stack.Pop();
                //Console.WriteLine("a is"+a+" b is "+b);
                stack.Push(b-a);
            }
            else if(tokens[i]=="*"){
                stack.Push(stack.Pop()* stack.Pop());
            }
            else if(tokens[i]=="/"){
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push((int) ((double)b/a));
            }
            else{
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}
