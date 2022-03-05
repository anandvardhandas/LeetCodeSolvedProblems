/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node() {}

    public Node(int _val) {
        val = _val;
        left = null;
        right = null;
    }

    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
    }
}
*/

public class Solution {
    public Node TreeToDoublyList(Node root) {
        if(root == null)
            return null;
        
        Node curr = root;
        Stack<Node> st = new Stack<Node>();
        Node head = null;
        Node prev = null;
        bool first = false;
        while(st.Count > 0 || curr != null){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            if(prev != null){
                prev.right = curr;
                curr.left = prev;
            }
            else{
                first = true;
                //Console.WriteLine("once");
            }
            
            
            prev = curr;
            
            if(first){
                head = prev;
                first = false;
            }
            
            //print curr.val
            curr = curr.right;
        }
        
        
        prev.right = head;
        head.left = prev;
        
        return head;
    }
}