public class MedianFinder {
    private PriorityQueue<int, int> lowers;
    private PriorityQueue<int, int> highers;

    public MedianFinder() {
        lowers = new PriorityQueue<int, int>();
        highers = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        if(lowers.Count == 0 || num <= lowers.Peek()){
            lowers.Enqueue(num, -num);
        }
        else{
            highers.Enqueue(num, num);
        }

        if(lowers.Count > highers.Count + 1){
            var moved = lowers.Dequeue();
            highers.Enqueue(moved, moved);
        }

        else if(highers.Count > lowers.Count){
            var moved = highers.Dequeue();
            lowers.Enqueue(moved, -moved);
        }
    }
    
    public double FindMedian() {
        if(lowers.Count > highers.Count){
            return lowers.Peek();
        }
        else{
            return (lowers.Peek() + highers.Peek())/2.0;
        }
    }
}
