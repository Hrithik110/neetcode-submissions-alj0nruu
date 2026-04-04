public class KthLargest {
    public int K;
    public List<int> Nums;
    public KthLargest(int k, int[] nums) {
        K = k;
        Array.Sort(nums, (a,b)=> b.CompareTo(a));
        Nums = new List<int>();
        for(int i = 0; i<nums.Length; i++){
            Nums.Add(nums[i]);
        }

    }
    
    public int Add(int val) {
        
        Nums.Add(val);

        var nums = Nums.OrderByDescending(x=> x).ToList();

        return nums[K-1];

    }
}
