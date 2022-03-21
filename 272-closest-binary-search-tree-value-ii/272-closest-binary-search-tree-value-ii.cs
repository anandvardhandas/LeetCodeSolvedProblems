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
    public IList<int> ClosestKValues(TreeNode root, double target, int k) {
        Queue<int> pq = new Queue<int>(k);
        Inorder(root, pq, k, target);
        
        
        List<int> result = new List<int>();
        while(pq.Count > 0){
            result.Add(pq.Dequeue());
        }
        
        return result;
    }
    
    private void Inorder(TreeNode root, Queue<int> pq, int k, double target){
        if(root == null)
            return;
        
        Inorder(root.left, pq, k, target);
        if(pq.Count < k){
            pq.Enqueue(root.val);
        }
        else{
            if(Math.Abs(root.val-target) < Math.Abs(pq.Peek()-target)){
                pq.Dequeue();
                pq.Enqueue(root.val);
            }
            else
                return;
        }
        Inorder(root.right, pq, k, target);
    }
}