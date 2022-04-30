/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
        next = null;
    }

    public Node(int _val, Node _next) {
        val = _val;
        next = _next;
    }
}
*/

public class Solution {
    public Node Insert(Node head, int insertVal) {
        if(head == null){
            Node node = new Node(insertVal);
            node.next = node;
            return node;
        }
            
        if(head.next == head){
            Node node = new Node(insertVal);
            node.next = head;
            head.next = node;
            return head;
        }
        
        Node curr = head;
        while(curr.next != head){
            if(curr.val <= curr.next.val){
                if(insertVal >= curr.val && insertVal <= curr.next.val){
                    break;
                }
            }
            else{
                //decreasing -- curr is maximum of list and curr.next is minimum
                if(insertVal >= curr.val || insertVal <= curr.next.val){
                    break;
                }
            }
            
            curr = curr.next;
        }
        
        Node newnode = new Node(insertVal);
        newnode.next = curr.next;
        curr.next = newnode;
        
        return head;
    }
}