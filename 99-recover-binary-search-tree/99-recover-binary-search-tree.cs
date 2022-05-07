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
    public void RecoverTree(TreeNode root) {
        TreeNode first = null, second = null;
        
        TreeNode prev = null;
        TreeNode curr = root;
        
        Stack<TreeNode> st = new Stack<TreeNode>();
        while(st.Count > 0 || curr != null){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            if(prev != null){
                if(curr.val <= prev.val){
                    if(first == null){
                        first = prev;
                    }
                    
                     if(first != null){
                        second = curr;
                    }
                }
            }
            
            prev = curr;
            curr = curr.right;
        }
        
        int temp = first.val;
        first.val = second.val;
        second.val = temp;
        
        
    }
}