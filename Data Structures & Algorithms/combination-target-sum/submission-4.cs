public class Solution {
    public List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        result = new List<List<int>>();
        Array.Sort(nums);
        BackTrack(nums, target, 0, new List<int>());

        return result;
    }

    public void BackTrack(int[] nums, int target, int start, List<int> curr){
        if(target == 0){
            result.Add(new List<int>(curr));
            return;
        }
        // if(target<0 || start>=nums.Length) return;

        for(int i = start; i<nums.Length; i++){
            if(nums[i]>target){
                break;
            }
            curr.Add(nums[i]);

            BackTrack(nums, target - nums[i], i, curr);

            curr.RemoveAt(curr.Count - 1);
        }
    }
}
