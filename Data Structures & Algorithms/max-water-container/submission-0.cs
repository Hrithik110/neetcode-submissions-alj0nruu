public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0, r = heights.Length - 1;

        int maxVol = 0;

        while(l<r){

            int height = Math.Min(heights[l], heights[r]);

            int width = r - l;

            int vol = height * width;

            maxVol = Math.Max(vol, maxVol);
            if(height == heights[l]){
                l++;
            }
            else{
                r--;
            }
        }

        return maxVol;
    }
}
