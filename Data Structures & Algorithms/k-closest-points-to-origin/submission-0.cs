public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], double>();
        int[][] ans = new int[k][]; 

        foreach(int[] point in points){
            int x1 = point[0];
            int y1 = point[1];

            //x1 - 0, y1 - 2, distance = 2, pq -> [[0,2], 2]
            //x1 - 2, y1 - 2, dis

            double distance = Math.Sqrt(Math.Pow((x1), 2) + Math.Pow(y1, 2));
            pq.Enqueue(point, -distance);
        }



        for(int i = 0; i<points.Length-k; i++){
            pq.Dequeue();


        }


        for(int i = 0; i<ans.Length; i++){
            ans[i] = pq.Dequeue();
        }

        return ans;
    }
}
