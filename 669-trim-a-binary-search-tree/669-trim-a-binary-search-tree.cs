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
    public TreeNode TrimBST(TreeNode root, int low, int high) {
        if(root == null)
            return null;
        
        int hi = high;
        if(root.val >= low && root.val <= hi){
            Helper(root.left, root, low, hi);
            Helper(root.right, root, low, hi);
        }
        else if(root.val < low){
            return TrimBST(root.right, low, hi);
        }
        else{
            return TrimBST(root.left, low, hi);
        }
        
        return root;
    }
    
    private void Helper(TreeNode root, TreeNode parent, int low, int hi){
        if(root == null)
            return;
        
        if(root.val >= low && root.val <= hi){
            Helper(root.left, root, low, hi);
            Helper(root.right, root, low, hi);
        }
        else if(root.val < low){
            root.left = null;
            parent.left = root.right;
            Helper(root.right, parent, low, hi);
        }
        else{
            root.right = null;
            parent.right = root.left;
            Helper(root.left, parent, low, hi);
        }
    }
}