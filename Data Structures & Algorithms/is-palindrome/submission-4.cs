public class Solution {
    public bool IsPalindrome(string s) {
        ReadOnlySpan<char> span = s.AsSpan();
        int len = span.Length; 
        int l = 0, r = len-1;

        while(l<r){
            while( l<r && !char.IsLetterOrDigit(span[l])) l++;
            while(l<r && !char.IsLetterOrDigit(span[r])) r--;

            if(char.ToLower(span[l]) != char.ToLower(span[r])){
                return false;
            }

            l++;
            r--;
        }
        return true;
    }
}
