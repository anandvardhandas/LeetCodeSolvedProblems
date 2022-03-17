public class Solution {
    public int ScoreOfParentheses(string s) {
        Stack<int> st = new Stack<int>();
        
        int total = 0;
        
        foreach(char c in s){
            if(c == '(')
                st.Push(-1);
            else{
                if(st.Peek() == -1){
                    st.Pop();
                    st.Push(1);
                }
                else{
                    int sum = 0;
                    while(st.Peek() != -1){
                        sum += st.Pop();
                    }
                    
                    st.Pop();
                    st.Push(2*sum);
                }
            }
        }
        
        while(st.Count > 0){
            total += st.Pop();
        }
        
        return total;
    }
}