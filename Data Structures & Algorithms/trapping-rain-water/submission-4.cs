public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length-1;

        int leftMax = 0, rightMax = 0;

        int area = 0;

        while(l<r){
            if(height[l]<height[r]){
                if(height[l]>=leftMax){
                    leftMax = height[l];
                }
                else{
                    area += leftMax - height[l];
                }
                l++;
            }
            else{
                if(height[r]>=rightMax){
                    rightMax = height[r];
                }
                else{
                    area += rightMax-height[r];
                }
                r--;
            }
        }
        return area;
    }
}
