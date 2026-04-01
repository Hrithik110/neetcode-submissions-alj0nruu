public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        Stack<int> tempStack = new Stack<int>();
        int[] res = new int[temperatures.Length];

        for(int i = 0; i<temperatures.Length; i++){
            while(tempStack.Count>0 && temperatures[tempStack.Peek()] < temperatures[i]){
                int idx = tempStack.Pop();

                int numOfDays = i-idx;

                res[idx] = numOfDays;
            }

            tempStack.Push(i);
            
        }

        return res;
    }
}
