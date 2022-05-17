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
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        return Helper(original, cloned, target);
    }
    
    private TreeNode Helper(TreeNode orig, TreeNode clon, TreeNode target){
        if(orig == null){
            return null;
        }
        
        if(orig == target){
            return clon;
        }
        
        TreeNode left = Helper(orig.left, clon.left, target);
        if(left != null){
            return left;
        }
        
        TreeNode right = Helper(orig.right, clon.right, target);
        if(right != null){
            return right;
        }
        
        return null;
    }
}