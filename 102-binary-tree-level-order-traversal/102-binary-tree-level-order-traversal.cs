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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root == null)
            return result;
        
        
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        
        while(que.Count > 0){
            int size = que.Count;
            IList<int> items = new List<int>();
            for(int i = 1; i <= size; i++){
                TreeNode node = que.Dequeue();
                items.Add(node.val);
                
                if(node.left != null)
                    que.Enqueue(node.left);
                if(node.right != null)
                    que.Enqueue(node.right);
                
            }
            
            result.Add(items);
        }
        
        return result;
    }
}