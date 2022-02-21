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
        
        int result = 0;
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                TreeNode node = que.Dequeue();
                if(i == 1){
                    result = node.val;
                }
                
                if(node.left != null){
                    que.Enqueue(node.left);
                }
                
                if(node.right != null){
                    que.Enqueue(node.right);
                }
            }
        }
        
        return result;
    }
}