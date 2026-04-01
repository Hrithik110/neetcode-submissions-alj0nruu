public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();
        foreach(string str in tokens){
            if(stack.Count == 0 || !CheckIsOperand(str)){
                stack.Push(str);
            }
            else{
                string b = stack.Pop();
                string a = stack.Pop();

                int res = PerformArithmeticOperation(str, a, b);

                stack.Push(res.ToString());
            }
        }

        return int.Parse(stack.Pop());
    }

    public static bool CheckIsOperand(string s){

        return s == "+" || s == "-" || s == "*" || s == "/";
    }

    public static int PerformArithmeticOperation(string operand, string a, string b){
        switch(operand){
            case "+":
                return int.Parse(a) + int.Parse(b);
            case "*":
                return int.Parse(a) * int.Parse(b);
            case "-":
                return int.Parse(a) - int.Parse(b);
            case "/":
                return int.Parse(a) / int.Parse(b);
            default:
                throw new InvalidOperationException("Not valid operand");
        }
    }
}
