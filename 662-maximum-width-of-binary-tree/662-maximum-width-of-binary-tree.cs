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
    public int WidthOfBinaryTree(TreeNode root) {
        Queue<(TreeNode,int)> que = new Queue<(TreeNode,int)>();
        que.Enqueue((root,0));
        int maxlen = 0;
        while(que.Count > 0){
            int size = que.Count;
            (TreeNode node, int index) = que.Peek();
            TreeNode n = null;
            int j = 0;
            for(int i = 1; i <= size; i++){
                (n, j) = que.Dequeue();
                if(n.left != null)
                    que.Enqueue((n.left,2*j));
                
                if(n.right != null)
                    que.Enqueue((n.right,2*j+1));
            }
            
            maxlen = Math.Max(maxlen, j-index+1);
        }
        
        return maxlen;
    }
}