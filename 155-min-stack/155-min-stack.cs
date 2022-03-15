public class MinStack {
    Stack<Node> st;
    public MinStack() {
        st = new Stack<Node>();
    }
    
    public void Push(int val) {
        Node n = new Node(val,val);
        if(st.Count > 0){
            if(val > st.Peek().min){
                n.min = st.Peek().min;
            }
        }
        
        st.Push(n);
    }
    
    public void Pop() {
        st.Pop();
    }
    
    public int Top() {
        return st.Peek().val;
    }
    
    public int GetMin() {
        return st.Peek().min;
    }
}

public class Node{
    public int val;
    public int min;
    
    public Node(int _val, int _min){
        val = _val;
        min = _min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */