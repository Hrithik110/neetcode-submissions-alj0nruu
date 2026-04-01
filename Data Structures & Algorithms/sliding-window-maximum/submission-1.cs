public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0) return new int[0];
        int n = nums.Length;
        LinkedList<int> dequeue = new LinkedList<int>();
        
        int[] ans = new int[n-k+1];

        for(int i = 0; i<n; i++){
            if(dequeue.Count > 0 && dequeue.First.Value <= i-k){
                dequeue.RemoveFirst();
            }

            while(dequeue.Count > 0 && nums[dequeue.Last.Value] < nums[i]){
                dequeue.RemoveLast();
                //[]
            }
            //[0] //[1]
            dequeue.AddLast(i);

            if(i >= k-1){
                ans[i-k+1] = nums[dequeue.First.Value];
            }
        }

        return ans;
    }
}
