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
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        IList<int> result = new List<int>();
        
        Dictionary<TreeNode,TreeNode> map = new Dictionary<TreeNode,TreeNode>();
        FindAllParents(root, map, null);
        Helper(target, map, k, result, null);
        
        return result;
    }
    
    private void FindAllParents(TreeNode root, Dictionary<TreeNode,TreeNode> map, TreeNode parent){
        if(root == null){
            return;
        }
        
        if(!map.ContainsKey(root)){
            map.Add(root,parent);
        }
        
        FindAllParents(root.left, map, root);
        FindAllParents(root.right, map, root);
    }
    
    private void Helper(TreeNode root, Dictionary<TreeNode,TreeNode> map, int k, IList<int> result, TreeNode prev){
        if(root == null){
            return;
        }
        
        if(k == 0){
            result.Add(root.val);
        }
        
        if(root.left != prev)
            Helper(root.left,map,k-1,result,root);
        
        if(root.right != prev)
            Helper(root.right,map,k-1,result,root);
        
        if(map[root] != prev)
            Helper(map[root],map,k-1,result,root);
    }
}