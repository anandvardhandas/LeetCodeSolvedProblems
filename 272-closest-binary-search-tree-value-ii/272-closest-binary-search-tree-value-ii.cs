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
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k, Comparer<int>.Create((x,y) => Math.Abs(y-target).CompareTo(Math.Abs(x-target))));
        Inorder(root, pq, k, target);
        
        
        List<int> result = new List<int>();
        while(pq.Count > 0){
            result.Add(pq.Dequeue());
        }
        
        return result;
    }
    
    private void Inorder(TreeNode root, PriorityQueue<int,int> pq, int k, double target){
        if(root == null)
            return;
        
        Inorder(root.left, pq, k, target);
        if(pq.Count < k){
            pq.Enqueue(root.val,root.val);
        }
        else{
            if(Math.Abs(root.val-target) < Math.Abs(pq.Peek()-target)){
                pq.Dequeue();
                pq.Enqueue(root.val, root.val);
            }
        }
        Inorder(root.right, pq, k, target);
    }
}