public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> st = new Stack<char>();
        StringBuilder sb = new StringBuilder();
        foreach(char c in s){
            if(st.Count > 0 && st.Peek() == c){
                st.Pop();
            }
            else{
                st.Push(c);
            }
        }
        
        while(st.Count > 0){
            sb.Append(st.Pop().ToString());
        }
        
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}