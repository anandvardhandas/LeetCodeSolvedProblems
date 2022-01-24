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
    private TreeNode root;
    
    public CBTInserter(TreeNode root) {
        this.root = root;
    }
    
    public int Insert(int val) {
        Queue<TreeNode> que = new Queue<TreeNode>();
        TreeNode curr = root;
        que.Enqueue(curr);
        while(que.Count > 0){
            curr = que.Dequeue();
            if(curr.left != null)
                que.Enqueue(curr.left);
            else{
                TreeNode newNode = new TreeNode(val);
                curr.left = newNode;
                return curr.val;
            }
            
            if(curr.right != null)
                que.Enqueue(curr.right);
            else{
                TreeNode newNode = new TreeNode(val);
                curr.right = newNode;
                return curr.val;
            }
        }
        
        return -1;
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