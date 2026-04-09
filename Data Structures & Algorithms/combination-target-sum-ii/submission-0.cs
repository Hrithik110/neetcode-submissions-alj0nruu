public class Solution {
    private List<List<int>> result;
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        result = new List<List<int>>();
        Array.Sort(candidates);
        BackTrack(candidates, target, new List<int>(), 0);

        return result;
    }
    public void BackTrack(int[] candidates, int target, List<int> res, int idx){
        // if(target == 0){
        //     result.Add(new List<int>(res));

        //     return;
        // }
        // if(idx >= candidates.Length || target<0) return;
        // while(candidates[idx] > target){
        //     idx++;
        // }
        // res.Add(candidates[idx]);
        // //[1], [1, 2], [1, 2, 3, 4]
        // //target -> 6, 4, 1, -3
        // // idx -> 0, 1, 2, 3
        // BackTrack(candidates, target - candidates[idx], res, idx+1);

        // res.RemoveAt(res.Count - 1);

        // BackTrack(candidates, target, res, idx+1);

         if(target == 0){
            result.Add(new List<int>(res));
            return;
        }

        if(idx == candidates.Length || target < 0) return;

        res.Add(candidates[idx]);

        BackTrack(candidates, target - candidates[idx],res , idx+1);

        res.RemoveAt(res.Count - 1);

        while(idx+1 <candidates.Length && candidates[idx] == candidates[idx+1]) idx++;

        BackTrack(candidates, target, res, idx + 1);


    }
}
