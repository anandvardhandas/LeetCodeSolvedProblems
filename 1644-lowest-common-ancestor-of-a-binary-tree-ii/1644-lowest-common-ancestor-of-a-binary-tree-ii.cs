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
    bool foundp = false;
    bool foundq = false;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode lca = Helper(root, p, q);
        if(foundp && foundq)
            return lca;
        
        return null;
    }
    
    private TreeNode Helper(TreeNode root, TreeNode p, TreeNode q){
        if(root == null)
            return null;
        
        TreeNode left = Helper(root.left, p, q);
        TreeNode right = Helper(root.right, p, q);
        
        if(left != null && right != null){
            return root;
        }
        
        if(root == p){
            foundp = true;
            return root;
        }
        
        if(root == q){
            foundq = true;
            return root;
        }
        
        if(left != null){
            return left;
        }
        
        if(right != null){
            return right;
        }
        
        return null;
    }
}