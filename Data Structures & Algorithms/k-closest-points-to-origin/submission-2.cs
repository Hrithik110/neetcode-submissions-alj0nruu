public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], double>();
        int[][] ans = new int[k][]; 

        foreach(int[] point in points){
            int x1 = point[0];
            int y1 = point[1];

            double distance = Math.Sqrt(Math.Pow((x1), 2) + Math.Pow(y1, 2));
            pq.Enqueue(point, distance);
        }




        for(int i = 0; i<k; i++){
            ans[i] = pq.Dequeue();
        }

        return ans;
    }
}
