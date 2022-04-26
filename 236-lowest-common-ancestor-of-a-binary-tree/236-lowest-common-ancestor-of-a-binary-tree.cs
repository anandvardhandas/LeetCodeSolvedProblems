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
        if(root == null){
            return null;
        }
        
        return Helper(root, p, q);
    }
    
    private TreeNode Helper(TreeNode root, TreeNode p, TreeNode q){
        if(root == null)
            return null;
        
        
        TreeNode left = Helper(root.left, p, q);
        TreeNode right = Helper(root.right, p, q);
        
        if(left != null && right != null){
            return root;
        }
        
        if(root == p || root == q){
            return root;
        }
        
        if(left != null)
            return left;
        
        if(right != null)
            return right;
        
        return null;
    }
}