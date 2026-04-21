public class Solution {
    public bool IsValid(string s) {
        var bracketMap = new Dictionary<char, char>{
            {'}', '{'},
            {')', '('},
            {']', '['}
        };

        var paranthesisStack = new Stack<char>();


        for(int i = 0; i<s.Length; i++){
            if(paranthesisStack.Count > 0 && bracketMap.ContainsKey(s[i]) &&
            bracketMap[s[i]] == paranthesisStack.Peek()){
                paranthesisStack.Pop();
            }
            else{
                paranthesisStack.Push(s[i]);
            }
        }

        return paranthesisStack.Count == 0;
    }
}
