public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] result = new int[temperatures.Length];

        var stack = new Stack<int>();

        for(int i = 0; i<temperatures.Length; i++){
            var temperature = temperatures[i];

            while(stack.Count > 0 && temperatures[stack.Peek()] < temperature){
                int idx = stack.Pop();

                int res = i - idx;

                result[idx] = res;
            }
            stack.Push(i);
        }

        return result;
    }
}
