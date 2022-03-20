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
    public int ClosestValue(TreeNode root, double target) {
        
        int closest = root.val;
        while(root != null){
            closest = Math.Abs(root.val-target) < Math.Abs(closest-target) ? root.val : closest;
            
            if(target < root.val){
                root = root.left;
            }
            else{
                root = root.right;
            }
        }
        
        return closest;
    }
}