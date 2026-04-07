public class MedianFinder {
    private PriorityQueue<int, int> pq;
    public MedianFinder() {
        pq = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        pq.Enqueue(num, num);
    }
    
    public double FindMedian() {
        List<int> nums = new List<int>();
        var tempPq = new PriorityQueue<int, int>();
        while(pq.Count>0){
            int num = pq.Dequeue();

            nums.Add(num);

            tempPq.Enqueue(num, num);
        }

        while(tempPq.Count>0){
            var num = tempPq.Dequeue();
            pq.Enqueue(num, num);
        }

        int len = nums.Count;


        if(len%2 == 0){
            int mid = len/2;

            double median = (nums[mid-1] + nums[mid])/2.0;

            return median;
        }
        else{
            int mid = len/2;

            double median = nums[mid];

            return median;
        }
    }
}
