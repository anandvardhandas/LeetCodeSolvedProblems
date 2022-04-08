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
    private int max = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Helper(root);
        return max;
    }
    
    private int Helper(TreeNode root){
        
        if(root == null)
            return 0;
        
        
        int maxleft = Math.Max(Helper(root.left), 0);
        int maxright = Math.Max(Helper(root.right), 0);
        
        max = Math.Max(max, root.val+maxleft+maxright);
        
        int maxchild = Math.Max(maxleft, maxright);
        
        return root.val + maxchild;
    }
    
}