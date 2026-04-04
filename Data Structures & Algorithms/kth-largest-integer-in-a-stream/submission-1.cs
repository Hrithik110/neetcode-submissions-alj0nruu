public class KthLargest {
    public int K;
    public List<int> Nums;

    public KthLargest(int k, int[] nums) {
        K = k;
        Nums = nums.OrderByDescending(x => x).ToList();
    }
    
    public int Add(int val) {
        Nums.Add(val);
        var sorted = Nums.OrderByDescending(x => x).ToList();
        return sorted[K-1];

    }
}
