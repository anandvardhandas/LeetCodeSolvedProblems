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
        
        
        TreeNode left = Helper(root.left, p, q);
        TreeNode right = Helper(root.right, p, q);
        
        if(right != null && left != null){
            return root;
        }
        
        if(root == p || root == q)
            return root;
        
        if(right == null){
            return left;
        }
        
        if(left == null){
            return right;
        }
        
        return null;
    }
}