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
    
    public int DeepestLeavesSum(TreeNode root) {
        int[] result = new int[] { 0, 0 };
        Helper(root, 0, result);
        return result[1];
    }
    
    private void Helper(TreeNode root, int depth, int[] result){
        if(root == null)
            return;
        
        if(root.left == null && root.right == null){
            int maxdepth = result[0], sum = result[1];
            if(depth+1 > maxdepth){
                maxdepth = depth+1;
                sum = root.val;
            }
            else if(depth+1 == maxdepth){
                sum += root.val;
            }
            
            result[0] = maxdepth;
            result[1] = sum;
        }
        
        Helper(root.left, depth+1, result);
        Helper(root.right, depth+1, result);
    }
}