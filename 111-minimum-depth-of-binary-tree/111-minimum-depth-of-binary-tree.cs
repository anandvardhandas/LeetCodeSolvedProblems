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
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        return 1 + Helper(root);
    }
    
    private int Helper(TreeNode root){
        if(root == null)
            return int.MaxValue;
        
        if(root.left == null && root.right == null){
            return 0;
        }
            
        int lheight = Helper(root.left);
        
        int rheight = Helper(root.right);
        
        if(lheight == int.MaxValue){
            return rheight+1;
        }
        
        if(rheight == int.MaxValue){
            return lheight+1;
        }
        
        return 1+ Math.Min(lheight,rheight);
    }
}