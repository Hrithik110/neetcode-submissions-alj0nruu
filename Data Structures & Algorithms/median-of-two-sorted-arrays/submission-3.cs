public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalLen = nums1.Length + nums2.Length;
        int mid1 = (totalLen - 1)/2;
        int mid2 = totalLen/2;

        int i = 0, j = 0, count = 0;
        int curr = 0, prev = 0;

        while(count<=mid2){
            prev = curr;

            if(i<nums1.Length && (j>=nums2.Length || nums2[j]>=nums1[i])){
                curr = nums1[i++];
            }
            else{
                curr = nums2[j++];
            }
            count++;

        }

        if(totalLen%2 == 0){
            return (curr + prev)/2.0;
        }
        else{
            return curr;
        }
    }
}
