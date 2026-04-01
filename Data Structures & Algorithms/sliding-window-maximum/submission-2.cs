public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(nums == null || nums.Length == 0) return new int[0];
        LinkedList<int> deque = new LinkedList<int>();

        int[] ans = new int[nums.Length - k + 1];

        for(int i = 0; i<nums.Length; i++){
            //if first value is not in the current window remove it
            if(deque.Count>0 && deque.First.Value <= i-k){
                deque.RemoveFirst();
            }

            //remove if last value is lesser than current
            while(deque.Count>0 && nums[deque.Last.Value] < nums[i]){
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if(i>=k-1){
                ans[i-k+1] = nums[deque.First.Value];
            }
        }

        return ans;
    }
}
