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
    public int RangeSumBST(TreeNode root, int low, int high) {
        int sum = 0;
        if(root == null){
            return sum;
        }
        
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        while(que.Count > 0){
            root = que.Dequeue();
            if(root.val >= low && root.val <= high){
                sum += root.val;
            }

            if(root.val > low && root.left != null){
                que.Enqueue(root.left);
            }

            if(root.val < high && root.right != null){
                que.Enqueue(root.right);
            }
        }
        
        return sum;
    }
}