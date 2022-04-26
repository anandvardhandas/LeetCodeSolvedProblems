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
    private int sum;
    public int RangeSumBST(TreeNode root, int low, int high) {
        sum = 0;
        if(root == null){
            return sum;
        }
        
        Helper(root, low, high);
        return sum;
    }
    
    private void Helper(TreeNode root, int low, int high){
        if(root == null)
            return;
        
        if(root.val >= low && root.val <= high){
            sum += root.val;
        }
        
        if(root.val > low){
            Helper(root.left, low, high);
        }
        
        if(root.val < high){
            Helper(root.right, low, high);
        }
        
    }
}