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
    public int FindBottomLeftValue(TreeNode root) {
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        
        while(que.Count > 0){
            root = que.Dequeue();
            
            if(root.right != null){
                que.Enqueue(root.right);
            }
            if(root.left != null){
                que.Enqueue(root.left);
            }
        }
        
        return root.val;
    }
}