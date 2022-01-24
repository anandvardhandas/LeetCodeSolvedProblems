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
public class CBTInserter {
    Queue<TreeNode> que;
    private TreeNode root;
    private TreeNode curr;
    public CBTInserter(TreeNode root) {
        this.root = root;
        this.curr = root;
        
        que = new Queue<TreeNode>();
        que.Enqueue(curr);
        
        while(que.Count > 0){
            curr = que.Dequeue();
            if(curr.left != null)
                que.Enqueue(curr.left);
            else{
                break;
            }
            
            if(curr.right != null)
                que.Enqueue(curr.right);
            else{
                break;
            }
        }
    }
    
    public int Insert(int val) {
        int result = -1;
       if(curr.left == null){
           curr.left = new TreeNode(val);
           que.Enqueue(curr.left);
           result = curr.val;
       }
       else if(curr.right == null){
           curr.right = new TreeNode(val);
           que.Enqueue(curr.right);
           result = curr.val;
           curr = que.Dequeue();
       }
        
        return result;
    }
    
    public TreeNode Get_root() {
        return this.root;
    }
}

/**
 * Your CBTInserter object will be instantiated and called as such:
 * CBTInserter obj = new CBTInserter(root);
 * int param_1 = obj.Insert(val);
 * TreeNode param_2 = obj.Get_root();
 */