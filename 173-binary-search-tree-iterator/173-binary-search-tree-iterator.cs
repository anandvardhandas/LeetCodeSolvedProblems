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
public class BSTIterator {
    Stack<TreeNode> st;
    TreeNode curr;
    public BSTIterator(TreeNode root) {
        st = new Stack<TreeNode>();
        curr = root;
    }
    
    public int Next() {
        int result = -1;
        while(st.Count > 0 || curr != null){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            result = curr.val;
            curr = curr.right;
            return result;
        }
        
        return result;
    }
    
    public bool HasNext() {
        if(curr != null || st.Count > 0)
            return true;
        
        return false;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */