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
        List<Node> plist = new List<Node>();
        List<Node> qlist = new List<Node>();
        
        Node currp = p;
        plist.Add(currp);
        while(currp.parent != null){
            plist.Add(currp.parent);
            currp = currp.parent;
        }
        
        Node currq = q;
        qlist.Add(currq);
        while(currq.parent != null){
            qlist.Add(currq.parent);
            currq = currq.parent;
        }
        
        int i = plist.Count-1, j = qlist.Count-1;
        
        Node lca = plist[i];
        while(i >= 0 && j >= 0 && plist[i] == qlist[j]){
            lca = plist[i];
            i--;
            j--;
        }
        
        return lca;
    }
}