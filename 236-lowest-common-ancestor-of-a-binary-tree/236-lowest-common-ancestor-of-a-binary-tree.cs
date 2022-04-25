/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        List<int> ppath = new List<int>();
        List<int> qpath = new List<int>();
        
        FindRootToNodePath(root, ppath, p);
        FindRootToNodePath(root, qpath, q);
        
        int lca = 0;
        int i = 0;
        while(i <= ppath.Count-1 && i <= qpath.Count-1 && ppath[i] == qpath[i]){
            lca = ppath[i];
            i++;
        }
        
        return new TreeNode(lca);
    }
    
    
    private bool FindRootToNodePath(TreeNode root, List<int> path, TreeNode find){
        if(root == null)
            return false;
        
        if(root.val == find.val){
            path.Add(root.val);
            return true;
        }
        
        path.Add(root.val);
        bool found = FindRootToNodePath(root.left, path, find);
        if(found)
            return true;
        found = FindRootToNodePath(root.right, path, find);
        if(found)
            return true;
        path.RemoveAt(path.Count-1);
        
        return false;
    }
}