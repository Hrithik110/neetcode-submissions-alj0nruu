public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length-1;

        while(l<r){
            while(!char.IsLetterOrDigit(s[l]) && l<r) l++;
            while(!char.IsLetterOrDigit(s[r]) && l<r) r--;

            if(char.ToUpper(s[l])!= char.ToUpper(s[r])){
                return false;
            }

            l++;
            r--;

        }

        return true;
    }
}
