/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private TreeNode lca = null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes) {
        HashSet<int> map = new HashSet<int>();
        foreach(TreeNode node in nodes){
            map.Add(node.val);
        }
        
        Helper(root, map);
        return lca;
    }
    
    private int Helper(TreeNode root, HashSet<int> map){
        if(root == null)
            return 0;
        
        
        int left = Helper(root.left, map);
        int right = Helper(root.right, map);
        
        int total = left+right;
        if(map.Contains(root.val)){
            total++;
        }
        
        if(total == map.Count && lca == null){
            lca = root;
        }
        
        return total;
    }
}