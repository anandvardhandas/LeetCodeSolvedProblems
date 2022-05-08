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
    public IList<int> BoundaryOfBinaryTree(TreeNode root) {
        IList<int> result = new List<int>();
        result.Add(root.val);
        if(IsLeaf(root)){
            return result;
        }
        
        //adding all left side of boundary
        TreeNode curr = root.left;
        while(curr != null){
            if(IsLeaf(curr)){
                break;
            }
            
            result.Add(curr.val);
                
            if(curr.left != null){
                curr = curr.left;
            }
            else{
                curr = curr.right;
            }
        }
        
        //adding leaves recursively pre order traversal
        AddLeaves(root, result);
        
        //Adding right side boundary reverse
        Stack<int> st = new Stack<int>();
        curr = root.right;
        while(curr != null){
            if(IsLeaf(curr)){
                break;
            }
            
            st.Push(curr.val);
            
            if(curr.right != null){
                curr = curr.right;
            }
            else{
                curr = curr.left;
            }
        }
        
        while(st.Count > 0){
            result.Add(st.Pop());
        }
        
        return result;
    }
    
    private void AddLeaves(TreeNode root, IList<int> result){
        if(root == null){
            return;
        }
        
        if(IsLeaf(root)){
            result.Add(root.val);
        }
        
        AddLeaves(root.left, result);
        AddLeaves(root.right, result);
    }
    
    private bool IsLeaf(TreeNode root){
        if(root.left == null && root.right == null)
            return true;
        
        return false;
    }
}