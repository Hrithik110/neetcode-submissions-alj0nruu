public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();

        foreach(int num in nums){
            pq.Enqueue(num, -num);
        }

        for(int i = 0; i<k-1; i++){
            pq.Dequeue();
        }

        return pq.Count>0 ? pq.Dequeue(): 0;
    }
}
