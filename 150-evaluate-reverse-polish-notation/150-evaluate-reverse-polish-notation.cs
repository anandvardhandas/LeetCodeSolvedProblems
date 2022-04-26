public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        
        foreach(string token in tokens){
            if(token == "+" || token == "-" || token == "*" || token == "/"){
                int num1 = st.Pop();
                int num2 = st.Pop();
                int result = 0;
                if(token == "+"){
                    result = num2+num1;
                }
                else if(token == "-"){
                    result = num2-num1;
                }
                else if(token == "*"){
                    result = num2*num1;
                }
                else{
                    result = num2/num1;
                }
                
                st.Push(result);
            }
            else{
                st.Push(int.Parse(token));
            }
        }
        
        int ans = st.Pop();
        return ans;
    }
}