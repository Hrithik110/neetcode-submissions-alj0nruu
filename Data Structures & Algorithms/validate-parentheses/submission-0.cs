public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> bracketsMap = new Dictionary<char, char>();

        bracketsMap.Add('}', '{');
        bracketsMap.Add(')', '(');
        bracketsMap.Add(']', '[');

        Stack<char> paranthesisStack = new Stack<char>();

        for(int i = 0; i<s.Length; i++){
            if(paranthesisStack.Count > 0 && bracketsMap.ContainsKey(s[i]) && paranthesisStack.Peek() == bracketsMap[s[i]]){
                paranthesisStack.Pop();
            }
            else{
                paranthesisStack.Push(s[i]);
            }
        }

        return paranthesisStack.Count == 0;
    }
}
