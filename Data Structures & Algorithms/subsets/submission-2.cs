public class Solution {
    public List<List<int>> result;
    public List<List<int>> Subsets(int[] nums) {
        result = new List<List<int>>();

        BackTrack(nums, 0, new List<int>());

        return result;
    }

    public void BackTrack(int[] nums, int start, List<int> subset){
        result.Add(new List<int>(subset));

        for(int i = start; i<nums.Length; i++){

            subset.Add(nums[i]);

            BackTrack(nums, i+1, subset);

            subset.RemoveAt(subset.Count - 1);

        }
    }
}
