public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        //merge sorted arrays

        int l = 0, r = 0;

        int[] mergedArr = new int[nums1.Length + nums2.Length];
        int i = 0;
        double median = 0;
        while(l<nums1.Length && r<nums2.Length){
            int numL = nums1[l];
            int numR = nums2[r];
            if(numL<=numR){
                mergedArr[i] = numL;
                l++;
            }
            else{
                mergedArr[i] = numR;
                r++;
            }
            i++;
        }

        while(l<nums1.Length){
            int numL = nums1[l];
            mergedArr[i] = numL;
            l++;
            i++;
        }
        while(r<nums2.Length){
            int numR = nums2[r];
            mergedArr[i] = numR;
            r++;
            i++;
        }

        int len = mergedArr.Length;

        if(len%2 == 0){
            int idx = len/2 - 1;
            Console.WriteLine(idx);
            median = (double)(mergedArr[idx] + mergedArr[idx+1])/2;
        }
        else{
            int idx = (len + 1)/2 - 1;
            median = mergedArr[idx];
        }

        return median;
    }
}
