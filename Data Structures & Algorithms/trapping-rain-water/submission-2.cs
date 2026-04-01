public class Solution {
    public int Trap(int[] height) {

        int ans = 0;

        for(int i = 0; i<height.Length; i++){ 

            int l = 0, r = height.Length - 1;
            
            int leftMax = 0, rightMax = 0;

            while(l<i || r>i){
                if(l<i){
                    leftMax = Math.Max(height[l], leftMax);
                }

                if(r>i){
                    rightMax = Math.Max(height[r], rightMax);
                }

                r--;
                l++;
                
            }

            int stored = Math.Min(rightMax, leftMax) - height[i];

            if(stored>0){
                ans += stored;
            }

        }
       
        return ans;
    }
}
