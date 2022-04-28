public class Solution {
    public string RemoveDuplicates(string s, int k) {
         Stack<char> st = new Stack<char>();
         Stack<int> ct = new Stack<int>();
        
        int curr = 0;
        
        foreach(char c in s){
            if(st.Count == 0 || (st.Count > 0 && st.Peek() != c)){
                st.Push(c);
                ct.Push(1);
            }
            else{
                int count = ct.Pop();
                count++;
                if(count == k){
                    for(int i = 0; i < k-1; i++){
                        st.Pop();
                    }
                }
                else{
                    st.Push(c);
                    ct.Push(count);
                }
            }
        }
        
        List<char> list = new List<char>();
        while(st.Count > 0){
            list.Add(st.Pop());
            
        }
        
        char[] result = list.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}