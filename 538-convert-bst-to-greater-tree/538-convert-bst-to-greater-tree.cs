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
    
    private int total;
    private int curr = 0;
    public TreeNode ConvertBST(TreeNode root) {
        List<int> list = new List<int>();
        Inorder(root, list);
        int[] nums = list.ToArray();
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
        }
        
        this.total = sum;
        
        Convert(root, list);
        
        return root;
    }
    
    private int index = 0;
    private void Convert(TreeNode root, List<int> list){
        if(root == null)
            return;
        
        Convert(root.left, list);
        int temp = root.val;
        root.val = this.total-curr;
        curr += temp;
        Convert(root.right, list);
    }
    
    private void Inorder(TreeNode root, List<int> list){
        if(root == null)
            return;
        
        Inorder(root.left, list);
        list.Add(root.val);
        Inorder(root.right, list);
    }
}