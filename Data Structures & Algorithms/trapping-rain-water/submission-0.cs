public class Solution {
    public int Trap(int[] height) {
        int[] maxL = new int[height.Length];
        int[] maxR = new int[height.Length];

        int ans = 0;
        maxL[0] = 0;
        maxR[height.Length-1] = 0;
        int max = int.MinValue;
        for(int i = 1; i<height.Length; i++){
            max = Math.Max(height[i-1], max);

            maxL[i] = max;
        }
         max = int.MinValue;
        for(int i = height.Length-2; i>=0; i--){
            max = Math.Max(height[i+1], max);
            maxR[i] = max;
        }

        for(int i = 0; i<height.Length; i++){
            int stored = Math.Min(maxL[i], maxR[i]) - height[i];

            if(stored > 0){
                ans += stored;
            }
        }

        return ans;
    }
}
