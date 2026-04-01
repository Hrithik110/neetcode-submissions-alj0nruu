public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // Dictionary<int, int> indexMap = new Dictionary<int, int>();

        // for(int i = 0; i<nums.Length; i++){
        //     indexMap[nums[i]] = i;
        // }

        int[] originalNums = new int[nums.Length];

        for(int i = 0; i<nums.Length; i++){
            originalNums[i] = nums[i];
        }
        Array.Sort(nums);

        int l = 0, r = nums.Length - 1;

        while(l<r){
            int sum = nums[l] + nums[r];

            if(sum==target){
                Console.WriteLine(l);
                Console.WriteLine(r);
                    
                int low = Array.IndexOf(originalNums, nums[l]);
                int high = nums[l] == nums[r] ? Array.IndexOf(originalNums, nums[r], low+1) : Array.IndexOf(originalNums, nums[r]);

                if(low<high){
                return [low, high];

                }
                return [high, low];

            }
            else if(sum < target){
                l++;
            }
            else r--;
        }

        return [];
    }
}
