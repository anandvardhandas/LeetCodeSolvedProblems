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
    public int FindSecondMinimumValue(TreeNode root) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        Helper(root, map);
        
        int min = root.val; long min2 = long.MaxValue;
        
        foreach(var item in map){
            if(item.Key > min && item.Key < min2)
                min2 = item.Key;
        }
        
        return min2 == long.MaxValue ? -1 : (int) min2;
    }
    
    public void Helper(TreeNode root, Dictionary<int,int> map){
        if(root == null)
            return;
        
        if(!map.ContainsKey(root.val)){
            map.Add(root.val,root.val);
        }
        
        Helper(root.left, map);
        Helper(root.right, map);
    }
}