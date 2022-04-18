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
    public int KthSmallest(TreeNode root, int k) {
        int count = 0;
        
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = root;
        
        while(st.Count > 0 || curr != null){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            count++;
            if(count == k)
                return curr.val;
            
            curr = curr.right;
        }
        
        return -1;
    }
}