public class MinStack {
    public Stack<(int val, int minSoFar)> stack;
    // int min = int.MaxValue;
    public MinStack() {
        stack = new Stack<(int val, int minSoFar)>();
    }
    
    public void Push(int val) {
        if(stack.Count == 0){
            stack.Push((val, val));
        }
        else{
            int currMin = stack.Peek().minSoFar;

            stack.Push((val, Math.Min(currMin, val)));
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minSoFar;
    }
}
