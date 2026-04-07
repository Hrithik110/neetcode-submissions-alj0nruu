public class Solution {
    private List<List<int>> result;
    public List<List<int>> Subsets(int[] nums) {
        result = new List<List<int>>();

        BackTrack(nums, 0, new List<int>());

        return result;
    }

    public void BackTrack(int[] nums, int idx, List<int> res){
        result.Add(new List<int>(res));

        for(int i = idx; i<nums.Length; i++){
            res.Add(nums[i]);

            BackTrack(nums, i+1, res);

            res.RemoveAt(res.Count - 1);
        }
    }
}
