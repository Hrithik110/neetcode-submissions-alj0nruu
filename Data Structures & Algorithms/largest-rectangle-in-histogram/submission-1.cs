public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();

        int maxArea = 0;

        for(int i = 0; i<=heights.Length; i++){
            int currH = i == heights.Length ? 0 : heights[i];

            while(stack.Count>0 && currH<=heights[stack.Peek()]){
                int h = heights[stack.Pop()];

                int r = i;

                int l = stack.Count == 0 ? -1 : stack.Peek();

                int w = r - l - 1;

                int a = h*w;

                maxArea = Math.Max(a, maxArea);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}
