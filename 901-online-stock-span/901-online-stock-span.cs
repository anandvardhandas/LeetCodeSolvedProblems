public class StockSpanner {
    
    Stack<int[]> st;
    public StockSpanner() {
        st = new Stack<int[]>();
    }
    
    public int Next(int price) {
        int result = 1;
        while(st.Count > 0 && price >= st.Peek()[0]){
            result += st.Pop()[1];
        }
        
        st.Push(new int[] { price, result });
        
        return result;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */