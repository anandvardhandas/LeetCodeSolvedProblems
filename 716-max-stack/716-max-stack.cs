public class MaxStack {
    DLL dll;
    SortedDictionary<int,List<Node>> map;
    public MaxStack() {
        dll = new DLL();
        map = new SortedDictionary<int,List<Node>>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
    }
    
    public void Push(int x) {
        Node node = dll.Add(x);
        if(map.ContainsKey(x)){
            map[x].Add(node);
        }
        else{
            map.Add(x, new List<Node>() { node });
        }
    }
    
    public int Pop() {
        Node node = dll.Remove();
        List<Node> nodes = map[node.val];
        nodes.RemoveAt(nodes.Count-1);
        if(nodes.Count == 0)
            map.Remove(node.val);
            
        return node.val;
    }
    
    public int Top() {
        return dll.GetTop().val;
    }
    
    public int PeekMax() {
        return map.First().Key;
    }
    
    public int PopMax() {
        
        int maxVal = PeekMax();
        List<Node> nodes = map[maxVal];
        Node nodeToRemove = nodes[nodes.Count-1];
        dll.Remove(nodeToRemove);
        nodes.RemoveAt(nodes.Count-1);
        
        if(nodes.Count == 0)
            map.Remove(maxVal);
        
        return maxVal;
    }
}

public class DLL{
    public Node head;
    public Node tail;
    public DLL(){
        head = new Node();
        tail = new Node();
        head.next = tail;
        tail.prev = head;
    }
    
    public Node Add(int val){
        Node node = new Node(val);
        node.next = head.next;
        head.next.prev = node;
        node.prev = head;
        head.next = node;
        
        return node;
    }
    
    public Node Remove(){
        Node node = head.next;
        Remove(node);
        return node;
    }
    
    public void Remove(Node node){
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
    
    public Node GetTop(){
        return head.next;
    }
}

public class Node{
    public int val;
    public Node next;
    public Node prev;
    
    public Node(int _val = 0, Node _next = null, Node _prev = null){
        val = _val;
        next = _next;
        prev = _prev;
    }
    
    
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */