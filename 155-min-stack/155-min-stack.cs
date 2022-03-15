public class MinStack {
    Node head;
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(head == null){
            head = new Node(val,val);
        }
        else{
            Node n = new Node(val,val);
            if(val > head.min){
                n.min = head.min;
            }
            
            n.next = head;
            head = n;
        }
    }
    
    public void Pop() {
        head = head.next;
    }
    
    public int Top() {
        return head.val;
    }
    
    public int GetMin() {
        return head.min;
    }
}

public class Node{
    public int val;
    public int min;
    public Node next;
    
    public Node(int _val, int _min, Node _next = null){
        val = _val;
        min = _min;
        next = _next;
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