public class Solution {  
    public List<string> result;
    public List<string> GenerateParenthesis(int n) {
        result = new List<string>();

        BackTrack(n, 0, 0, new StringBuilder());

        return result;
    }

    public void BackTrack(int n, int open, int close, StringBuilder curr){
        if(curr.Length == 2*n){
            result.Add(curr.ToString());
            return;
        }

        if(open<n){
            curr.Append('(');

            BackTrack(n, open+1, close, curr);

            curr.Remove(curr.Length-1,1);
        }

        if(close<open){
            curr.Append(')');

            BackTrack(n, open, close+1, curr);
            curr.Remove(curr.Length-1,1);

        }

    }
}
