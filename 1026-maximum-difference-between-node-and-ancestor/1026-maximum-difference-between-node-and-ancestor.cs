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
    private int Max = 0;
    public int MaxAncestorDiff(TreeNode root) {
        Helper(root, root.val, root.val);
        return Max;
    }
    
    private void Helper(TreeNode root, int min, int max){
        if(root == null)
            return;
        
        Max = Math.Max(Max, Math.Max(Math.Abs(root.val-min), Math.Abs(root.val-max)));
        
        min = Math.Min(min, Math.Min(root.val, max));
        max = Math.Max(max, Math.Max(root.val, min));
        
        Helper(root.left, min, max);
        Helper(root.right, min, max);
    }
}