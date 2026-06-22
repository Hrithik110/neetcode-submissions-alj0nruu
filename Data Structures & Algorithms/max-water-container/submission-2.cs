public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length-1;

        int maxArea = 0;

        while(l<r){
            int height = Math.Min(heights[l], heights[r]);

            int width = r-l;

            int area = height * width;

            maxArea = Math.Max(area, maxArea);

            if(heights[l]>heights[r]){
                r--;
            }
            else{
                l++;
            }
        }

        return maxArea;
    }
}
