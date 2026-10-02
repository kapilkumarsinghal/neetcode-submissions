public class MinStack {
    private Stack<int> minStack;
    public MinStack() {
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        minStack.Push(val);
    }
    
    public void Pop() {
        minStack.Pop();
    }
    
    public int Top() {
        return minStack.Peek();   
    }
    
    public int GetMin() {
        Stack<int> tmp = new Stack<int>();
        int mini = minStack.Peek();

        while(minStack.Count>0){
            mini = System.Math.Min(mini,minStack.Peek());
            tmp.Push(minStack.Pop());
        }

        while(tmp.Count>0){
            minStack.Push(tmp.Pop());
        }
        return mini;
    }
}
