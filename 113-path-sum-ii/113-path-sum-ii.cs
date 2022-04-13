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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> result = new List<IList<int>>();
        
        if(root == null)
            return result;
        
        List<int> temp = new List<int>();
        temp.Add(root.val);
        Helper(root, targetSum, root.val, result, temp);
        return result;
    }
    
    private void Helper(TreeNode root, int target, int currSum, IList<IList<int>> result, List<int> temp){
        if(root == null)
            return;
        
        if(root.left == null && root.right == null){
            if(currSum == target)
                result.Add(new List<int>(temp));
            return;
        }
        
        if(root.left != null){
            temp.Add(root.left.val);
            Helper(root.left, target, currSum+root.left.val, result, temp);
            temp.RemoveAt(temp.Count-1);
        }
        
        if(root.right != null){
            temp.Add(root.right.val);
            Helper(root.right, target, currSum+root.right.val, result, temp);
            temp.RemoveAt(temp.Count-1);
        }
        
    }
}