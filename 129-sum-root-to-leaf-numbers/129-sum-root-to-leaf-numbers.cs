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
    private int total;
    public int SumNumbers(TreeNode root) {
        total = 0;
        Helper(root,0);
        return total;
    }
    
    private void Helper(TreeNode root, int temp){
        if(root == null)
            return;
        
        temp = temp * 10 + root.val;
        
        Helper(root.left, temp);
        Helper(root.right, temp);
        
        if(root.left == null && root.right == null){
            total += temp;
        }
        
        temp = temp/10;
    }
}