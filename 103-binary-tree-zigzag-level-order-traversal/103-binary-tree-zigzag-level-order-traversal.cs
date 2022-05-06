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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        
        if(root == null)
            return result;

        Stack<TreeNode> st1 = new Stack<TreeNode>();
        Stack<TreeNode> st2 = new Stack<TreeNode>();
        st1.Push(root);
        
        while(st1.Count > 0 || st2.Count > 0){
            IList<int> res = new List<int>();
            while(st1.Count > 0){
                TreeNode node = st1.Pop();
                res.Add(node.val);
                
                if(node.left != null){
                    st2.Push(node.left);
                }

                if(node.right != null){
                    st2.Push(node.right);
                }
            }
            
            if(res.Count > 0)
                result.Add(res);
            
            res = new List<int>();
            while(st2.Count > 0){
                TreeNode node = st2.Pop();
                res.Add(node.val);
                
                if(node.right != null){
                    st1.Push(node.right);
                }
                
                if(node.left != null){
                    st1.Push(node.left);
                }
            }
            
            if(res.Count > 0)
                result.Add(res);
        }
        
        return result;
    }
}