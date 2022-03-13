public class Solution {
    public bool IsValid(string s) {
        int len = s.Length;
        Stack<char> st = new Stack<char>();
        
        for(int i = 0; i < len; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                st.Push(s[i]);
            }
            else{
                if(st.Count == 0)
                    return false;
                
                char ch = st.Pop();
                if((ch == '(' && s[i] != ')') || (ch == '{' && s[i] != '}') || (ch == '[' && s[i] != ']'))
                    return false;
            }
        }
        
        return st.Count == 0;
    }
}