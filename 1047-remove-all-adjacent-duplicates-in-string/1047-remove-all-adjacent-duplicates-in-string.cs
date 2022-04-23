public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> st = new Stack<char>();
        
        foreach(char c in s){
            if(st.Count > 0 && st.Peek() == c){
               while(st.Count > 0 && st.Peek() == c){
                    st.Pop();
               } 
            }
            else{
                st.Push(c);
            }
        }
        
        StringBuilder sb = new StringBuilder();
        while(st.Count > 0){
            sb.Append(st.Pop());
        }
        
        string result = sb.ToString();
        
        char[] res = result.ToCharArray();
        Array.Reverse(res);
        
        return new string(res);
    }
}