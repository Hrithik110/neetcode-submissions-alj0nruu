public class Solution {
    public List<List<int>> result;
    public List<List<int>> SubsetsWithDup(int[] nums) {
        result = new List<List<int>>();
        // result.Add(new List<int>());
        Array.Sort(nums);
        BackTrack(nums, 0, new List<int>());

        return result;
    }

    public void BackTrack(int[] nums, int start, List<int> curr){

        result.Add(new List<int>(curr));
        for(int i = start; i<nums.Length; i++){
            if(i>start && nums[i] == nums[i-1]) continue;
            curr.Add(nums[i]);

            BackTrack(nums, i+1, curr);

            curr.RemoveAt(curr.Count - 1);

        }
    }
}
