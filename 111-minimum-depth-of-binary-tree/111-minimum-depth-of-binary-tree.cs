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
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        int level = 1;
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                TreeNode node = que.Dequeue();
                if(node.left == null && node.right == null){
                    return level;
                }
                
                if(node.left != null){
                    que.Enqueue(node.left);
                }
                
                if(node.right != null){
                    que.Enqueue(node.right);
                }
            }
            
            level++;
        }
        
        return 0;
    }
}