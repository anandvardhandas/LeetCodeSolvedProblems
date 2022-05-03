public class Solution {
    public long SubArrayRanges(int[] nums) {
        int len = nums.Length;
        
        long[] ple = new long[len];
        long[] nle = new long[len];
        
        Stack<Node> st = new Stack<Node>();
        for(int i = 0; i < len; i++){
            long count = 1;
            while(st.Count > 0 && nums[i] <= st.Peek().val){
                count += st.Pop().dist;
            }
            
            ple[i] = count;
            st.Push(new Node(nums[i],count));
        }
        
        st = new Stack<Node>();
        for(int i = len-1; i >= 0; i--){
            long count = 1;
            while(st.Count > 0 && nums[i] < st.Peek().val){
                count += st.Pop().dist;
            }
            
            nle[i] = count;
            st.Push(new Node(nums[i],count));
        }
        
        long[] pge = new long[len];
        long[] nge = new long[len];
        
        st = new Stack<Node>();
        for(int i = 0; i < len; i++){
            long count = 1;
            while(st.Count > 0 && nums[i] >= st.Peek().val){
                count += st.Pop().dist;
            }
            
            pge[i] = count;
            st.Push(new Node(nums[i],count));
        }
        
        st = new Stack<Node>();
        for(int i = len-1; i >= 0; i--){
            long count = 1;
            while(st.Count > 0 && nums[i] > st.Peek().val){
                count += st.Pop().dist;
            }
            
            nge[i] = count;
            st.Push(new Node(nums[i],count));
        }
        
        long total = 0;
        for(int i = 0; i < len; i++){
            total += ((pge[i]*nge[i]) - (ple[i]*nle[i]))*nums[i];
        }
        
        
        return total;
    }
}

public class Node{
    public long val;
    public long dist;
    public Node(long _val, long _dist){
        val = _val;
        dist = _dist;
    }
}