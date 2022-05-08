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
    private int result;
    public int AverageOfSubtree(TreeNode root) {
        result = 0;
        Helper(root);
        return result;
    }
    
    private int[] Helper(TreeNode root){
        if(root == null){
            return new int[] { 0, 0 };
        }
        
        int[] left = Helper(root.left);
        int[] right = Helper(root.right);
        
        int totalNodes = left[0]+right[0] + 1;
        int totalVal = left[1]+right[1] + root.val;
        
        if(totalVal/totalNodes == root.val){
            result++;
        }
        
        return new int[] { totalNodes, totalVal };
    }
}