public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length > s.Length) return "";

    
        int minWindow = int.MaxValue;
        var dict = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();
        foreach(char ch in t){
            dict[ch] = dict.GetValueOrDefault(ch, 0) + 1;
        }
        int formed = 0;
        int required = dict.Count;
        int start = 0;


        int l = 0, r = 0;

        while(r<s.Length){
            char ch = s[r];
            dict2[ch] = dict2.GetValueOrDefault(ch, 0) + 1;
            if(dict.ContainsKey(ch) && dict2[ch] == dict[ch]){
                formed++;
            }

            while(formed == required && l<=r){
                if(r-l + 1 <= minWindow){
                    minWindow = r-l+1;
                    start = l;
                }

                char cL = s[l];

                dict2[cL]--;
                if(dict.ContainsKey(cL) && dict[cL] > dict2[cL]){
                    formed--;
                }
                l++;
            }
            r++;
        }

    return minWindow == int.MaxValue ? "" : s.Substring(start, minWindow);
    }
}
