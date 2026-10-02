public class MinStack {
    private Stack<int> minStack;
    private Stack<int> resStack;
    public MinStack() {
        minStack = new Stack<int>();
        resStack= new Stack<int>();
    }
    
    public void Push(int val) {
        minStack.Push(val);
        val = Math.Min(val,resStack.Count==0 ? val : resStack.Peek());
        resStack.Push(val);
    }
    
    public void Pop() {
        minStack.Pop();
        resStack.Pop();
    }
    
    public int Top() {
        return minStack.Peek();   
    }
    
    public int GetMin() {
        return resStack.Peek();
    }
}
