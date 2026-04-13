public class Solution {
    public List<List<string>> result;
    public List<List<string>> Partition(string s) {
        result = new List<List<string>>();

        BackTrack(s, 0, new List<string>());

        return result;
    }

    public void BackTrack(string s, int start, List<string> curr){
       if(start == s.Length){
            result.Add(new List<string>(curr));
            return;
       }

       for(int i = start; i<s.Length; i++){
            if(IsPalindrome(s, start, i)){
                curr.Add(s.Substring(start, i-start+1));

                BackTrack(s, i+1, curr);

                curr.RemoveAt(curr.Count-1);
            }
       }

    }

    public bool IsPalindrome(string s, int l, int r){

        while(l<r){
            char s1 = s[l];
            char s2 = s[r];

            if(s1 != s2) return false;

            l++;
            r--;
        }

        return true;
    }
}
