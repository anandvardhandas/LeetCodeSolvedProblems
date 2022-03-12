/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null)
            return head;
        
        //using hashtable
        Dictionary<Node,Node> map = new Dictionary<Node,Node>();
        Node curr = head;
        while(curr != null){
            Node newnode = new Node(curr.val);
            map.Add(curr, newnode);
            curr = curr.next;
        }
        
       
        foreach(var item in map){
            if(item.Key.next != null)
                item.Value.next = map[item.Key.next];
            
            if(item.Key.random != null)
                item.Value.random = map[item.Key.random];
        }
        
        return map[head];
        
    }
}