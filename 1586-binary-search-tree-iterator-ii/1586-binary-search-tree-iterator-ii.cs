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
    
    private int[] inorder;
    private int len;
    private int index = -1;
    public BSTIterator(TreeNode root) {
        List<int> list = new List<int>();
        CreateInOrder(root, list);
        inorder = list.ToArray();
        len = inorder.Length;
    }
    
    private void CreateInOrder(TreeNode root, List<int> list){
        if(root == null)
            return;
        
        CreateInOrder(root.left, list);
        list.Add(root.val);
        CreateInOrder(root.right, list);
    }
    
    public bool HasNext() {
        if(index < len-1)
            return true;
        
        return false;
    }
    
    public int Next() {
        index++;
        return inorder[index];
    }
    
    public bool HasPrev() {
        if(index > 0)
            return true;
        
        return false;
    }
    // [3,7,9,15,20]
    public int Prev() {
        index--;
        return inorder[index];
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * bool param_1 = obj.HasNext();
 * int param_2 = obj.Next();
 * bool param_3 = obj.HasPrev();
 * int param_4 = obj.Prev();
 */