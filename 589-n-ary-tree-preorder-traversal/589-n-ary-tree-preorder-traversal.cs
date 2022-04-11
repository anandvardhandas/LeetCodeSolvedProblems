/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        IList<int> result = new List<int>();
        Helper(root, result);
        return result;
    }
    
    private void Helper(Node root, IList<int> result){
        if(root == null)
            return;
        
        result.Add(root.val);
        IList<Node> child = root.children;
        foreach(Node n in child){
            Helper(n, result);
        }
    }
}