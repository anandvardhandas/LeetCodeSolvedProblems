public class Solution {
    public bool BackspaceCompare(string s, string t) {
        Stack<char> st1 = new Stack<char>();
        Stack<char> st2 = new Stack<char>();
        
        foreach(char c in s){
            if(c == '#'){
                if(st1.Count > 0){
                    st1.Pop();
                }
            }
            else{
                st1.Push(c);
            }
        }
        
        foreach(char c in t){
            if(c == '#'){
                if(st2.Count > 0){
                    st2.Pop();
                }
            }
            else{
                st2.Push(c);
            }
        }
        
        while(st1.Count > 0 && st2.Count > 0 && st1.Peek() == st2.Peek()){
            st1.Pop();
            st2.Pop();
        }
        
        return st1.Count == 0 && st2.Count == 0;
    }
}