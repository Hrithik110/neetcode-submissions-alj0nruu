public class KthLargest {
    public int K;
    public PriorityQueue<int, int> pq;

    public KthLargest(int k, int[] nums) {
      K = k;

      pq = new PriorityQueue<int, int>();

      foreach(int num in nums){
        Add(num);
      }
    }
    
    public int Add(int val) {
       pq.Enqueue(val, val);
       

       while(pq.Count>K){
        pq.Dequeue();
       }

        return pq.Peek();
    }
}
