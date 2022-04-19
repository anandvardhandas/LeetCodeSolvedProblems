/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null)
            return 0;
        
        Helper(root);
        
        return max;
    }
    
    private int Helper(TreeNode root){
        if(root == null)
            return 0;
        
        if(root.left == null && root.right == null)
            return 0;
        
        int left = 0;
        if(root.left != null)
            left = 1 + Helper(root.left);
        int right = 0;
        if(root.right != null)
            right = 1 + Helper(root.right);
        
        int height = Math.Max(left,right);
        max = Math.Max(max, left+right);
        
        return height;
    }
}