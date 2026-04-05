public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();

        foreach(int weight in stones){
            pq.Enqueue(weight, -weight);
        }

        while(pq.Count > 1){
            int w1 = pq.Dequeue();
            int w2 = pq.Dequeue();

            if(w1 == w2) continue;

            int wLeft = Math.Abs(w1-w2);

            pq.Enqueue(wLeft, -wLeft);
        }

        return pq.Count > 0 ? pq.Dequeue(): 0;
    }
}
