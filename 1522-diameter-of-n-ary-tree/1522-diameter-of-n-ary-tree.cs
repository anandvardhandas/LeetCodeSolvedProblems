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
    private int maxdiameter;
    public int Diameter(Node root) {
        maxdiameter = 0;
        if(root == null)
            return 0;
        
        Helper(root);
        return maxdiameter;
    }
    
    private int Helper(Node root){
        if(root == null)
            return 0;
        
        if(root.children == null || root.children.ToList().Count == 0){
            return 0;
        }
        
        int maxheight = 0;
        int secondmaxheight = 0;
        int totaldiam = 0;
        IList<Node> children = root.children;
        foreach(Node child in children){
            int height = 1 + Helper(child);
            if(height > maxheight){
                secondmaxheight = maxheight;
                maxheight = height;
            }
            else if(height > secondmaxheight){
                secondmaxheight = height;
            }
            
        }
        
       
        totaldiam = maxheight + secondmaxheight;
        
        maxdiameter = Math.Max(maxdiameter,totaldiam);
        return maxheight;
        
    }
}