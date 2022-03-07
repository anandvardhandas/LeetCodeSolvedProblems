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
        
        Dictionary<Node,Node> map = new Dictionary<Node,Node>();
        Node dummy = new Node(0);
        Node curr = dummy;
        while(head != null){
            if(map.ContainsKey(head))
                curr.next = map[head];
            else
                curr.next = new Node(head.val);
            
             if(!map.ContainsKey(head))
                map.Add(head, curr.next);
            
            if(head.random != null){
                if(map.ContainsKey(head.random))
                    curr.next.random = map[head.random];
                else{
                    curr.next.random = new Node(head.random.val);
                    map.Add(head.random, curr.next.random);
                }
            }
            
            
            curr = curr.next;
            head = head.next;
        }
        
        return dummy.next;
    }
}