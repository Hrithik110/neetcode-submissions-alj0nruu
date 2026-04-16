public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length > s.Length) return "";

        var map = new Dictionary<char, int>();
        var map2 = new Dictionary<char, int>();
        foreach(char ch in t){
            map[ch] = map.GetValueOrDefault(ch, 0) + 1;
        }

        int required = map.Count;

        int formed = 0;

        int l = 0, r = 0;

        int start = 0;
        int minLen = int.MaxValue;
        while(r<s.Length){
            char c = s[r]; //a
            map2[c] = map2.GetValueOrDefault(c, 0) + 1; // a-> 1
            if(map.ContainsKey(c) && map2[c] == map[c]){
                formed++;
            }

            while(formed == required && l<=r){
                
                if(r-l+1 <= minLen){
            
                    minLen = r-l+1;
                    start = l;
                }
                char cL = s[l];
                map2[cL]--;

                if(map.ContainsKey(cL) && map[cL] > map2[cL]){
                    formed--;
                }

                l++;

                
            }
            r++;
        }
        return minLen == int.MaxValue ? "" : s.Substring(start, minLen);

    }
}
