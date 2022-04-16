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
    
    public TreeNode ConvertBST(TreeNode root) {
        Inorder(root);
        return root;
    }
    
    private int curr = 0;
    private void Inorder(TreeNode root){
        if(root == null)
            return;
        
        Inorder(root.right);
        root.val = root.val+curr;
        curr = root.val;
        Inorder(root.left);
    }
}