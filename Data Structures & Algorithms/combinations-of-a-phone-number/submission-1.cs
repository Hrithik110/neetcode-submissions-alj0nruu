public class Solution {
     public List<string> result;
    public List<string> LetterCombinations(string digits) {
        var dict = new Dictionary<char, char[]>{
            {'2', new char[]{'a', 'b', 'c'}},
            {'3', new char[]{'d', 'e', 'f'}},
            {'4', new char[]{'g', 'h', 'i'}},
            {'5', new char[]{'j', 'k', 'l'}},
            {'6', new char[]{'m', 'n', 'o'}},
            {'7', new char[]{'p', 'q', 'r', 's'}},
            {'8', new char[]{'t', 'u', 'v'}},
            {'9', new char[]{'w', 'x', 'y', 'z'}}
        };

        result = new List<string>();
        if(digits.Length == 0) return result;


        BackTrack(digits, 0, dict, new StringBuilder());

        return result;

    }

    public void BackTrack(string digits, int start, Dictionary<char, char[]> dict, StringBuilder curr){
        if(start == digits.Length){
            result.Add(curr.ToString());
            return;
        }     
            char ch = digits[start];
            char[] chars = dict[ch];
            for(int j = 0; j<chars.Length; j++){
                curr.Append(chars[j]);

                BackTrack(digits, start+1, dict, curr);

                curr.Remove(curr.Length - 1, 1);
            }
        
    }
}
