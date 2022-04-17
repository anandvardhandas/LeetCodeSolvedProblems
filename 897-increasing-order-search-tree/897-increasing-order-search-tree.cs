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
    public TreeNode IncreasingBST(TreeNode root) {
        List<int> result = new List<int>();
        
        TreeNode newroot = new TreeNode();
        TreeNode newcurr = newroot;
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = root;
        while(st.Count > 0 || curr != null){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            newcurr.right = new TreeNode(curr.val);
            newcurr = newcurr.right;
            
            curr = curr.right;
                
        }
        
        return newroot.right;
    }
    
    
}