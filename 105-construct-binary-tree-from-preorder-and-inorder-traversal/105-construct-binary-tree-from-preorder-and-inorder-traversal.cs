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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int len = preorder.Length;
        
        Dictionary<int,int> inmap = new Dictionary<int,int>();
        
        for(int i = 0; i < len; i++){
            inmap.Add(inorder[i],i);
        }
        
        return Helper(preorder,inorder,inmap,0,len-1,0,len-1);
    }
    
    private TreeNode Helper(int[] pre, int[] inord, Dictionary<int,int> inmap, int prestart, int preend, int instart, int inend){
        if(prestart > preend || instart > inend)
            return null;
        
        TreeNode root = new TreeNode(pre[prestart]);
        
        int rootindex = inmap[root.val];
        
        int diff = rootindex-instart;
        
        root.left = Helper(pre,inord,inmap,prestart+1,prestart+diff,instart,rootindex-1);
        root.right = Helper(pre,inord,inmap,prestart+1+diff,preend,rootindex+1,inend);
        
        return root;
    }
}