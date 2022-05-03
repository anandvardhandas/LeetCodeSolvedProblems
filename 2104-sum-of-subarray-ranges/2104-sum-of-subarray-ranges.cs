public class Solution {
    public long SubArrayRanges(int[] nums) {
        int len = nums.Length;
        Stack<long> st = new Stack<long>();
        long[] ple = new long[len];
        long[] nle = new long[len];
        
        ple[0] = -1;
        st.Push(0);
        for(int i = 1; i < len; i++){
            while(st.Count > 0 && nums[i] <= nums[st.Peek()]){
                st.Pop();
            }
            
            ple[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        
        st = new Stack<long>();
        st.Push(len-1);
        nle[len-1] = -1;
        for(int i = len-2; i >= 0; i--){
            while(st.Count > 0 && nums[i] < nums[st.Peek()]){
                st.Pop();
            }
            
            nle[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        long mintotal = 0;
        for(int i = 0; i < len; i++){
            long left = 1, right = 1;
            
            if(ple[i] != -1){
                left = i-ple[i];
            }
            else{
                left = i+1;
            }
            
            if(nle[i] != -1){
                right = nle[i]-i;
            }
            else{
                right = len-i;
            }
            
            mintotal = mintotal + nums[i] * left * right;
        }
        
        long[] pge = new long[len];
        long[] nge = new long[len];
        
        pge[0] = -1;
        st = new Stack<long>();
        st.Push(0);
        for(int i = 1; i < len; i++){
            while(st.Count > 0 && nums[i] >= nums[st.Peek()]){
                st.Pop();
            }
            
            pge[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        
        st = new Stack<long>();
        st.Push(len-1);
        nge[len-1] = -1;
        for(int i = len-2; i >= 0; i--){
            while(st.Count > 0 && nums[i] > nums[st.Peek()]){
                st.Pop();
            }
            
            nge[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        long maxtotal = 0;
        for(int i = 0; i < len; i++){
            long left = 1, right = 1;
            
            if(pge[i] != -1){
                left = i-pge[i];
            }
            else{
                left = i+1;
            }
            
            if(nge[i] != -1){
                right = nge[i]-i;
            }
            else{
                right = len-i;
            }
            
            maxtotal = maxtotal + nums[i] * left * right;
        }
        
        
        return maxtotal - mintotal;
    }
}