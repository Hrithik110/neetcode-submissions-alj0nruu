public class Solution {
    public List<List<int>> result;
    public List<List<int>> Permute(int[] nums) {
        result = new List<List<int>>();
        bool[] used = new bool[nums.Length];
        BackTrack(nums, new List<int>(), used);

        return result;
    }

    public void BackTrack(int[] nums, List<int> res, bool[] used){
        if(res.Count == nums.Length){
            result.Add(new List<int>(res));
            return;
        }

        for(int i = 0; i<nums.Length; i++){
            if(used[i]) continue;

            res.Add(nums[i]);

            used[i] = true;

            BackTrack(nums, res, used);

            res.RemoveAt(res.Count-1);

            used[i] = false;
        }
    }
}
