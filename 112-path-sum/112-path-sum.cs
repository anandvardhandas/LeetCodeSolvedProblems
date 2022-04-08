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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null)
            return false;
        
        return Helper(root, targetSum, root.val);
        
    }
    
    private bool Helper(TreeNode root, int target, int curr){
        if(root == null)
            return false;
        
        if(target == curr && root.left == null && root.right == null)
            return true;
        
        
        bool left = false, right = false;
        if(root.left != null){
            left = Helper(root.left, target, curr+root.left.val);
        }
        
        if(root.right != null){
            right = Helper(root.right, target, curr+root.right.val);
        }
        
        
        return left || right;
    }
}