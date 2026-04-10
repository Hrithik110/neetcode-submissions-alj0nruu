public class Solution {
    public List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = new List<List<int>>();
        Array.Sort(nums);
        BackTrack(nums, target, 0, new List<int>());

        return result;
    }

    public void BackTrack(int[] nums, int target, int start, List<int> res){
        //base case
        if(target==0){
            result.Add(new List<int>(res));
            return;
        }
        for(int i = start; i<nums.Length; i++){
            if(nums[i] > target) {
                break;
            }

            //Add curr
            res.Add(nums[i]);

            BackTrack(nums, target-nums[i], i, res);

            //BackTrack
            res.RemoveAt(res.Count-1);

            // BackTrack(nums, target, i+1, res);

        }
    }
}
