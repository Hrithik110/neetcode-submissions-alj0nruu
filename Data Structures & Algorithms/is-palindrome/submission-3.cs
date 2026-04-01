public class Solution {
    public bool IsPalindrome(string s) {
        int len = s.Length; 
        int l = 0, r = len-1;

        while(l<r){
            while( l<r && !char.IsLetterOrDigit(s[l])) l++;
            while(l<r && !char.IsLetterOrDigit(s[r])) r--;

            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }

            l++;
            r--;
        }
        return true;
    }
}
