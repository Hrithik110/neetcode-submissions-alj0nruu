public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<string> stack = new Stack<string>();
        int r = 0;
        while(r<tokens.Length){
            if(stack.Count == 0 || !IsOperator(tokens[r])){
                stack.Push(tokens[r]);
            }
            else{
                string num2 = stack.Pop();
                string num1 = stack.Pop();

                int res = Evaluate(num1, num2, tokens[r]);

                stack.Push(res.ToString());

            }
            r++;
        }

        return int.Parse(stack.Pop());

    }

    public bool IsOperator(string val){
        return val == "+" || val == "-" || val == "*" || val == "/";
    }
    public int Evaluate(string num1, string num2, string operators){

        switch(operators){
            case "+":
                return int.Parse(num1) + int.Parse(num2);
            case "-":
                return int.Parse(num1) - int.Parse(num2);
            case "*":
                return int.Parse(num1)*int.Parse(num2);
            case "/":
                return int.Parse(num1)/int.Parse(num2);
            default:
                return 0;
        }
    }
}
