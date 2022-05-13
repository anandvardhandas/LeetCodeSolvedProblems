/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null)
            return null;
        
        Node curr = root;
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(curr);
        
        while(que.Count > 0){
            int size = que.Count;
            Node prev = null;
            for(int i = 1; i <= size; i++){
                Node node = que.Dequeue();
                node.next = prev;
                prev = node;
                
                if(node.right != null)
                    que.Enqueue(node.right);
                
                if(node.left != null)
                    que.Enqueue(node.left);
            }
        }
        
        return root;
    }
}