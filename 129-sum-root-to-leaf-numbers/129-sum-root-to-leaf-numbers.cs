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
    public int SumNumbers(TreeNode root) {
        total = 0;
        Helper(root,new List<char>());
        return total;
    }
    
    private void Helper(TreeNode root, List<char> temp){
        if(root == null)
            return;
        
        temp.Add(char.Parse(root.val.ToString()));
        
        Helper(root.left, temp);
        Helper(root.right, temp);
        
        if(root.left == null && root.right == null){
            total += int.Parse(new string(temp.ToArray()));
        }
        
        temp.RemoveAt(temp.Count-1);
    }
}