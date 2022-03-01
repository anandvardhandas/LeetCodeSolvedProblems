/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;
    
    public Node() {
        val = 0;
        children = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        children = new List<Node>();
    }
    
    public Node(int _val, List<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/


public class Solution {
    public Node CloneTree(Node root) {
        if(root == null)
            return null;
        
        return Helper(root);
    }
    
    private Node Helper(Node root){
        if(root == null)
            return null;
        
        Node root2 = new Node(root.val);
        root2.children = new List<Node>();
        
        if(root.children != null){
            foreach(Node child in root.children){
                root2.children.Add(Helper(child));
            }
        }
        
        return root2;
    }
}