public class MinStack {

    private Stack<(int val, int minSoFar)> stack;
    public MinStack() {
        stack = new Stack<(int val, int minSoFar)>();
    }
    
    public void Push(int val) {
        if(stack.Count == 0){
            stack.Push((val, val));
        }
        else{
            int currMin = Math.Min(val, stack.Peek().minSoFar);
            stack.Push((val, currMin));
        }
        
    }
    
    public void Pop() {
        if(stack.Count == 0)   
            throw new InvalidOperationException("Stack is Empty");
        stack.Pop();
    }
    
    public int Top() {
        if(stack.Count == 0)   
            throw new InvalidOperationException("Stack is Empty");
        return stack.Peek().val;
    }
    
    public int GetMin() {
        if(stack.Count == 0)   
            throw new InvalidOperationException("Stack is Empty");
        
        return stack.Peek().minSoFar;
    }
}
