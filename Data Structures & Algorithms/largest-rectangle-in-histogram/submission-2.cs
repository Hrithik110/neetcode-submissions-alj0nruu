public class Solution {
    public int LargestRectangleArea(int[] heights) {
        
        var stack = new Stack<int>();
        int maxArea = 0;
        for(int i = 0; i<=heights.Length; i++){
            int currH = i == heights.Length ? 0 : heights[i];
            while(stack.Count > 0 && currH <= heights[stack.Peek()]){
                int h = heights[stack.Pop()];
                int r = i;
                int l = stack.Count == 0 ? -1 : stack.Peek();
                int width = r - l - 1;

                int area = h * width;

                maxArea = Math.Max(area, maxArea);
            }

            stack.Push(i);
        }
        return maxArea;
    }
}
