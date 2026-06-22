public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1;

        int lMax = 0, rMax = 0;

        int area = 0;

        while(l<r){
            if(height[l]<height[r]){
                if(height[l]>lMax){
                    lMax = height[l];
                }
                else{
                    area+= lMax - height[l];
                }
                l++;
            }
            else{
                if(height[r]>rMax){
                    rMax = height[r];
                }
                else{
                    area += rMax - height[r];
                }
                r--;
            }
        }
        return area;
    }
}
