public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> heightStack = new Stack<int>();
        int maxArea = 0;
        for(int i = 0; i<=heights.Length; i++){
           int currHeight = i == heights.Length ? 0 : heights[i];
            //[7, 3, 1] i = 3 currH = 0
           while(heightStack.Count>0 && heights[heightStack.Peek()]>=currHeight){
            int height = heights[heightStack.Pop()];
            //h = 7
            int right = i;
            //r = 3
            int left = heightStack.Count == 0 ? -1 : heightStack.Peek();
            //l = 1
            int width = right - left - 1;
            // w = 1
            int area = height * width;
            // 7
            maxArea = Math.Max(maxArea, area);
           }

           heightStack.Push(i);
        }

        return maxArea;
    }
}
