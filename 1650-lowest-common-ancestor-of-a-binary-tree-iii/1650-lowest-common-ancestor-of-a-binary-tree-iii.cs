/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {
        int pdepth = GetDepth(p);
        int qdepth = GetDepth(q);
        
        while(pdepth > qdepth){
            p = p.parent;
            pdepth--;
        }
        
        while(qdepth > pdepth){
            q = q.parent;
            qdepth--;
        }
        
        while(p != q){
            p = p.parent;
            q = q.parent;
        }
        
        return p;
    }
    
    private int GetDepth(Node n){
        int depth = 0;
        while(n != null){
            n = n.parent;
            depth++;
        }
        
        return depth;
    }
}