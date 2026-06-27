public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] res = new int[n - k + 1];

        var dq = new LinkedList<int>();

        int l = 0, r = 0;

        int resIdx = 0;

        while(r<n){
            
            // remove last as it is lower value and cannot be max
            while(dq.Count > 0 && nums[dq.Last.Value] <= nums[r])
                dq.RemoveLast();

            //add at last
            dq.AddLast(r);
            
            //remove first as it is not in window
            if(dq.First.Value < l){
                dq.RemoveFirst();
            }

            if(r - l + 1 == k){
                res[resIdx++] = nums[dq.First.Value];

                l++;
            }
            r++;
        }

        return res;
    }
}
