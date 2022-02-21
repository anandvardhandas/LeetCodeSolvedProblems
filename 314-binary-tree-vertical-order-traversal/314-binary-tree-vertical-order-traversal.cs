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
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root == null)
            return result;
        
        SortedDictionary<int,List<int>> map = new SortedDictionary<int,List<int>>();
        
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(new Node(root,0));
        
        while(que.Count > 0){
            Node node = que.Dequeue();
            if(!map.ContainsKey(node.level)){
                map.Add(node.level, new List<int>() { node.node.val });
            }
            else{
                map[node.level].Add(node.node.val);
            }
            
            if(node.node.left != null){
                que.Enqueue(new Node(node.node.left, node.level-1));
            }
            
            if(node.node.right != null){
                que.Enqueue(new Node(node.node.right, node.level+1));
            }
        }
        
        
        
        foreach(var item in map.Values){
            IList<int> res = new List<int>();
            foreach(int vals in item){
                res.Add(vals);
            }
            
            result.Add(res);
        }
        
        return result;
    }
}

public class Node{
    public int level;
    public TreeNode node;
    
    public Node(TreeNode _node = null, int _level = 0){
        this.node = _node;
        this.level = _level;
    }
}