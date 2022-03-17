public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        Stack<int> st = new Stack<int>();
        
        int len = pushed.Length;
        int l = 0, r = 0;
        
        while(l < len || r < len){
            if(l < len && st.Count == 0){
                st.Push(pushed[l]);
                l++;
            }
            else{
                int pop = -1;
                if(r < len)
                    pop = popped[r];
                if(st.Peek() == pop){
                    st.Pop();
                    r++;
                }
                else{
                    if(l < len){
                        st.Push(pushed[l]);
                        l++;
                    }
                    else{
                        break;
                    }
                }
            }
        }
        
        if(st.Count > 0 || l < len || r < len)
            return false;
        
        return true;
    }
}