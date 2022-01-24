public class Solution {
    public int[] FindBuildings(int[] heights) {
        int len = heights.Length;
        List<int> result = new List<int>();
        result.Add(len-1);
        Stack<int> st = new Stack<int>();
        st.Push(heights[len-1]);
        for(int i = len-2; i >= 0; i--){
            while(st.Count > 0 && heights[i] > st.Peek()){
                st.Pop();
            }
            
            if(st.Count == 0){
                st.Push(heights[i]);
                result.Add(i);
            }
        }
        
        result.Reverse();
        return result.ToArray();
    }
}