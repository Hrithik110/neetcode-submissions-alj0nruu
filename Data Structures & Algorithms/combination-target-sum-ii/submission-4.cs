public class Solution {
    public List<List<int>> result;
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        result = new List<List<int>>();
        Array.Sort(candidates);
        BackTrack(candidates, 0, 0, new List<int>(), target);

        return result;
    }

    public void BackTrack(int[] c, int total, int start, List<int> res, int target){
        if(total == target){
            result.Add(new List<int>(res));

            return;
        }

        for(int i = start; i<c.Length; i++){
            if(i>start && c[i] == c[i-1]) continue;

            if(c[i]>target-total) break;

            res.Add(c[i]);

            BackTrack(c, total+c[i], i+1, res, target);

            res.RemoveAt(res.Count-1);
        }
    }
}
