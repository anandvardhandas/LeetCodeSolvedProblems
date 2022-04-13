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
    
    private int total = 0;
    public int PathSum(TreeNode root, int targetSum) {
        if(root == null)
            return 0;
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,1);
        Helper(root, targetSum, root.val, map);
        return total;
    }
    
    private void Helper(TreeNode root, int target, int currSum, Dictionary<int,int> map){
        if(root == null)
            return;
        
        if(currSum == target){
            total += map[0];
        }
        else{
            if(map.ContainsKey(currSum-target)){
                total += map[currSum-target];
            }
        }
        
        if(map.ContainsKey(currSum)){
            map[currSum]++;
        }
        else{
            map.Add(currSum, 1);
        }
        
        if(root.left != null){
            Helper(root.left, target, currSum + root.left.val, map);
        }
        
        if(root.right != null){
            Helper(root.right, target, currSum + root.right.val, map);
        }
        
        
        map[currSum]--;
    }
}