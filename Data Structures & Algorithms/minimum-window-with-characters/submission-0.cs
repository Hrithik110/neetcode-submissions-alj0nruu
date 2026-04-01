public class Solution {
    public string MinWindow(string s, string t) {
        var need = new Dictionary<char, int>();

        foreach(char c in t){
            need[c] = need.GetValueOrDefault(c, 0) + 1;
        }

        var window = new Dictionary<char, int>();

        int required = need.Count;
        int formed = 0;

        int minLen = int.MaxValue;

        int start = 0;
        int l = 0, r = 0;

        while(r<s.Length){
            char ch = s[r];

            window[ch] = window.GetValueOrDefault(ch, 0) + 1;

            if(need.ContainsKey(ch) && need[ch] == window[ch]){
                formed++;
            }

            while(l<=r && formed == required){
                if(r-l+1 < minLen){
                    minLen = r-l+1;
                    start = l;
                }

                char leftChar = s[l];
                window[leftChar]--;

                if(need.ContainsKey(leftChar) && need[leftChar] > window[leftChar]){
                    formed--;
                }

                l++;


            }

            r++;
        }

        return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
    }
}
