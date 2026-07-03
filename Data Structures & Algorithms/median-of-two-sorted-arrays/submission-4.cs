public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length){
            return FindMedianSortedArrays(nums2, nums1);
        }

        int n = nums1.Length, m = nums2.Length;
        int totalLen = n + m;

        int left = 0, right = n;

        while(left <= right){
            int mid1 = left + (right - left)/2;

            int mid2 = (totalLen + 1)/2 - mid1;

           int l1 = (mid1 == 0) ? int.MinValue : nums1[mid1 - 1];
int r1 = (mid1 == n) ? int.MaxValue : nums1[mid1];
int l2 = (mid2 == 0) ? int.MinValue : nums2[mid2 - 1];
int r2 = (mid2 == m) ? int.MaxValue : nums2[mid2];



            if(l1 <= r2 && l2<=r1){
                if(totalLen % 2 == 0){
                    return (Math.Max(l1, l2) + Math.Min(r1, r2))/2.0;
                }
                else{
                    return Math.Max(l1, l2);
                }
            }
            else if(l1 > r2){
                right = mid1 - 1;
            }
            else{
                left = mid1 + 1;
            }

        }

        return -1;
    }
}
