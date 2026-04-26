public class Solution {
    public List<List<int>> result;
    public List<List<int>> Subsets(int[] nums) {
        result = new List<List<int>>();

        BackTrack(nums, 0, new List<int>());

        return result;
    }

    public void BackTrack(int [] nums, int i, List<int> curr){

       
        result.Add(new List<int>(curr));

        for(int idx = i; idx<nums.Length; idx++){

            curr.Add(nums[idx]);

            BackTrack(nums, idx+1, curr);

            curr.RemoveAt(curr.Count - 1);
        }
    }
}
