public class Solution {
    private List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = new List<List<int>>();
        
        BackTrack(nums, target, 0, new List<int>());
        return result;
    }

    public void BackTrack(int[] nums, int target, int idx, List<int> res){
        if(target == 0){
            result.Add(new List<int>(res));
            return;
        }

        if(idx >= nums.Length || target < 0) return;

        res.Add(nums[idx]);

        BackTrack(nums, target - nums[idx], idx, res);

        res.RemoveAt(res.Count - 1);

        BackTrack(nums, target, idx + 1, res);


    }

}
