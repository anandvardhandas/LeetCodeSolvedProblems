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
        
        return Helper(root, p, q);
        
    }
    
    private TreeNode Helper(TreeNode root, TreeNode p, TreeNode q){
        if(root == null)
            return null;
        
        if(root.val == p.val || root.val == q.val){
            return root;
        }
        
        if((p.val > root.val && q.val < root.val) || (p.val < root.val && q.val > root.val))
            return root;
        
        if(p.val > root.val && q.val > root.val){
            return Helper(root.right, p, q);
        }
        else{
            return Helper(root.left, p, q);
        }
    }
}