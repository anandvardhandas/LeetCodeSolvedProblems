public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] result = new int[len];
        result[len-1] = 0;
        
        Stack<int> st = new Stack<int>();
        st.Push(len-1);
        
        for(int i = len-2; i >= 0; i--){
            while(st.Count > 0 && temperatures[i] >= temperatures[st.Peek()]){
                st.Pop();
            }
            
            if(st.Count == 0){
                result[i] = 0;
            }
            else{
                int diff = st.Peek()-i;
                result[i] = diff;
            }
            
            st.Push(i);
        }
        
        return result;
    }
}