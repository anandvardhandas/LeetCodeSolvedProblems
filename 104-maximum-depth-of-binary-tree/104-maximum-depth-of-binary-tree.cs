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
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        int lheight = 1 + MaxDepth(root.left);
        int rheight = 1 + MaxDepth(root.right);
        
        int maxHeight = Math.Max(lheight, rheight);
        return maxHeight;
    }
}