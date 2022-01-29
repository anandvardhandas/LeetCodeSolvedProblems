public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int len = heights.Length;
        
        int[] left = new int[len];
        Stack<int> st = new Stack<int>();
        left[0] = -1;
        st.Push(0);
        for(int i = 1; i < len; i++){
            while(st.Count > 0 && heights[i] <= heights[st.Peek()]){
                st.Pop();
            }
            
            if(st.Count == 0)
                left[i] = -1;
            else
                left[i] = st.Peek();
            
            st.Push(i);
        }
        
        int[] right = new int[len];
        st = new Stack<int>();
        st.Push(len-1);
        right[len-1] = len;
        for(int i = len-2; i >= 0; i--){
            while(st.Count > 0 && heights[i] <= heights[st.Peek()]){
                st.Pop();
            }
            
            if(st.Count == 0)
                right[i] = len;
            else
                right[i] = st.Peek();
            
            st.Push(i);
        }
        
        int maxArea = 0;
        for(int i = 0; i < len; i++){
            int width = (i-left[i]) + (right[i]-i) - 1;
            int currArea = width * heights[i];
            maxArea = Math.Max(maxArea, currArea);
        }
        
        
        return maxArea;;
    }
}